using Model.Entities;

namespace Domain.Factories;

public static class AddonFactory
{
    public static Addon CreateMachineGun()
    {
        return new()
        {
            Code = "Machine Gun",
            Price = 10,
            Image = "cards/add1.png"
        };
    }

    public static Addon CreateVulcanGun()
    {
        return new()
        {
            Code = "Vulcan Gun",
            Price = 10,
            Image = "cards/add2.png"
        };
    }

    public static Addon CreateSmallStorage()
    {
        return new()
        {
            Code = "Small Storage",
            Price = 10,
            Image = "cards/add3.png"
        };
    }

    public static Addon CreateNuclearReactor()
    {
        return new()
        {
            Code = "Nuclear Reactor",
            Price = 10,
            Image = "cards/add4.png"
        };
    }

    public static Addon CreateHeavyGun()
    {
        return new()
        {
            Code = "Heavy Gun",
            Price = 10,
            Image = "cards/add7.png"
        };
    }

    public static Addon CreateArmor()
    {
        return new()
        {
            Code = "Armor",
            Price = 10,
            Image = "cards/add8.png"
        };
    }

    public static Addon CreateLargeStorage()
    {
        return new()
        {
            Code = "Large Storage",
            Price = 10,
            Image = "cards/add9.png"
        };
    }

    public static Addon CreateGreenhouse()
    {
        return new()
        {
            Code = "Greenhouse",
            Price = 10,
            Image = "cards/add10.png"
        };
    }

    public static Addon CreateHeavyArmor()
    {
        return new()
        {
            Code = "Heavy Armor",
            Price = 10,
            Image = "cards/add11.png"
        };
    }

    public static Addon CreateBioFuelGenerator()
    {
        return new()
        {
            Code = "Bio Fuel Generator",
            Price = 10,
            Image = "cards/add12.png"
        };
    }

    public static Addon CreateHeavyLargeStorage()
    {
        return new()
        {
            Code = "Heavy Large Storage",
            Price = 10,
            Image = "cards/add13.png"
        };
    }

    public static Addon CreateGaussaGun()
    {
        return new()
        {
            Code = "Gaussa Gun",
            Price = 10,
            Image = "cards/add14.png"
        };
    }

    public static Addon CreateSmallNuclearReactor()
    {
        return new()
        {
            Code = "Small Nuclear Reactor",
            Price = 10,
            Image = "cards/add15.png"
        };
    }

    public static Addon CreateMaintenanceDrone()
    {
        return new()
        {
            Code = "Maintenance Drone",
            Price = 10,
            Image = "cards/add16.png"
        };
    }

    public static Addon CreateZuraw()
    {
        return new()
        {
            Code = "Zuraw",
            Price = 10,
            Image = "cards/add17.png"
        };
    }

    public static Addon CreateTurboBagpiper()
    {
        return new()
        {
            Code = "Turbo Bagpiper",
            Price = 10,
            Image = "cards/add18.png"
        };
    }
}