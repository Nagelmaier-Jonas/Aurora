using Model.Entities.Cargo.Implementation;

namespace Domain.Builder; 

public class CrewCargoBuilder : ACargoBuilder<CrewCargo, CrewCargoBuilder> {


    public CrewCargoBuilder(CrewCargo element) : base(element) {
    }

    public static CrewCargoBuilder Init() => new CrewCargoBuilder(new CrewCargo());
}