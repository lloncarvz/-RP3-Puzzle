using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using ImageProcessor;

namespace Puzzle
{
    public partial class Pocetna : Form
    {
        int n, m, prazno;

        PuzzleButton moveBtn;
        Cursor moveCursor;
        
        string slika;

        ImageFactory imgf = new ImageFactory();

        int filtri;

        bool nacin = true, vrsta = true;

        public void imgFactoryFiltri()
        {
            imgf.Load(resizeImage((Bitmap)Properties.Resources.ResourceManager.GetObject(slika),new Size(400,400)));
            for (int i = 0; i < filtri; ++i){
                if (i % 3 == 0)
                    imgf.GaussianBlur(25);
                else if (i % 3 == 1)
                    imgf.Pixelate(25);
                else
                    imgf.Brightness(-25);
            }
            pnlSlika.BackgroundImage = imgf.Image;
        }

        public static Bitmap resizeImage(Image imgToResize, Size size)
        {
            return (Bitmap)(new Bitmap(imgToResize, size));
        }

        public Pocetna()
        {
            InitializeComponent();
            lblPogadaj.Visible = false;
            txtPogadaj.Visible = false;
            btnPogodi.Visible = false;
            cmbTema.SelectedIndex = 0;
            filtri = 6;
            this.Text = "Puzzle";
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {

        }

        private void numN_ValueChanged(object sender, EventArgs e)
        {
            if (rbtnPovlacenje.Checked)
            {
                numPrazno.Maximum = numN.Value * numM.Value - 1;
            }
            else
            {
                numPrazno.Maximum = 1;
            }
        }

        private void numM_ValueChanged(object sender, EventArgs e)
        {
            if (rbtnPovlacenje.Checked)
            {
                numPrazno.Maximum = numN.Value * numM.Value - 1;
            }
            else
            {
                numPrazno.Maximum = 1;
            }
        }

        private void rbtnPovlacenje_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPovlacenje.Checked)
            {
                numPrazno.Maximum = numN.Value * numM.Value - 1;
                flpPuzzle.AllowDrop = true;
                nacin = false;
            }
            else
            {
                numPrazno.Maximum = 1;
                flpPuzzle.AllowDrop = false;
                nacin = true;
            }
        }

