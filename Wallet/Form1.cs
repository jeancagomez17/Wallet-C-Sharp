using Wallet.Conexion;
using Wallet.Controllers;
using Wallet.Models;
using Wallet.Forms;

namespace Wallet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            userControllers controller = new userControllers();

            string email = textEmail.Text;
            string pass = textPass.Text;
            if(email == "" || pass == "")
            {
                MessageBox.Show("Los campos no deben estar vacios", "Sesion");
            }else
            {
                Boolean signin = controller.SignIn(email, pass);
                if (signin)
                {
                    MessageBox.Show("Bienvenido");
                    
                }
                else
                {
                    MessageBox.Show("Error en las credenciales", "Sesion");
                }
            }
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            SignUp singUp = new SignUp();
            singUp.Show();
            this.Hide();
            
            
        }
    }
}