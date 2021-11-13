using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_app
{
    public class ManteniminentoMap : EntityTypeConfiguration<Mantenimiento>
    {
        public ManteniminentoMap()
        {
            ToTable("mantenimientos");

            Property(p => p.Id).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.Marca).IsRequired();
            Property(p => p.Modelo).IsRequired();
            Property(p => p.Servicio).IsRequired();
            Property(p => p.Detalle).IsRequired();
            Property(p => p.Estado).IsRequired();
            Property(p => p.Cliente).IsRequired();

        }
    }
}
