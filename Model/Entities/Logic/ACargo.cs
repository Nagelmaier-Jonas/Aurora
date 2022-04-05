using System.Linq.Expressions;

namespace Model.Entities.Logic;

public abstract class ACargo {
    public List<EKeyWords> KeyWords{ get; }
    public IBaseItem Item{ get; }
    public bool IsDamaged{ get; }
    public abstract void TestAdd(Expression<Func<IBaseItem,bool>> expression);
}