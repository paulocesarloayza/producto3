namespace productoBackend.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<productoBackend.Models.Producto> Productoes { get; set; }
    }
}