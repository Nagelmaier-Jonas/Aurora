using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database; 

[Table("ADDONS")]
public class Addon : Vehicle{
    [Column, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int AddonId { get; set; }    
}