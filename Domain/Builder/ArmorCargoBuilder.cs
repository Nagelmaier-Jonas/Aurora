using Model.Entities.Cargo.Implementation;

namespace Domain.Builder; 

public class ArmorCargoBuilder : ACargoBuilder<ArmorCargo, ArmorCargoBuilder> {
    public ArmorCargoBuilder(ArmorCargo element) : base(element) {
    }

    public static ArmorCargoBuilder Init() => new ArmorCargoBuilder(new ArmorCargo());
}