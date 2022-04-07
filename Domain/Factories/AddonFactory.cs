using Model.Entities;
using Model.Enums;

namespace Model.Factories;

public static class AddonFactory{
    
    public static Addon Create(EAddonType type){
        return type switch{
            EAddonType.MACHINE_GUN => CreateMachineGun(),
            EAddonType.VULCAN_GUN => CreateVulcanGun(),
            EAddonType.SMALL_STORAGE => CreateSmallStorage(),
            EAddonType.NUCLEAR_REACTOR => CreateNuclearReactor(),
            EAddonType.HEAVY_GUN => CreateHeavyGun(),
            EAddonType.ARMOR => CreateArmor(),
            EAddonType.LARGE_STORAGE => CreateLargeStorage(),
            EAddonType.GREENHOUSE => CreateGreenhouse(),
            EAddonType.HEAVY_ARMOR => CreateHeavyArmor(),
            EAddonType.BIO_FUEL_GENERATOR => CreateBioFuelGenerator(),
            EAddonType.HEAVY_LARGE_STORAGE => CreateHeavyLargeStorage(),
            EAddonType.GAUSSA_GUN => CreateGaussaGun(),
            EAddonType.SMALL_NUCLEAR_REACTOR => CreateSmallNuclearReactor(),
            EAddonType.MAINTENANCE_DRONE => CreateMaintenanceDrone(),
            EAddonType.ZURAW => CreateZuraw(),
            EAddonType.TURBO_BAGPIPER => CreateTurboBagpiper()
        };
    }
    
    private static Addon CreateMachineGun() => new Addon(){
        Code = "Machine Gun",
        Price = 10,
        Image = "cards/add1.png"
    };
    
    private static Addon CreateVulcanGun() => new Addon{
        Code = "Vulcan Gun",
        Price = 10,
        Image = "cards/add2.png"
    };

    private static Addon CreateSmallStorage() => new Addon{
        Code = "Small Storage",
        Price = 10,
        Image = "cards/add3.png"
    };

    private static Addon CreateNuclearReactor() => new Addon{
        Code = "Nuclear Reactor",
        Price = 10,
        Image = "cards/add4.png"
    };

    private static Addon CreateHeavyGun() => new Addon{
        Code = "Heavy Gun",
        Price = 10,
        Image = "cards/add7.png"
    };

    private static Addon CreateArmor() => new Addon{
        Code = "Armor",
        Price = 10,
        Image = "cards/add8.png"
    };

    private static Addon CreateLargeStorage() => new Addon{
        Code = "Large Storage",
        Price = 10,
        Image = "cards/add9.png"
    };

    private static Addon CreateGreenhouse() => new Addon{
        Code = "Greenhouse",
        Price = 10,
        Image = "cards/add10.png"
    };

    private static Addon CreateHeavyArmor() => new Addon{
        Code = "Heavy Armor",
        Price = 10,
        Image = "cards/add11.png"
    };

    private static Addon CreateBioFuelGenerator() => new Addon{
        Code = "Bio Fuel Generator",
        Price = 10,
        Image = "cards/add12.png"
    };

    private static Addon CreateHeavyLargeStorage() => new Addon{
        Code = "Heavy Large Storage",
        Price = 10,
        Image = "cards/add13.png"
    };

    private static Addon CreateGaussaGun() => new Addon{
        Code = "Gaussa Gun",
        Price = 10,
        Image = "cards/add14.png"
    };

    private static Addon CreateSmallNuclearReactor() => new Addon{
        Code = "Small Nuclear Reactor",
        Price = 10,
        Image = "cards/add15.png"
    };

    private static Addon CreateMaintenanceDrone() => new Addon{
        Code = "Maintenance Drone",
        Price = 10,
        Image = "cards/add16.png"
    };

    private static Addon CreateZuraw() => new Addon{
        Code = "Zuraw",
        Price = 10,
        Image = "cards/add17.png"
    };

    private static Addon CreateTurboBagpiper() => new Addon{
        Code = "Turbo Bagpiper",
        Price = 10,
        Image = "cards/add18.png"
    };
}
