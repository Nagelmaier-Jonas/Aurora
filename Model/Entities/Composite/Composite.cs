using System.ComponentModel;

namespace Model.Entities.Composite; 

public class Composite : IComposite {
    private readonly List<IComposite> _composites = new List<IComposite>();
    
    public void Operation() {
        throw new NotImplementedException();
    }

    public void Add(IComposite composite) {
        _composites.Add(composite);
    }

    public void Remove(IComposite composite) {
        _composites.Remove(composite);
    }

    public IComposite GetChild(int index) {
        return _composites[index];
    }
}