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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            ventana.Show();

            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            registro ventana = new registro();
            ventana.Show();

            this.Hide();
        }

        private void consultas_Click(object sender, EventArgs e)
        {
            Consulta ventana = new Consulta();
            ventana.Show();

            this.Hide();
        }

        private void NuevoU_Click(object sender, EventArgs e)
        {
            Crearusuario ventana = new Crearusuario();
            ventana.Show();

            this.Hide();
        }
    }
}
