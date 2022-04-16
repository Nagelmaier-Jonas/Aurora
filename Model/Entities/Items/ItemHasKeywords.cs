using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Items;

[Table("ITEM_HAS_KEYWORDS_JT")]
public class ItemHasKeywords{
    [Column("ITEM_ID")]
    public int ItemId{ get; set; }
    
    public AItem Item{ get; set; }
    
    [Column("KEYWORD_ID")]
    public int KeywordId{ get; set; }
    
    public Keyword Keyword{ get; set; }
}