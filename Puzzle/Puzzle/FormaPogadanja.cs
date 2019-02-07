using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class FormaPogadanja : Form
    {
        public string pokusaj;

        public FormaPogadanja()
        {
            InitializeComponent();
        }

        private void FormaPogadanja_Load(object sender, EventArgs e)
        {
            this.Text = "Pogodite što je na slici!";            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt1.Text != "")
            {
                Pocetna forma = (Pocetna)ParentForm;
                forma.pokušaj = txt1.Text;
                Close();
            }
                
        }
    }
}
