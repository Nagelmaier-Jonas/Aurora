using System.Linq.Expressions;

namespace Model.Entities.OwnPattern; 

public class CrewSlot : ACargo {
    public override void TestAdd(Expression<Func<IBaseItem, bool>> expression) {
        throw new NotImplementedException();
    }
}