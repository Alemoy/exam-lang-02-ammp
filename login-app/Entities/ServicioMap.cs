using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_app
{
    public class ServicioMap : EntityTypeConfiguration<Servicio>
    {
        public ServicioMap()
        {
            ToTable("servicios");

            Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Tipo).IsRequired();
        }
    }
}
