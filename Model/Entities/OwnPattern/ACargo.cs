using System.Linq.Expressions;
using MudBlazor;

namespace Model.Entities.OwnPattern;

public abstract class ACargo {
    private List<EKeyWords> _keyWords;
    private IBaseItem _item;
    private bool _isDamaged;
    public abstract void TestAdd(Expression<Func<IBaseItem,bool>> expression);
}