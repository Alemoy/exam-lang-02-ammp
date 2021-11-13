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
    public partial class Manregistro : Form
    {
        private DatabaseContext context = new DatabaseContext();

        public Manregistro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mantenimiento tikect = new Mantenimiento();
            string registro = clientregistro.Text;
            Cliente cli = context.Clientes.Where(X => X.Registro == registro).FirstOrDefault();

            tikect.Id = context.Tickets.Count() + 1;

            tikect.Cliente = cli.Name;

            tikect.Detalle = detalle.Text;
            tikect.Estado = cbmestado.Text;
            tikect.Marca = marca.Text;
            tikect.Modelo = modelo.Text;
            tikect.Servicio = cbmservi.Text;

            context.Tickets.Add(tikect);
            context.SaveChanges();

        }

        private void Manregistro_Load(object sender, EventArgs e)
        {
            cbmservi.DataSource = context.Servicios.ToList();
            cbmservi.DisplayMember = "Tipo";
            cbmservi.ValueMember = "Id";
            cbmestado.SelectedIndex = 0;

        }
    }
}
