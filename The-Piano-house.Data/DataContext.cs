using Microsoft.EntityFrameworkCore;
using The_piano_house.Core.Entities;

namespace The_piano_house.Data
{
    public class DataContext : DbContext
    {

        public int index { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MusicalInstrument> MusicaLInstruments { get; set; }
        public DbSet<Provider> Providers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=yaely100");
        }
        //public DataContext()
        //{
        //    CustomersList = new List<Customers>();
        //    MusicaLInstrumentList = new List<MusicaLInstrument>();
        //    ProviderList = new List<Provider>();
        //   index=0;
        //}
    }
}
