using Model.Entities;

namespace Domain.Builder;

public class AddonBuilder : AConvoyElementBuilder<Addon, AddonBuilder>{
    public AddonBuilder(Addon element) : base(element){
    }

    public static AddonBuilder Init() => new AddonBuilder(new Addon());


    public static AddonBuilder InitDefault() => new AddonBuilder(new Addon()).SetPrice(10);
}