using System.ComponentModel.DataAnnotations.Schema;
using Model.Entities.Items;

namespace Model.Entities.Slots;

[Table("CHEMICAL_LIQUID_SLOTS")]
public class ChemicalLiquidSlot : ASlot{
    [Column("CHEMICAL_LIQUID_ID")]
    public int ChemicalLiquidId{ get; set; }
    
    public ChemicalLiquid ChemicalLiquid{ get; set; }
}