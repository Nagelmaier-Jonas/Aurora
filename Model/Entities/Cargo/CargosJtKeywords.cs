using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Cargo;

[Table("CARGO_JT_KEYWORDS")]
public class CargosJtKeywords{

    [Column("KEYWORD_ID")]
    public int KeywordId{ get; set; }

    public Keyword Keyword{ get; set; }
    
    [Column("CARGO_ID")]
    public int CargoId{ get; set; }

    public ACargo Cargo{ get; set; }
    
}