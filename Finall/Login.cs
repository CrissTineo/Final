using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negociocapa;
using EntidadCapa;


namespace Finall
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("server= localhost; database=~vsD3A6;integrated security= true");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            btnocultar.BringToFront();
            txtpas2.PasswordChar = '*';
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            btnmostrar.BringToFront();
            txtpas2.PasswordChar = '\0';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            clsLnUsuario_nuevo LN = new clsLnUsuario_nuevo();
            clsBeUsuario_nuevo Be = new clsBeUsuario_nuevo();
            Be.Correo = user.Text;
            Be.Pass = txtpas2.Text;
        

            if (LN.Obtenerusario(ref Be))
            {
                MessageBox.Show("Logueo Exitoso");
                this.Hide();
                Welcome puerta = new Welcome();
                puerta.ShowDialog();
                Dashboard ventana = new Dashboard();
                ventana.Show();
            }
            



            



        }
    }
}
