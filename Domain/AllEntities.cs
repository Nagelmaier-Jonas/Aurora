using Model.Entities;
using Model.Enums;
using Model.Factories;

namespace Domain;

public static class AllEntities
{
    public static List<Truck> Trucks()
    {
        return new()
        {
            TruckFactory.CreateHeavyTeslaTank(),
            TruckFactory.CreateTurboTruckWithBiofuel(),
            TruckFactory.CreateApc(),
            TruckFactory.CreateRailgunTruck(),
            TruckFactory.CreateAtomTruck(),
            TruckFactory.CreateTruck()
        };
    }

    public static List<Wagon> Wagons()
    {
        return new()
        {
            WagonFactory.CreateReinforcedWagon(),
            WagonFactory.CreateReinforcedFuelWagon(),
            WagonFactory.CreateWagon(),
            WagonFactory.CreateMedicalWagon(),
            WagonFactory.CreateDoubleReinforcedFuelWagon()
        };
    }

    public static List<Addon> Addons()
    {
        return new()
        {
            AddonFactory.CreateMachineGun(),
            AddonFactory.CreateVulcanGun(),
            AddonFactory.CreateSmallStorage(),
            AddonFactory.CreateNuclearReactor(),
            AddonFactory.CreateSmallNuclearReactor(),
            AddonFactory.CreateArmor(),
            AddonFactory.CreateLargeStorage(),
            AddonFactory.CreateGreenhouse(),
            AddonFactory.CreateHeavyArmor(),
            AddonFactory.CreateBioFuelGenerator(),
            AddonFactory.CreateHeavyLargeStorage(),
            AddonFactory.CreateGaussaGun(),
            AddonFactory.CreateZuraw(),
            AddonFactory.CreateMaintenanceDrone(),
            AddonFactory.CreateTurboBagpiper()
        };
    }
}