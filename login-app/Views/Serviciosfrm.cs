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
    public partial class Serviciosfrm : Form
    {
        private DatabaseContext context = new DatabaseContext();

        public Serviciosfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servicio serv = new Servicio();

            serv.Id = context.Servicios.Count() +1 ;
            serv.Tipo = textBox1.Text;

            context.Servicios.Add(serv);
            context.SaveChanges();

            dataGridView1.DataSource = context.Servicios.ToList();
        }

        private void Serviciosfrm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Servicios.ToList();
        }
    }
}
