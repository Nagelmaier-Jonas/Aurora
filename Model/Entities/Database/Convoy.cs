using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database; 

public class Convoy {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column]
    public int Id { get; set; }
    
    [Column, Required]
    public string ConvoyName { get; set; }

    [Column]
    public int UserId { get; set; }
    
    public List<Truck> Trucks { get; set; }
}