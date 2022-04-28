using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;
using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

namespace Domain.Factories;

public static class AddonFactory{
    public static Addon KarabinMaszynowy() => new(){
        Code = "KARABIN MASZYNOWY",
        Image = "cards/Addon1.png",
        Price = 15000,
        Slots = new List<ASlot>{
            new WeaponSlot{
                Cargo = CargoFactory.RedWeapon2(),
                IsConstant = true,
                OrderId = 1
            },
            new CrewSlot{OrderId = 2}
        }
    };

    public static Addon MalyBagaznik() => new(){
        Code = "MALY BAGAZNIK",
        Image = "cards/Addon3.png",
        Price = 1000,
        Slots = new List<ASlot>{
            new StandardSlot{OrderId = 1},
            new StandardSlot{OrderId = 2}
        }
    };

    public static Addon Dzialo() => new(){
        Code = "DZIALO",
        Image = "cards/Addon7.png",
        Price = 35000,
        Slots = new List<ASlot>{
            new WeaponSlot{
                Cargo = CargoFactory.RedWeapon4(),
                IsConstant = true,
                OrderId = 1
            }
        }
    };

    public static Addon Pancerz() => new(){
        Code = "PANCERZ",
        Image = "cards/Addon8.png",
        Price = 2000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 1
            },
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 2
            },
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 3
            }
        }
    };

    public static Addon DuzyBagaznik() => new(){
        Code = "DUZY BAGAZNIK",
        Image = "cards/Addon9.png",
        Price = 3000,
        Slots = new List<ASlot>{
            new StandardSlot{OrderId = 1},
            new StandardSlot{OrderId = 2},
            new ArmorSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 3
            }
        }
    };

    public static Addon CiezkiPancerz() => new(){
        Code = "CIEZKI PANCERZ",
        Image = "cards/Addon11.png",
        Price = 5000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 1
            },
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 2
            },
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 3
            },
            new StandardSlot{
                Cargo = CargoFactory.Armor(),
                IsConstant = true,
                OrderId = 4
            }
        }
    };

    public static Addon PrzetwarzaczBiomasy() => new(){
        Code = "PRZETWARZACZ BIOMASY",
        Image = "cards/Addon12.png",
        Price = 25000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.FuelGenerator(),
                IsConstant = true,
                OrderId = 1
            }
        }
    };

    public static Addon OpancerzonyBagaznik() => new(){
        Code = "OPANCERZONY BAGAZNIK",
        Image = "cards/Addon13.png",
        Price = 3000,
        Slots = new List<ASlot>{
            new StandardSlot{OrderId = 1},
            new StandardSlot{OrderId = 2},
            new StandardSlot{
                Cargo = CargoFactory.BonusStar1(),
                OrderId = 3
            }
        }
    };

    public static Addon MikroreaktorNuklearny() => new(){
        Code = "MIKROREAKTOR NUKLEARNY",
        Image = "cards/Addon15.png",
        Price = 25000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.Nuclear(),
                IsConstant = true,
                OrderId = 1
            },
            new StandardSlot{OrderId = 2}
        }
    };

    public static Addon DronyNaprawcze() => new(){
        Code = "DRONY NAPRAWCZE",
        Image = "cards/Addon16.png",
        Price = 15000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.RepairNoAtom(),
                OrderId = 1
            },
            new ArmorSlot{
                Cargo = CargoFactory.Armor(),
                OrderId = 2
            },
        }
    };

    public static Addon Zuraw() => new(){
        Code = "ZURAW",
        Image = "cards/Addon17.png",
        Price = 20000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.GrabberNoAtom(),
                IsConstant = true,
                OrderId = 1
            },
            new CrewSlot{OrderId = 2},
            new StandardSlot{OrderId = 3}
        }
    };

    public static Addon TurboKobziarz() => new(){
        Code = "TURBO KOBZIARZ",
        Image = "cards/Addon18.png",
        Price = 7000,
        Slots = new List<ASlot>{
            new StandardSlot{
                Cargo = CargoFactory.StarNoAtom(),
                IsConstant = true,
                OrderId = 1
            },
            new StandardSlot{OrderId = 2},
            new StandardSlot{OrderId = 3}
        }
    };
}