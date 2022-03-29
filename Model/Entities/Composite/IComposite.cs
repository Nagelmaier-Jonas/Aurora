using System.ComponentModel;

namespace Model.Entities.Composite; 

public interface IComposite {
    void Operation();
    void Add(IComposite composite);
    void Remove(IComposite composite);
    IComposite GetChild(int index);
}