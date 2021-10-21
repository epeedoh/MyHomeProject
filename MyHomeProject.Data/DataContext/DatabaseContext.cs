
using Microsoft.EntityFrameworkCore;
using MyHomeProject.Core.Models;

using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeProject.Data.DataContext
{
    public class DatabaseContext:DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                opsBuilder.UseSqlServer(settings.sqlConnectionString);
                //opsBuilder.UseSqlite(settings.sqlConnectionString);
                dbOptions = opsBuilder.Options;
            }
            public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }

        }
        public static OptionsBuild ops = new OptionsBuild();
        public DatabaseContext (DbContextOptions<DatabaseContext> options) : base(options) { }
        //public DbSet<User> Users { get; set; }
    
        public DbSet<Pays> Pays { get; set; }
        public DbSet<Personne> Personnes { get; set; }
   
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<Sexe> Sexes { get; set; }
   
        public DbSet<Utilisateur> Utilisateurs { get; set; }

        public DbSet<Propriete> Proprietes { get; set; }

        public DbSet<TypePropriete> TypeProprietes { get; set; }

        public DbSet<Ville> Villes { get; set; }
        public DbSet<Commune> Communes { get; set; }
        public DbSet<Quartier> Quartiers { get; set; }
        public DbSet<Societe> Societes { get; set; }
        public DbSet<ProgrammeImmobilier> ProgrammeImmobiliers { get; set; }
        public DbSet<TypeTransaction> TypeTransactions { get; set; }
        public DbSet<EtatTransaction> EtatTransactions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<TypeStanding> TypeStandings { get; set; }

    }
}
