using Core.Base.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Mapp
{
    public class MedicoMap : EntityTypeConfiguration<Medico>
    {
        public MedicoMap()
        {
            ToTable("Medico");
            HasKey(x => x.Id);
        }

    }
}
