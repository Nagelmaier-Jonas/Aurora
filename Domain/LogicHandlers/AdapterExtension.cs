using Domain.LogicHandlers.Exceptions;
using Model.Entities.OwnPattern;

namespace Domain.LogicHandlers; 

public static class AdapterExtension {
    public static void AddAddon(this Adapter adapter, Addon addon) {
        if (IsAddonPresent(adapter))
            throw new AddonException("Addon space occupied!");
        adapter.Addon = addon;
    }

    public static void RemoveAddon(this Adapter adapter) {
        if (IsAddonPresent(adapter))
            adapter.Addon = null;
        else
            throw new AddonException("No addon to remove!");
    }
    public static bool IsAddonPresent(this Adapter adapter) => adapter.Addon != null;
}