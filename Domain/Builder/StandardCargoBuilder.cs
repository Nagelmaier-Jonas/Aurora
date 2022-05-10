using Model.Entities.Cargo.Implementation;

namespace Domain.Builder; 

public class StandardCargoBuilder : ACargoBuilder<StandardCargo, StandardCargoBuilder> {
    public StandardCargoBuilder(StandardCargo element) : base(element) {
    }

    public static StandardCargoBuilder Init() => new StandardCargoBuilder(new StandardCargo());
    
}