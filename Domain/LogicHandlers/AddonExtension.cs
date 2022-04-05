using Domain.LogicHandlers.Exceptions;
using Model.Entities.Database;

namespace Domain.LogicHandlers; 

public static class AdapterExtension {
    public static void AddAddon(this AUpgradableElement upgradable, Addon addon) {
        if (IsAddonPresent(upgradable))
            throw new AddonException("Addon space occupied!");
        upgradable.Addon = addon;
    }

    public static void RemoveAddon(this Adapter adapter) {
        if (IsAddonPresent(adapter))
            adapter.Addon = null;
        else
            throw new AddonException("No addon to remove!");
    }
    public static bool IsAddonPresent(this Adapter adapter) => adapter.Addon != null;
}