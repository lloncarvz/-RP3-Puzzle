namespace Puzzle
{
    partial class Pocetna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.lblN = new System.Windows.Forms.Label();
            this.lblDimenzije = new System.Windows.Forms.Label();
            this.lblSlobodna = new System.Windows.Forms.Label();
            this.numPrazno = new System.Windows.Forms.NumericUpDown();
            this.lblPomicanje = new System.Windows.Forms.Label();
            this.rbtnKlik = new System.Windows.Forms.RadioButton();
            this.rbtnPovlacenje = new System.Windows.Forms.RadioButton();
            this.groupBoxPomicanje = new System.Windows.Forms.GroupBox();
            this.btnNovaPuzzla = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flpPuzzle = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxPuzzla = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtSlika = new System.Windows.Forms.RadioButton();
            this.rbtBrojevi = new System.Windows.Forms.RadioButton();
            this.btnOdustajem = new System.Windows.Forms.Button();
            this.lblPogadaj = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPogadaj = new System.Windows.Forms.TextBox();
            this.btnPogodi = new System.Windows.Forms.Button();
            this.pnlSlika = new System.Windows.Forms.Panel();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.btnTema = new System.Windows.Forms.Button();
            this.grbSve = new System.Windows.Forms.GroupBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrazno)).BeginInit();
            this.groupBoxPomicanje.SuspendLayout();
            this.groupBoxPuzzla.SuspendLayout();
            this.grbSve.SuspendLayout();
            this.SuspendLayout();
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(160, 32);
            this.numN.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numN.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(29, 20);
            this.numN.TabIndex = 0;
            this.numN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numN.ValueChanged += new System.EventHandler(this.numN_ValueChanged);
            // 
            // numM
            // 
            this.numM.Location = new System.Drawing.Point(195, 32);
            this.numM.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numM.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(29, 20);
            this.numM.TabIndex = 1;
            this.numM.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numM.ValueChanged += new System.EventHandler(this.numM_ValueChanged);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(177, 16);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(35, 13);
            this.lblN.TabIndex = 2;
            this.lblN.Text = "N x M";
            // 
            // lblDimenzije
            // 
            this.lblDimenzije.AutoSize = true;
            this.lblDimenzije.Location = new System.Drawing.Point(17, 34);
            this.lblDimenzije.Name = "lblDimenzije";
            this.lblDimenzije.Size = new System.Drawing.Size(135, 13);
            this.lblDimenzije.TabIndex = 3;
            this.lblDimenzije.Text = "Odaberite dimenzije puzzle:";
            // 
            // lblSlobodna
            // 
            this.lblSlobodna.AutoSize = true;
            this.lblSlobodna.Location = new System.Drawing.Point(17, 70);
            this.lblSlobodna.Name = "lblSlobodna";
            this.lblSlobodna.Size = new System.Drawing.Size(187, 13);
            this.lblSlobodna.TabIndex = 4;
            this.lblSlobodna.Text = "Odaberite broj slobodnih polja u puzzli:";
            // 
            // numPrazno
            // 
            this.numPrazno.Location = new System.Drawing.Point(210, 68);
            this.numPrazno.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrazno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrazno.Name = "numPrazno";
            this.numPrazno.Size = new System.Drawing.Size(38, 20);
            this.numPrazno.TabIndex = 5;
            this.numPrazno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPomicanje
            // 
            this.lblPomicanje.AutoSize = true;
            this.lblPomicanje.Location = new System.Drawing.Point(6, 30);
            this.lblPomicanje.Name = "lblPomicanje";
            this.lblPomicanje.Size = new System.Drawing.Size(89, 13);
            this.lblPomicanje.TabIndex = 6;
            this.lblPomicanje.Text = "Način pomicanja:";
            // 
            // rbtnKlik
            // 
            this.rbtnKlik.AutoSize = true;
            this.rbtnKlik.Checked = true;
            this.rbtnKlik.Location = new System.Drawing.Point(101, 19);
            this.rbtnKlik.Name = "rbtnKlik";
            this.rbtnKlik.Size = new System.Drawing.Size(56, 17);
            this.rbtnKlik.TabIndex = 7;
            this.rbtnKlik.TabStop = true;
            this.rbtnKlik.Text = "Klikom";
            this.rbtnKlik.UseVisualStyleBackColor = true;
            // 
            // rbtnPovlacenje
            // 
            this.rbtnPovlacenje.AutoSize = true;
            this.rbtnPovlacenje.Location = new System.Drawing.Point(101, 42);
            this.rbtnPovlacenje.Name = "rbtnPovlacenje";
            this.rbtnPovlacenje.Size = new System.Drawing.Size(86, 17);
            this.rbtnPovlacenje.TabIndex = 8;
            this.rbtnPovlacenje.Text = "Povlačenjem";
            this.rbtnPovlacenje.UseVisualStyleBackColor = true;
            this.rbtnPovlacenje.CheckedChanged += new System.EventHandler(this.rbtnPovlacenje_CheckedChanged);
            // 
            // groupBoxPomicanje
            // 
            this.groupBoxPomicanje.Controls.Add(this.lblPomicanje);
            this.groupBoxPomicanje.Controls.Add(this.rbtnPovlacenje);
            this.groupBoxPomicanje.Controls.Add(this.rbtnKlik);
            this.groupBoxPomicanje.Location = new System.Drawing.Point(17, 94);
            this.groupBoxPomicanje.Name = "groupBoxPomicanje";
            this.groupBoxPomicanje.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxPomicanje.Size = new System.Drawing.Size(200, 73);
            this.groupBoxPomicanje.TabIndex = 9;
            this.groupBoxPomicanje.TabStop = false;
            // 
            // btnNovaPuzzla
            // 
            this.btnNovaPuzzla.Location = new System.Drawing.Point(20, 173);
            this.btnNovaPuzzla.Name = "btnNovaPuzzla";
            this.btnNovaPuzzla.Size = new System.Drawing.Size(100, 20);
            this.btnNovaPuzzla.TabIndex = 10;
            this.btnNovaPuzzla.Text = "Nova Puzzla";
            this.btnNovaPuzzla.UseVisualStyleBackColor = true;
            this.btnNovaPuzzla.Click += new System.EventHandler(this.btnNovaPuzzla_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "grass_template2.jpg");
            // 
            // flpPuzzle
            // 
            this.flpPuzzle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpPuzzle.Location = new System.Drawing.Point(12, 242);
            this.flpPuzzle.Margin = new System.Windows.Forms.Padding(0);
            this.flpPuzzle.Name = "flpPuzzle";
            this.flpPuzzle.Size = new System.Drawing.Size(1, 0);
            this.flpPuzzle.TabIndex = 11;
            this.flpPuzzle.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpPuzzle_DragDrop);
            this.flpPuzzle.DragOver += new System.Windows.Forms.DragEventHandler(this.flpPuzzle_DragOver);
            // 
            // groupBoxPuzzla
            // 
            this.groupBoxPuzzla.Controls.Add(this.label1);
            this.groupBoxPuzzla.Controls.Add(this.rbtSlika);
            this.groupBoxPuzzla.Controls.Add(this.rbtBrojevi);
            this.groupBoxPuzzla.Location = new System.Drawing.Point(223, 94);
            this.groupBoxPuzzla.Name = "groupBoxPuzzla";
            this.groupBoxPuzzla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBoxPuzzla.Size = new System.Drawing.Size(200, 73);
            this.groupBoxPuzzla.TabIndex = 10;
            this.groupBoxPuzzla.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrsta puzzle";
            // 
            // rbtSlika
            // 
            this.rbtSlika.AutoSize = true;
            this.rbtSlika.Location = new System.Drawing.Point(101, 42);
            this.rbtSlika.Name = "rbtSlika";
            this.rbtSlika.Size = new System.Drawing.Size(48, 17);
            this.rbtSlika.TabIndex = 8;
            this.rbtSlika.Text = "Slika";
            this.rbtSlika.UseVisualStyleBackColor = true;
            // 
            // rbtBrojevi
            // 
            this.rbtBrojevi.AutoSize = true;
            this.rbtBrojevi.Checked = true;
            this.rbtBrojevi.Location = new System.Drawing.Point(101, 19);
            this.rbtBrojevi.Name = "rbtBrojevi";
            this.rbtBrojevi.Size = new System.Drawing.Size(57, 17);
            this.rbtBrojevi.TabIndex = 7;
            this.rbtBrojevi.TabStop = true;
            this.rbtBrojevi.Text = "Brojevi";
            this.rbtBrojevi.UseVisualStyleBackColor = true;
            this.rbtBrojevi.CheckedChanged += new System.EventHandler(this.rbtBrojevi_CheckedChanged);
            // 
            // btnOdustajem
            // 
            this.btnOdustajem.Location = new System.Drawing.Point(41, 377);
            this.btnOdustajem.Name = "btnOdustajem";
            this.btnOdustajem.Size = new System.Drawing.Size(100, 20);
            this.btnOdustajem.TabIndex = 12;
            this.btnOdustajem.Text = "Odustajem";
            this.btnOdustajem.UseVisualStyleBackColor = true;
            this.btnOdustajem.Visible = false;
            this.btnOdustajem.Click += new System.EventHandler(this.btnOdustajem_Click);
            // 
            // lblPogadaj
            // 
            this.lblPogadaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPogadaj.AutoSize = true;
            this.lblPogadaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPogadaj.Location = new System.Drawing.Point(6, 617);
            this.lblPogadaj.Name = "lblPogadaj";
            this.lblPogadaj.Size = new System.Drawing.Size(246, 26);
            this.lblPogadaj.TabIndex = 13;
            this.lblPogadaj.Text = "Pokušajte pogoditi sliku:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPogadaj
            // 
            this.txtPogadaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPogadaj.Location = new System.Drawing.Point(258, 614);
            this.txtPogadaj.Name = "txtPogadaj";
            this.txtPogadaj.Size = new System.Drawing.Size(160, 32);
            this.txtPogadaj.TabIndex = 15;
            // 
            // btnPogodi
            // 
            this.btnPogodi.Location = new System.Drawing.Point(424, 620);
            this.btnPogodi.Name = "btnPogodi";
            this.btnPogodi.Size = new System.Drawing.Size(75, 23);
            this.btnPogodi.TabIndex = 16;
            this.btnPogodi.Text = "Pogodi";
            this.btnPogodi.UseVisualStyleBackColor = true;
            this.btnPogodi.Click += new System.EventHandler(this.btnPogodi_Click);
            // 
            // pnlSlika
            // 
            this.pnlSlika.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSlika.Location = new System.Drawing.Point(526, 41);
            this.pnlSlika.Name = "pnlSlika";
            this.pnlSlika.Size = new System.Drawing.Size(400, 400);
            this.pnlSlika.TabIndex = 17;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Location = new System.Drawing.Point(12, 9);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(82, 13);
            this.lblTema.TabIndex = 18;
            this.lblTema.Text = "Odaberite temu:";
            // 
            // cmbTema
            // 
            this.cmbTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.Items.AddRange(new object[] {
            "Životinje",
            "Prijevozna sredtsva",
            "Namještaj"});
            this.cmbTema.Location = new System.Drawing.Point(100, 6);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(188, 21);
            this.cmbTema.TabIndex = 19;
            // 
            // btnTema
            // 
            this.btnTema.Location = new System.Drawing.Point(294, 6);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(75, 23);
            this.btnTema.TabIndex = 20;
            this.btnTema.Text = "Izaberi temu";
            this.btnTema.UseVisualStyleBackColor = true;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);
            // 
            // grbSve
            // 
            this.grbSve.Controls.Add(this.groupBoxPuzzla);
            this.grbSve.Controls.Add(this.numN);
            this.grbSve.Controls.Add(this.numM);
            this.grbSve.Controls.Add(this.lblN);
            this.grbSve.Controls.Add(this.lblDimenzije);
            this.grbSve.Controls.Add(this.lblSlobodna);
            this.grbSve.Controls.Add(this.numPrazno);
            this.grbSve.Controls.Add(this.groupBoxPomicanje);
            this.grbSve.Controls.Add(this.btnNovaPuzzla);
            this.grbSve.Location = new System.Drawing.Point(15, 35);
            this.grbSve.Name = "grbSve";
            this.grbSve.Size = new System.Drawing.Size(505, 201);
            this.grbSve.TabIndex = 21;
            this.grbSve.TabStop = false;
            this.grbSve.Visible = false;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(526, 14);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(0, 24);
            this.lblNaslov.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "NOVA IGRA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 657);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.grbSve);
            this.Controls.Add(this.btnTema);
            this.Controls.Add(this.cmbTema);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.pnlSlika);
            this.Controls.Add(this.btnPogodi);
            this.Controls.Add(this.txtPogadaj);
            this.Controls.Add(this.lblPogadaj);
            this.Controls.Add(this.btnOdustajem);
            this.Controls.Add(this.flpPuzzle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrazno)).EndInit();
            this.groupBoxPomicanje.ResumeLayout(false);
            this.groupBoxPomicanje.PerformLayout();
            this.groupBoxPuzzla.ResumeLayout(false);
            this.groupBoxPuzzla.PerformLayout();
            this.grbSve.ResumeLayout(false);
            this.grbSve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblDimenzije;
        private System.Windows.Forms.Label lblSlobodna;
        private System.Windows.Forms.NumericUpDown numPrazno;
        private System.Windows.Forms.Label lblPomicanje;
        private System.Windows.Forms.RadioButton rbtnKlik;
        private System.Windows.Forms.RadioButton rbtnPovlacenje;
        private System.Windows.Forms.GroupBox groupBoxPomicanje;
        private System.Windows.Forms.Button btnNovaPuzzla;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flpPuzzle;
        private System.Windows.Forms.GroupBox groupBoxPuzzla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtSlika;
        private System.Windows.Forms.RadioButton rbtBrojevi;
        private System.Windows.Forms.Button btnOdustajem;
        private System.Windows.Forms.Label lblPogadaj;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtPogadaj;
        private System.Windows.Forms.Button btnPogodi;
        private System.Windows.Forms.Panel pnlSlika;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.GroupBox grbSve;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Button button1;
    }
}

