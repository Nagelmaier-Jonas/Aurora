using Model.Entities.Slots;

namespace Domain.LogicHandlers.Helper;

public class ConvoyRerenderer{
    
    public int ActivePanelIndex;

    public event Action? Rerender;
    
    public event Action? ChangeActivePanel;
    
    public ASlot TempSlot;

    public void SetPanelIndex(int index){
        ActivePanelIndex = index;
        Rerender?.Invoke();
        ChangeActivePanel?.Invoke();
    }

    public void Update(){
        Rerender?.Invoke();
    }
}