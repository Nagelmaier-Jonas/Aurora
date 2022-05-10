using Model.Entities.Cargo.Implementation;

namespace Domain.Builder; 

public class FuelCargoBuilder : ACargoBuilder<FuelCargo, FuelCargoBuilder> {
    public FuelCargoBuilder(FuelCargo element) : base(element) {
    }

    public static FuelCargoBuilder Init() => new FuelCargoBuilder(new FuelCargo());
}