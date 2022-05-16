using Model.Entities.Cargo.Implementation;

namespace Domain.Builder; 

public class WeaponCargoBuilder : ACargoBuilder<WeaponCargo, WeaponCargoBuilder> {
    public WeaponCargoBuilder(WeaponCargo element) : base(element) {
    }

    public static WeaponCargoBuilder Init() => new WeaponCargoBuilder(new WeaponCargo());
}