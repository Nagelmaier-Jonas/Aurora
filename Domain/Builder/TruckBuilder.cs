using Model.Entities;

namespace Domain.Builder;

public class TruckBuilder : AUpgradableElementBuilder<Truck, TruckBuilder>{
    private Truck _truck;

    private TruckBuilder(Truck element) : base(element){
        _truck = element;
    }

    public static TruckBuilder Init() => new TruckBuilder(new Truck());

    public TruckBuilder SetSpeed(int speed){
        _truck.Speed = speed;
        return this;
    }

    public TruckBuilder SetPullForce(int pullForce){
        _truck.PullForce = pullForce;
        return this;
    }
}