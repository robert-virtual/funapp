using funapp.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace funapp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var user = Main.Clients.Find(u => u.Name == txt_user.Text);
            if (user == null)
            {
                err(1);
                return;
            }

            var res = Clave.Verify(txt_password.Text, user.Clave);
            if (!res)
            {
                err(2);
                return;
            }
            MessageBox.Show($"Bienvenido {user.Name}");
        }
        void err(int n = 0)
        {
            MessageBox.Show($"{n}. Credenciales incorrectas");

        }
    }
}
