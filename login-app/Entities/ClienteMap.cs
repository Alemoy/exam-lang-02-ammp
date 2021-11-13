using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_app
{
    public class ClienterMap : EntityTypeConfiguration<Cliente>
    {
        public ClienterMap()
        {
            ToTable("clientes");

            Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Name).IsRequired();
            Property(p => p.Email).IsRequired();
            Property(p => p.Registro).IsRequired();
        }
    }
}
