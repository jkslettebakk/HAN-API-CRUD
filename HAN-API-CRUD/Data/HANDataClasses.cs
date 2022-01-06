

namespace HAN_API_CRUD.Data
{
    public class List1
    {
        [Key]
        [Required]
        public Guid HANDataId { get; set; }
        [Required]
        public string DateTimePoll { get; set; } = null!;
        [Required]
        public string VersionIdentifier { get; set; } = null!;
        [Required]
        public string ModelID { get; set; } = null!;
        [Required]
        public string ModelType { get; set; } = null!;
        [Required]
        public virtual ActivePowerQ1Q4Object ActivePowerQ1Q4 { get; set; } = new ActivePowerQ1Q4Object();
    }
        public class List2
    {
        [Key]
        [Required]
        public Guid HANDataId { get; set; }
        [Required]
        public string DateTimePoll { get; set; } = null!;
        [Required]
        public string VersionIdentifier { get; set; } = null!;
        [Required]
        public string ModelID { get; set; } = null!;
        [Required]
        public string ModelType { get; set; } = null!;
        [Required]
        public virtual ActivePowerQ1Q4Object ActivePowerQ1Q4 { get; set; } = new ActivePowerQ1Q4Object();
        [Required]
        public virtual ActivePowerQ2Q3Object ActivePowerQ2Q3 { get; set; } = new ActivePowerQ2Q3Object();
        [Required]
        public virtual ReactivePowerQ1Q2Object ReactivePowerQ1Q2 { get; set; } = new ReactivePowerQ1Q2Object();
        [Required]
        public virtual ReactivePowerQ3Q4Object ReactivePowerQ3Q4 { get; set; } = new ReactivePowerQ3Q4Object();
        [Required]
        public virtual AmpereIL1Object AmpereIL1 { get; set; } = new AmpereIL1Object();
        [Required]
        public virtual AmpereIL3Object AmpereIL3 { get; set; } = new AmpereIL3Object();
        [Required]
        public virtual VoltUL1Object VoltUL1 { get; set; } = new VoltUL1Object();
        [Required]
        public virtual VoltUL2Object VoltUL2 { get; set; } = new VoltUL2Object();
        [Required]
        public virtual VoltUL3Object VoltUL3 { get; set; } = new VoltUL3Object();
    }
    public class List3
    {
        [Key]
        [Required]
        public Guid HANDataId { get; set; }
        [Required]
        public string DateTimePoll { get; set; } = null!;
        [Required]
        public string VersionIdentifier { get; set; } = null!;
        [Required]
        public string ModelID { get; set; } = null!;
        [Required]
        public string ModelType { get; set; } = null!;
        [Required]
        public virtual ActivePowerQ1Q4Object ActivePowerQ1Q4 { get; set; } = new ActivePowerQ1Q4Object();
        [Required]
        public virtual ActivePowerQ2Q3Object ActivePowerQ2Q3 { get; set; } = new ActivePowerQ2Q3Object();
        [Required]
        public virtual ReactivePowerQ1Q2Object ReactivePowerQ1Q2 { get; set; } = new ReactivePowerQ1Q2Object();
        [Required]
        public virtual ReactivePowerQ3Q4Object ReactivePowerQ3Q4 { get; set; } = new ReactivePowerQ3Q4Object();
        [Required]
        public virtual AmpereIL1Object AmpereIL1 { get; set; } = new AmpereIL1Object();
        [Required]
        public virtual AmpereIL3Object AmpereIL3 { get; set; } = new AmpereIL3Object();
        [Required]
        public virtual VoltUL1Object VoltUL1 { get; set; } = new VoltUL1Object();
        [Required]
        public virtual VoltUL2Object VoltUL2 { get; set; } = new VoltUL2Object();
        [Required]
        public virtual VoltUL3Object VoltUL3 { get; set; } = new VoltUL3Object();
        [Required]
        public virtual ActivePowerAQ1Q4Object ActivePowerAQ1Q4 { get; set; } = new ActivePowerAQ1Q4Object();
        [Required]
        public virtual ActivePowerAQ2Q3Object ActivePowerAQ2Q3 { get; set; } = new ActivePowerAQ2Q3Object();
        [Required]
        public virtual ReactivePowerRQ1Q2Object ReactivePowerRQ1Q2 { get; set; } = new ReactivePowerRQ1Q2Object();
        [Required]
        public virtual ReactivePowerRQ3Q4Object ReactivePowerRQ3Q4 { get; set; } = new ReactivePowerRQ3Q4Object();

    }
    public class ActivePowerQ1Q4Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public double ActivePowerQ1Q4 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class ActivePowerQ2Q3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ActivePowerQ2Q3 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class ActivePowerAQ1Q4Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ActivePowerAQ1Q4 { get; set; }
        [Required]
        public string UoM { get; set; }
    }
    public class ActivePowerAQ2Q3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ActivePowerAQ2Q3 { get; set; }
        [Required]
        public string UoM { get; set; }
    }
    public class ReactivePowerQ1Q2Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ReactivePowerQ1Q2 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class ReactivePowerQ3Q4Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ReactivePowerQ3Q4 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class ReactivePowerRQ3Q4Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ReactivePowerRQ3Q4 { get; set; }
        [Required]
        public string UoM { get; set; }
    }

    public class ReactivePowerRQ1Q2Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double ReactivePowerRQ1Q2 { get; set; }
        [Required]
        public string UoM { get; set; }
    }
    public class AmpereIL1Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double AmpereIL1 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class AmpereIL3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public double AmpereIL3 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class VoltUL1Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int VoltUL1 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class VoltUL2Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int VoltUL2 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class VoltUL3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int VoltUL3 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public virtual DbSet<List1> List1 { get; set; }
        public virtual DbSet<List2> List2 { get; set; }
        public virtual DbSet<List3> List3 { get; set; }
        public virtual DbSet<ActivePowerQ1Q4Object> ActivePowerQ1Q4 { get; set; }
        public virtual DbSet<ActivePowerQ2Q3Object> ActivePowerQ2Q3 { get; set; }
        public virtual DbSet<ReactivePowerQ1Q2Object> ReactivePowerQ2Q3 { get; set; }
        public virtual DbSet<ReactivePowerQ3Q4Object> ReactivePowerQ3Q4 { get; set; }
        public virtual DbSet<AmpereIL1Object> AmpereIL1 { get; set; }
        public virtual DbSet<AmpereIL3Object> AmpereIL3 { get; set; }
        public virtual DbSet<VoltUL1Object> VoltUL1 { get; set; }
        public virtual DbSet<VoltUL2Object> VoltUL2 { get; set; }
        public virtual DbSet<VoltUL3Object> VoltUL3 { get; set; }
        public virtual DbSet<ActivePowerAQ1Q4Object> ActivePowerAQ1Q4 { get; set; }
        public virtual DbSet<ActivePowerAQ2Q3Object> ActivePowerAQ2Q3 { get; set; }
        public virtual DbSet<ReactivePowerRQ1Q2Object> ReactivePowerRQ2Q3 { get; set; }
        public virtual DbSet<ReactivePowerRQ3Q4Object> ReactivePowerRQ3Q4 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add the shadow property to the model
            /*
            modelBuilder.Entity<ActivePowerQ1Q4Object>()
                .Property<Guid>("ForeignHANDataLink_ActivePowerQ1Q4_HANData");
            */
            // Use the shadow property as a foreign key
            /*
            modelBuilder.Entity<ActivePowerQ1Q4Object>()
            .HasOne(p => p.HANData)
            .WithOne(b => b.ActivePowerQ1Q4)
            .HasForeignKey(p => p.HANDataLink)
            .HasPrinsipalKey(b => b.HANDataLink)
            */
        }
    }

}
