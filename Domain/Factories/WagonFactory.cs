using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;
using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

namespace Domain.Factories;

public static class WagonFactory{
    public static Wagon UzbrojonaCysterna() => new(){
        Code = "UZBROJONA CYSTERNA",
        Image = "cards/Wagon1.png",
        Price = 12000,
        Slots = new List<ASlot>{
            new FuelSlot(),
            new FuelSlot(),
            new WeaponSlot{
                Cargo = CargoFactory.GreenWeapon2(),
                IsConstant = true,
                OrderId = 1
            },
            new ArmorSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 2
            }
        }
    };

    public static Wagon OpancerzonaPrzyczepa() => new(){
        Code = "OPANCERZONA PRZYCZEPA",
        Image = "cards/Wagon2.png",
        Price = 7000,
        Slots = new List<ASlot>{
            new StandardSlot{OrderId = 1},
            new StandardSlot{OrderId = 2},
            new StandardSlot{OrderId = 3},
            new ArmorSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 4
            }
        }
    };

    public static Wagon Przyczepa() => new(){
        Code = "PRZYCZEPA",
        Image = "cards/Wagon3.png",
        Price = 5000,
        Slots = new List<ASlot>{
            new StandardSlot{OrderId = 1},
            new StandardSlot{OrderId = 2},
            new StandardSlot{OrderId = 3}
        }
    };

    public static Wagon PrzyczepaSanitarna() => new(){
        Code = "PRZYCZEPA SANITARNA",
        Image = "cards/Wagon4.png",
        Price = 15000,
        Slots = new List<ASlot>{
            new CrewSlot{OrderId = 1},
            new CrewSlot{OrderId = 2},
            new FuelSlot(){OrderId = 3},
            new StandardSlot{
                Cargo = CargoFactory.NoAtomPlusAtom(),
                OrderId = 1
            }
        }
    };

    public static Wagon OpancerzonaCysterna() => new(){
        Code = "OPANCERZONA CYSTERNA",
        Image = "cards/Wagon5.png",
        Price = 10000,
        Slots = new List<ASlot>{
            new FuelSlot(){OrderId = 1},
            new FuelSlot(){OrderId = 2},
            new FuelSlot(){OrderId = 3},
            new ArmorSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 4
            }
        }
    };
}