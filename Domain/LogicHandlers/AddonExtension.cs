using Domain.LogicHandlers.Exceptions;
using Model.Entities;

namespace Domain.LogicHandlers;

public static class AddonExtension
{
    public static void AddAddon(this AUpgradeable upgradable, Addon addon, Session session){
        if (session.CanBuy(addon.Price)){
            session.Money -= addon.Price;
        }
        else{
            throw new AddonException("Not enough Money!");
        }
        
        if (IsAddonPresent(upgradable))
            throw new AddonException("Addon space occupied!");
        upgradable.Addon = addon;
    }

    public static void RemoveAddon(this AUpgradeable adapter, Session session){
        if (IsAddonPresent(adapter)){
            session.Money += adapter.Addon.Price;
            adapter.Addon = null;
        }
        else
            throw new AddonException("No addon to remove!");
    }

    public static bool IsAddonPresent(this AUpgradeable adapter)
    {
        return adapter.Addon != null;
    }
}