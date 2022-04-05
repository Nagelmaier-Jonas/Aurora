using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Model.Entities.Logic;

namespace Model.Entities.Database;

[Table("TRUCKS")]
public class Truck : AUpgradableElement {
    
    public List<Wagon> Wagons { get; set; }

    public void AddWagon(Wagon wagon) {
        Wagons.Add(wagon);
        wagon.Truck = this;
    }

    public Logic.Truck ToDto() {
        
        var truck = new ConvoyElementHandler().
    }
}