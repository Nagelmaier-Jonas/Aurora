using Model.Entities;

namespace Domain.Builder;

public class WagonBuilder : AUpgradableElementBuilder<Wagon, WagonBuilder>{
    private Wagon _wagon;

    private WagonBuilder(Wagon element) : base(element){
        _wagon = element;
    }

    public static WagonBuilder Init() => new WagonBuilder(new Wagon());

    public WagonBuilder SetTruck(Truck truck){
        _wagon.Truck = truck;
        return this;
    }
}