using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finall
{
    public partial class Crearusuario : Form
    {
        public Crearusuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            btnocultar.BringToFront();
            textpas.PasswordChar = '*';
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            btnmostrar.BringToFront();
            textpas.PasswordChar = '\0';


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dashboard ventana = new Dashboard();
            ventana.Show();

            this.Hide();
        }
    }
}
 