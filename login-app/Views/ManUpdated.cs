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
    public partial class ManUpdated : Form
    {
        private DatabaseContext context = new DatabaseContext();

        public ManUpdated()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(clientregistro.Text);

            var tiket = context.Tickets.Where(X => X.Id == codigo).FirstOrDefault();
            tiket.Estado = cbmestado.Text;
            context.Entry(tiket).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();

        }
    }
}
