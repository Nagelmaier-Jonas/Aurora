using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Slots;

namespace Model.Entities.Cargo;

[Table("CARGO_ST")]
public abstract class ACargo : ICargo{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("CARGO_ID")]
    public int Id{ get; set; }

    [Column("PRICE")]
    public int Price{ get; set; }
    
    [Column("VITALITY")]
    public int Vitality{ get; set; }
    
    [Column("IMAGE")]
    public string Image{ get; set; }
    
    [Column("NAME")]
    public string Name{ get; set; }
    
    public List<CargosJtKeywords> Keywords{ get; set; }

    public abstract bool IsAddable(CrewSlot crewSlot);

    public abstract bool IsAddable(FuelSlot fuelSlot);
}