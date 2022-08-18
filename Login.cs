using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Ingrese su Usuario y su Contraseña");
            }
            else if (UnameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Usuario y Contraseña Incorrecta");
                UnameTb.Text = "";
                PasswordTb.Text = "";
            }
        }
    }
}
