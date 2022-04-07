using Model.Entities;
using Model.Enums;
using Model.Factories;

namespace Aurora.Pages;

class AllEntities
{
    public static List<Truck> Trucks() => new(){
        TruckFactory.Create(ETruckType.HEAVY_TESLA_TANK),
        TruckFactory.Create(ETruckType.TURBO_TRUCK_WITH_BIO_FUEL),
        TruckFactory.Create(ETruckType.APC),
        TruckFactory.Create(ETruckType.RAILGUN_TRUCK),
        TruckFactory.Create(ETruckType.TRUCK),
        TruckFactory.Create(ETruckType.ATOM_TRUCK)
    };

    public static List<Wagon> Wagons() => new(){
        WagonFactory.Create(EWagonType.REINFORCED_FUEL_WAGON),
        WagonFactory.Create(EWagonType.REINFORCED_WAGON),
        WagonFactory.Create(EWagonType.WAGON),
        WagonFactory.Create(EWagonType.MEDICAL_WAGON),
        WagonFactory.Create(EWagonType.DOUBLE_REINFORCED_FUEL_WAGON)
    };

    public static List<Addon> Addons() => new(){
        AddonFactory.Create(EAddonType.MACHINE_GUN),
        AddonFactory.Create(EAddonType.VULCAN_GUN),
        AddonFactory.Create(EAddonType.SMALL_STORAGE),
        AddonFactory.Create(EAddonType.NUCLEAR_REACTOR),
        AddonFactory.Create(EAddonType.HEAVY_GUN),
        AddonFactory.Create(EAddonType.ARMOR),
        AddonFactory.Create(EAddonType.LARGE_STORAGE),
        AddonFactory.Create(EAddonType.GREENHOUSE),
        AddonFactory.Create(EAddonType.HEAVY_ARMOR),
        AddonFactory.Create(EAddonType.BIO_FUEL_GENERATOR),
        AddonFactory.Create(EAddonType.HEAVY_LARGE_STORAGE),
        AddonFactory.Create(EAddonType.GAUSSA_GUN),
        AddonFactory.Create(EAddonType.SMALL_NUCLEAR_REACTOR),
        AddonFactory.Create(EAddonType.MAINTENANCE_DRONE),
        AddonFactory.Create(EAddonType.ZURAW),
        AddonFactory.Create(EAddonType.TURBO_BAGPIPER)
    };
}