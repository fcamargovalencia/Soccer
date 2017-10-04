namespace Soccer.Domain
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Soccer.Domain.League> Leagues { get; set; }
    }
}
