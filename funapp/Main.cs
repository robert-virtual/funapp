using funapp.models;
using funapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funapp
{
    public partial class Main : Form
    {
        public static List<models.Client> Clients = new List<Client>();
        public Main()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            using (var db = new FacecuteContext())
            {
                Clients = db.Clients.ToList();
            }
            loadDgv();

        }

        void loadDgv()
        {
            dgv_users.DataSource = null;
            dgv_users.DataSource = Clients;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            
            using (var db = new FacecuteContext())
            {
                var user = new models.Client()
                {
                    Name = txt_user.Text.Trim(),
                    Clave = Clave.Encrypt(txt_password.Text)
                };
                db.Clients.Add(user);
                db.SaveChanges();
                txt_user.Clear();
                txt_password.Clear();
                MessageBox.Show($"{user.Clave}",$"Clave len: {user.Clave.Length}");
                LoadData();

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
        }
    }
}
