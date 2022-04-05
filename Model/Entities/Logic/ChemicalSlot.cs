using System.Linq.Expressions;

namespace Model.Entities.Logic; 

public class ChemicalSlot : ACargo {
    public override void TestAdd(Expression<Func<IBaseItem, bool>> expression) {
        throw new NotImplementedException();
    }
}