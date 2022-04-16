using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("CONVOY_ELEMENT_HAS_KEYWORDS_JT")]
public class ConvoyElementHasKeywords{
    
    [Column("ELEMENT_ID")]
    public int ElementId{ get; set; }
    
    public AConvoyElement Element{ get; set; }
    
    [Column("KEYWORD_ID")]
    public int KeywordId{ get; set; }
    
    public Keyword Keyword{ get; set; }
}