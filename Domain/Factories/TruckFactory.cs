using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;
using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

namespace Domain.Factories;

public static class TruckFactory{
    public static Truck CzolgTesli() => new(){
        Code = "CZOLG TESLI",
        Image = "cards/Truck1.png",
        Price = 100000,
        Speed = 3,
        PullForce = 3,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.ChainDrive(),
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot{
                Cargo = CargoFactory.GreenWeapon3(),
                OrderId = 2
            },
            new CrewSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck TurboCiezarowka() => new(){
        Code = "TURBO CIEZAROWKA NA BIO-PALIWO",
        Image = "cards/Truck2.png",
        Price = 80000,
        Speed = 4,
        PullForce = 3,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.FuelPlusSpeed(),
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot{
                Cargo = CargoFactory.RedWeapon3(),
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck Apc() => new(){
        Code = "APC",
        Image = "cards/Truck3.png",
        Price = 60000,
        Speed = 2,
        PullForce = 3,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.ChainDrive(),
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot{
                Cargo = CargoFactory.GreenWeapon2(),
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck CzolgImpulsowy() => new(){
        Code = "CZOLG IMPULSOWY",
        Image = "cards/Truck4.png",
        Price = 140000,
        Speed = 4,
        PullForce = 3,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.ChainDrive(),
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot{
                Cargo = CargoFactory.GreenWeapon4(),
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck Ciezarowka() => new(){
        Code = "CIEZAROWKA",
        Image = "cards/Truck5.png",
        Price = 40000,
        Speed = 2,
        PullForce = 2,
        Slots = new List<ASlot>{
            new WeaponSlot{
                Cargo = CargoFactory.RedWeapon1(),
                IsConstant = true,
                OrderId = 1
            },
            new CrewSlot{OrderId = 2},
            new StandardSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck NuklearnaCiezarowka() => new(){
        Code = "NUKLEARNA CIEZAROWKA",
        Image = "cards/Truck6.png",
        Price = 100000,
        Speed = 4,
        PullForce = 3,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.NoNuclearPlusSpeed(),
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot{
                Cargo = CargoFactory.GreenWeapon3(),
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };
}