
namespace HAN_API_CRUD.Data
{
    public class HANDataClasses
    {
        [Key]
        [Required]
        public Guid HANId { get; set; } = new Guid();
        [Required]
        public string dateTimePoll { get; set; } = null!;
        [Required]
        public string versionIdentifier { get; set; } = null!;
        [Required]
        public string modelID { get; set; } = null!;
        [Required]
        public string modelType { get; set; } = null!;
        public activePowerQ1Q4Object activePowerQ1Q4 { get; set; } = null!;
        public activePowerQ2Q3Object activePowerQ2Q3 { get; set; } = null!;
        public reactivePowerQ1Q2Object reactivePowerQ1Q2 { get; set; } = null!;
        public reactivePowerQ3Q4Object reactivePowerQ3Q4 { get; set; } = null!;
        public ampereIL1Object ampereIL1 { get; set; } = null!;
        public ampereIL3Object ampereIL3 { get; set; } = null!;
        public voltUL1Object voltUL1 { get; set; } = null!;
        [Required]
        public voltUL2Object voltUL2 { get; set; } = null!;
        [Required]
        public voltUL3Object voltUL3 { get; set; } = null!;
    }
    public class activePowerQ1Q4Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public double activePowerQ1Q4 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class activePowerQ2Q3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public double activePowerQ2Q3 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class reactivePowerQ1Q2Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public double reactivePowerQ1Q2 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class reactivePowerQ3Q4Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public double reactivePowerQ3Q4 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class ampereIL1Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public double ampereIL1 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class ampereIL3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public double ampereIL3 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class voltUL1Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public int voltUL1 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }

    public class voltUL2Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public int voltUL2 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
    public class voltUL3Object
    {
        [Key]
        [Required]
        public Guid Id { get; set; } = new Guid();
        [Required]
        public int voltUL3 { get; set; }
        [Required]
        public string UoM { get; set; } = string.Empty;
    }
}
