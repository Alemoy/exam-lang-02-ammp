using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_app
{
    public partial class Home : Form
    {
        public string Email { get; set; }
        public Home(string email)
        {
            InitializeComponent();
            this.Email = email;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblEmail.Text = this.Email;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            this.panel4.Visible = false;
            this.panel3.Visible = true;


            this.timer1.Enabled = false;
            this.timer1.Stop();
        }

        private void cerrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            pnl.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Panel pnl = (Panel)sender;
            pnl.BorderStyle = BorderStyle.None;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Serviciosfrm inicio = new Serviciosfrm();
            inicio.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientesfrm inicio = new Clientesfrm();
            inicio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manregistro inicio = new Manregistro();
            inicio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mandetalle inicio = new Mandetalle();
            inicio.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManUpdated inicio = new ManUpdated();
            inicio.ShowDialog();
        }
    }
}
