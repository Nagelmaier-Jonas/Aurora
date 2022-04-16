using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Items;

[Table("CHEMICAL_LIQUIDS")]
public class ChemicalLiquid : AItem{
    [Column("WOS_WAS_I")]
    public string KaAhnung{ get; set; }
}