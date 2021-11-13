using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_app
{
    public partial class Login : Form
    {
        private DatabaseContext context = new DatabaseContext();
        public Login()
        {
            InitializeComponent();
            this.context.Database.CreateIfNotExists();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.showlogin();
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.showlogin(false);

        }

        private void btnRegistre_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.Id = context.Users.Count() + 1;
            user.Name = txtEmail.Text;
            user.Email = txtEmail.Text;
            user.Password = this.EncrypPassword(txtClave.Text);

            context.Users.Add(user);
            context.SaveChanges();

            this.clearEntries();
            this.showlogin();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cipherpwd = this.EncrypPassword(txtClave.Text);
            var user = context.Users.Where<User>( x => x.Email == txtEmail.Text && x.Password == cipherpwd).FirstOrDefault();

            if (user != null && !String.IsNullOrEmpty(user.Email))
            {
                this.clearEntries();

                Home inicio = new Home(user.Email);
                this.Hide();
                if (inicio.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Datos incorrectos intente de nuevo","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning );
                this.clearEntries();
            }
        }

        private void clearEntries()
        {
            txtClave.Text = String.Empty;
            txtEmail.Text = String.Empty;
        }

        private void showlogin(bool status = true)
        {
            if (status)
            {
                this.btnLogin.Visible = true;
                this.btnRegistre.Visible = false;
                this.lnkRegistro.Visible = true;
                this.label3.Text = "Autenticacion";
                this.back.Visible = false;
            }
            else
            {
                this.btnLogin.Visible = false;
                this.btnRegistre.Visible = true;
                this.lnkRegistro.Visible = false;
                this.label3.Text = "Registro";
                this.back.Visible = true;
            }
          
        }

        private string EncrypPassword(string password)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            { 
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.clearEntries();
            this.showlogin();
        }
    }
}
