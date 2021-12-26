
namespace HAN_API_CRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<HANDataClasses> HANData { get; set; }
    }
}