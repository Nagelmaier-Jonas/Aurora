using Domain.LogicHandlers.Exceptions;
using Model.Entities;

namespace Domain.LogicHandlers; 

public static class AddonExtension {
    public static void AddAddon(this AUpgradableElement upgradable, Addon addon) {
        if (IsAddonPresent(upgradable))
            throw new AddonException("Addon space occupied!");
        upgradable.Addon = addon;
    }

    public static void RemoveAddon(this AUpgradableElement adapter) {
        if (IsAddonPresent(adapter))
            adapter.Addon = null;
        else
            throw new AddonException("No addon to remove!");
    }
    public static bool IsAddonPresent(this AUpgradableElement adapter) => adapter.Addon != null;
}