        private void rbtBrojevi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBrojevi.Checked)
                vrsta = true;
            else
                vrsta = false;
        }

        //metoda kojom mijenjamo buttone prilikom pritiska na neki button - provjerava se je li pritisnut button prazan
        //ako nije tada se prazan button sprema u varijablu i provjeravaju se pozicije buttona kao uvjet za promjenu
        private void swapLabel(Object sender, EventArgs e)
        {
            PuzzleButton btn = (PuzzleButton)sender;
            if (vrsta)
            {
                if (btn.Text == "")
                    return;
            }
            else
            {
                if (btn.Image == null)
                    return;
            }

            PuzzleButton prazniBtn = null;
            if (vrsta)
            {
                foreach (PuzzleButton bt in flpPuzzle.Controls)
                {
                    if (bt.Text == "")
                    {
                        prazniBtn = bt;
                        break;
                    }
                }

                if ((btn.pos == (prazniBtn.pos - 1) && prazniBtn.pos % n != 1) || btn.pos == (prazniBtn.pos + n) || 
                    btn.pos == (prazniBtn.pos - n) || (btn.pos == (prazniBtn.pos + 1) && prazniBtn.pos % n != 0))
                {
                    prazniBtn.BackColor = Color.LightSkyBlue;
                    btn.BackColor = Color.GhostWhite;
                    prazniBtn.value = btn.value;
                    prazniBtn.Text = btn.Text;
                    btn.Text = "";
                    btn.value = 0;
                    flpPuzzle.Focus();
                }
                rjesenje();
            }
            else
            {
                foreach (PuzzleButton bt in flpPuzzle.Controls)
                {
                    if (bt.Image == null)
                    {
                        prazniBtn = bt;
                        break;
                    }
                }

                if ((btn.pos == (prazniBtn.pos - 1) && prazniBtn.pos % n != 1) || btn.pos == (prazniBtn.pos + n) || btn.pos == (prazniBtn.pos - n) || (btn.pos == (prazniBtn.pos + 1) && prazniBtn.pos % n != 0))
                {
                    prazniBtn.Image = btn.Image;
                    prazniBtn.value = btn.value;
                    btn.value = 0;
                    btn.Image = null;
                    flpPuzzle.Focus();
                }
                rjesenje();
            }
        }

        //pritiskom na button nova puzzla poziva se ova metoda koja slaže novu igru tako da nasumično rasporedi 
        //brojeve buttona
        private void btnNovaPuzzla_Click(object sender, EventArgs e)
        {
            grbSve.Enabled = false;

            n = (int)numN.Value;
            m = (int)numM.Value;
            prazno = (int)numPrazno.Value;
            int brPolja = n * m - prazno;

            flpPuzzle.Width = n * 50 + n + 1;
            flpPuzzle.Height = m * 50 + m + 1;

            btnOdustajem.Visible = true;
            btnOdustajem.Location = new Point(flpPuzzle.Width / 2 - 40, flpPuzzle.Location.Y + flpPuzzle.Height);

            Random rand = new Random();

            for (int i = 0; i < n * m; i++)
            {
                PuzzleButton pbtn = new PuzzleButton();
                pbtn.pos = i + 1;
                if (nacin)
                    pbtn.Click += new EventHandler(swapLabel);
                else
                {
                    pbtn.MouseDown += new MouseEventHandler(btnMouseDown);
                }
                flpPuzzle.Controls.Add(pbtn);
            }

            List<int> listaBrojeva = new List<int>();
            for (int i = 1; i <= brPolja; i++)
            {
                listaBrojeva.Add(i);
            }
            //provjeravamo je li vrsta puzzle brojevi ili slika, ako su brojevi dodijeli nasumicno brojeve
            //ako se želi implementirati slika, treba sliku razrezati na n*m dijelova te nasumicno te dijelove podijeliti
            //pazeći da postavljamo za odgovarajući dio odgovarajući value svakom buttonu
            if (vrsta)
            {
                foreach (PuzzleButton btn in flpPuzzle.Controls)
                {

                    if (listaBrojeva.Count != 0)
                    {
                        int r = rand.Next(listaBrojeva.Count);
                        btn.Text = listaBrojeva[r] + "";
                        btn.value = listaBrojeva[r];
                        btn.BackColor = Color.LightSkyBlue;
                        listaBrojeva.RemoveAt(r);
                    }
                    else
                    {
                        btn.Text = "";
                        btn.value = 0;
                        btn.BackColor = Color.GhostWhite;
                    }
                }
            }
            else
            {
                Bitmap img = Properties.Resources.slagalica;
                Bitmap newimg = resizeImage(img, new Size(n * 50, m * 50));
                var Pixel_format = newimg.PixelFormat;
                var imgarray = new Image[n * m];
                //int k = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        var index = i * n + j;
                        RectangleF Tile = new RectangleF();
                        Tile.Width = 50;
                        Tile.Height = 50;
                        Tile.X = j * 50;
                        Tile.Y = i * 50;
                        imgarray[index] = newimg.Clone(Tile, Pixel_format);
                    }
                }

                for (int i = 0; i < (n * m - prazno); i++)
                {
                    listaBrojeva[i] = i;
                }

                foreach (PuzzleButton btn in flpPuzzle.Controls)
                {
                    if (listaBrojeva.Count != 0)
                    {
                        int r = rand.Next(listaBrojeva.Count);
                        btn.Image = imgarray[listaBrojeva[r]];
                        btn.value = listaBrojeva[r] + 1;
                        listaBrojeva.RemoveAt(r);
                    }
                    else
                    {
                        btn.Image = null;
                        btn.value = 0;
                    }
                }
            }

        }

        //metoda koja provjerava je su li buttoni poredani po redu
        protected void rjesenje()
        {
            if (vrsta)
            {
                int i = 1;
                foreach (PuzzleButton btn in flpPuzzle.Controls)
                {
                    if (btn.Text != "" && btn.value != i)
                    {
                        return;
                    }
                    i++;
                }
                filtri--;
                imgFactoryFiltri();
                txtPogadaj.Visible = true;
                lblPogadaj.Visible = true;                
                btnPogodi.Visible = true;
                btnOdustajem.Visible = false;
                txtPogadaj.Focus();                
            }
            else
            {
                int i = 1;
                foreach (PuzzleButton btn in flpPuzzle.Controls)
                {
                    if (btn.Image != null && btn.value != i)
                    {
                        return;
                    }
                    i++;
                }
                filtri--;
                imgFactoryFiltri();
                txtPogadaj.Visible = true;
                lblPogadaj.Visible = true;
                btnPogodi.Visible = true;
                txtPogadaj.Focus();
            }
        }

        //pritiskom na button odustajem i prihvaćanjem messageboxa, vraća se mogućnost odabira nove puzzle
        //i dodaje se jedan filter za sliku
        private void btnOdustajem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jeste li sigurni da želite odustati? Odustajanjem se dodaje još jedan filter na sliku.", "Jeste li sigurni?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                filtri++;
                imgFactoryFiltri();
                prvobitnoStanje();
            }
        }

        //metoda za vraćanje na prvobitno stanje
        private void prvobitnoStanje()
        {
            btnOdustajem.Visible = false;
            flpPuzzle.Controls.Clear();
            flpPuzzle.Height = 0;
            flpPuzzle.Width = 0;
            lblPogadaj.Visible = false;
            txtPogadaj.Visible = false;
            txtPogadaj.Text = "";
            btnPogodi.Visible = false;
            grbSve.Enabled = true;
        }

        private void groupBoxPuzzla_Enter(object sender, EventArgs e)
        {

        }

        private void numPrazno_ValueChanged(object sender, EventArgs e)
        {
            prazno = (int)numPrazno.Value;
        }

        private void rbtSlika_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void novaIgra()
        {
            grbSve.Visible = false;
            cmbTema.Visible = true;
            btnTema.Visible = true;
            lblTema.Visible = true;
            pnlSlika.BackgroundImage = null;
            lblNaslov.Text = "";
            slika = "";
            filtri = 6;
        }
        private void btnPogodi_Click(object sender, EventArgs e)
        {
            if(txtPogadaj.Text != "")
            {
                if(txtPogadaj.Text.ToLower() == slika.ToLower())
                {
                    filtri = 0;
                    imgFactoryFiltri();
                    prvobitnoStanje();
                    MessageBox.Show("ČESTITAMO <3");
                    novaIgra();
                }
                else
                {
                    MessageBox.Show("Netočno. Složite novu puzzlu.");
                    prvobitnoStanje();
                }
            }
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            int x = cmbTema.SelectedIndex;
            Random rand = new Random();
            int r = rand.Next(0, 4);

            if(x == 0)
            {
                if (r == 0) slika = "pas";
                else if (r == 1) slika = "macka";
                else if (r == 2) slika = "zec";
                else slika = "ptica";
            }
            else if (x == 1)
            {
                if (r == 0) slika = "auto";
                else if (r == 1) slika = "brod";
                else if (r == 2) slika = "vlak";
                else slika = "avion";
            }
            else
            {
                if (r == 0) slika = "ormar";
                else if (r == 1) slika = "krevet";
                else if (r == 2) slika = "stolac";
                else slika = "stol";
            }

            imgFactoryFiltri();
            grbSve.Visible = true;
            cmbTema.Visible = false;
            btnTema.Visible = false;
            lblTema.Visible = false;
            lblNaslov.Text = cmbTema.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novaIgra();
            prvobitnoStanje();
            lblNaslov.Text = "";
        }

        private void pnlSlika_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbSve_Enter(object sender, EventArgs e)
        {

        }

        //metode koje služe za drag&drop način slaganja puzzle
        //dragover metoda prikazuje efekt povlačenja preko flowlayoutpanela
        //dragdrop metoda provjerava gdje smo spustili element, ako je zamjena dopuštena, mijenjamo buttone
        //mousedown metodom mijenjamo izgled cursora i radimo effect micanja
        private void flpPuzzle_DragOver(object sender, DragEventArgs e)
        {
            Cursor.Current = moveCursor;
            e.Effect = DragDropEffects.Move;
        }
        private void flpPuzzle_DragDrop(object sender, DragEventArgs e)
        {
            Point p = this.flpPuzzle.PointToClient(new Point(e.X, e.Y));
            PuzzleButton btn = (PuzzleButton)flpPuzzle.GetChildAtPoint(p);
            if (btn != null)
            {
                if (vrsta)
                {
                    if (btn.Text == "")
                    {
                            btn.BackColor = Color.LightSkyBlue;
                            moveBtn.BackColor = Color.GhostWhite;
                            btn.Text = moveBtn.Text;
                            btn.value = int.Parse(moveBtn.Text);
                            moveBtn.value = 0;
                            moveBtn.Text = "";
                            rjesenje();
                            flpPuzzle.Focus();
              
                    }
                }

                else if (btn.Image == null)
                {
                    btn.Image = moveBtn.Image;
                    moveBtn.Image = null;
                    btn.value = moveBtn.value;
                    moveBtn.value = 0;
                    rjesenje();
                    flpPuzzle.Focus();
                }
            }
        }
        private void btnMouseDown(object sender, MouseEventArgs e)
        {
            PuzzleButton btn = (PuzzleButton)sender;
            if (vrsta)
            {
                if (btn.Text != "")
                {
                    moveBtn = btn;
                    Bitmap bit = new Bitmap(50, 50);
                    moveBtn.DrawToBitmap(bit, new Rectangle(Point.Empty, bit.Size));
                    moveCursor = new Cursor(bit.GetHicon());
                    Cursor.Current = moveCursor;
                    DoDragDrop(this, DragDropEffects.Move);
                }
            }
            else if (btn.Image != null)
            {
                moveBtn = btn;
                Bitmap bit = new Bitmap(50, 50);
                moveBtn.DrawToBitmap(bit, new Rectangle(Point.Empty, bit.Size));
                moveCursor = new Cursor(bit.GetHicon());
                Cursor.Current = moveCursor;
                DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }



    //naša klasa za button kako bi dodali varijablu pos kojom pratimo poziciju buttonu u flowlayoutpanelu kako bi mogli mijenjati pozicije
    //sadrži varijablu value kojom provjeravamo je su li dobro poredani buttoni
    public class PuzzleButton : Button
    {
        public int pos;
        public int value;
        public PuzzleButton() : base()
        {
            Height = 50;
            Width = 50;
            TextAlign = ContentAlignment.MiddleCenter;
            pos = 0;
            value = 0;
            FlatStyle = FlatStyle.Flat;
            Margin = new Padding(0, 0, 0, 0);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.MouseDownBackColor = Color.SkyBlue;
        }

    }

}
