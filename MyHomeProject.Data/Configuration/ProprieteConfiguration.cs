using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyHomeProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Data.Configuration
{
    class ProprieteConfiguration: IEntityTypeConfiguration<Propriete>
    {
        public void Configure(EntityTypeBuilder<Propriete> builder)
        {
            builder
                .HasKey(a => a.ProprieteID);
            builder
                .Property(m => m.ProprieteID)
                .UseIdentityColumn();
            builder
                .ToTable("Proprietes");
        }
    }
}
