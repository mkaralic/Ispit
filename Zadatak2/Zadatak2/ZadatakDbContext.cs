using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadatak2.Models;

namespace Zadatak2
{
    public class ZadatakDbContext : DbContext
    {
        public virtual DbSet<Ljubimac> Ljubimci { get; set; }

        public ZadatakDbContext()
        {

        }
        public ZadatakDbContext(DbContextOptions<ZadatakDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("data source=.;database=IspitCS322;Integrated Security=SSPI;persist security info=True; Trust Server Certificate=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ljubimac>().HasData(
                new Ljubimac { Id = 1, Ime = "Maca 1", Vrsta = "macka", Cena = 50, NivoHrane = 100, NivoSrece = 100 },
                new Ljubimac { Id = 2, Ime = "Pas 1", Vrsta = "pas", Cena = 150, NivoHrane = 100, NivoSrece = 100 }
            );
        }
    }
}
