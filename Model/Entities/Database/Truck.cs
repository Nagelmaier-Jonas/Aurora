using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities.Database;

[Table("TRUCKS")]
public class Truck : AUpgradableElement {
    public List<Wagon> Wagons { get; set; }
    
    [Column("CAPACITY"), Required]
    public int Capacity { get; set; }

    public void AddWagon(Wagon wagon) {
        Wagons.Add(wagon);
        wagon.Truck = this;
    }
}