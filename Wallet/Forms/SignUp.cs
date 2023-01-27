using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wallet.Forms
{
    public partial class SignUp : Form
    {

        private Boolean confirmPass = false;

        public SignUp()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Form1 frm = new Form1();
            frm.Show();
            this.Dispose();
            
        }

     

        private void textConfirm_Leave(object sender, EventArgs e)
        {
              string password = textPass.Text;
              string confirm = textConfirm.Text;

            if (confirm != password)
            {
                confirmPass = false;
            }
            else
            {
                confirmPass = true;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (confirmPass)
            {
                MessageBox.Show("Bienvenido " + textFirstN.Text);
            }
            else {

                MessageBox.Show("Las contraseña no coinciden");
            }
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            string password = textPass.Text;
            string confirm = textConfirm.Text;

            if (confirm != password)
            {
                confirmPass = false;
            }
            else
            {
                confirmPass = true;
            }
        }
    }
}
