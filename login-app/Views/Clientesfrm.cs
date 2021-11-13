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
    public partial class Clientesfrm : Form
    {
        private DatabaseContext context = new DatabaseContext();
        public Clientesfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente clinte = new Cliente();

            clinte.Id = context.Clientes.Count() + 1;
            clinte.Name = textBox1.Text;
            clinte.Email = textBox4.Text;
            clinte.Registro = textBox3.Text;
         

            context.Clientes.Add(clinte);
            context.SaveChanges();

            dataGridView1.DataSource = context.Clientes.ToList();

        }

        private void Clientesfrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Clientes.ToList();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
