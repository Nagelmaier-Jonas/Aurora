using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Items;

[Table("CARGO")]
public class Cargo : AItem{
    [Column("BUY_PRICE")]
    public int BuyPrice{ get; set; }
    
    [Column("SELL_PRICE")]
    public int SellPrice{ get; set; }
}