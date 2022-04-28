using Domain.Factories;
using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;

namespace Domain;

public static class AllEntities
{
    static AllEntities(){
    }

    public static List<Truck> Trucks()
    {
        return new()
        {
            TruckFactory.CzolgTesli(),
            TruckFactory.TurboCiezarowka(),
            TruckFactory.Apc(),
            TruckFactory.CzolgImpulsowy(),
            TruckFactory.Ciezarowka(),
            TruckFactory.NuklearnaCiezarowka()
        };
    }

    public static List<Wagon> Wagons()
    {
        return new()
        {
            WagonFactory.UzbrojonaCysterna(),
            WagonFactory.OpancerzonaPrzyczepa(),
            WagonFactory.Przyczepa(),
            WagonFactory.PrzyczepaSanitarna(),
            WagonFactory.OpancerzonaCysterna()
        };
    }

    public static List<Addon> Addons()
    {
        return new()
        {
            AddonFactory.KarabinMaszynowy(),
            AddonFactory.MalyBagaznik(),
            AddonFactory.Dzialo(),
            AddonFactory.Pancerz(),
            AddonFactory.DuzyBagaznik(),
            AddonFactory.CiezkiPancerz(),
            AddonFactory.PrzetwarzaczBiomasy(),
            AddonFactory.OpancerzonyBagaznik(),
            AddonFactory.MikroreaktorNuklearny(),
            AddonFactory.DronyNaprawcze(),
            AddonFactory.Zuraw(),
            AddonFactory.TurboKobziarz()
        };
    }

    
    
    public static List<StandardCargo> BuyableCargoStandard(){
        return new(){
            CargoFactory.Granat(),
            CargoFactory.MobilnyZagluszacz(),
            CargoFactory.RacjaZywnosciowa(),
            CargoFactory.LekPrzeciwOdmrozeniom(),
            CargoFactory.Mina(),
            CargoFactory.KombinezonOchronny(),
            CargoFactory.PociskiZapalajace(),
        };
    }
    public static List<FuelCargo> BuyableCargoFuel(){
        return new(){
            CargoFactory.KroplowkaOdkazajacaIV(),
            CargoFactory.Nitrometan(),
            CargoFactory.PalnikSpawalniczy(),
            CargoFactory.PodtlenekAzotu()
        };
    }
    public static List<CrewCargo> BuyableCargoCrew(){
        return new(){
            CargoFactory.Kierowca(),
            CargoFactory.Android(),
            CargoFactory.Pustelnik(),
            CargoFactory.LowcaNagrod(),
            CargoFactory.Strzelec()
        };
    }
    public static List<ACargo> BuyableCargo(){
        List<ACargo> list = new();
        
        list.AddRange(BuyableCargoStandard());
        list.AddRange(BuyableCargoFuel());
        list.AddRange(BuyableCargoCrew());

        return list;
    }
    public static List<ACargo> FixedCargo(){
        return new(){
            CargoFactory.Armor(),
            CargoFactory.Nuclear(),
            CargoFactory.BonusStar1(),
            CargoFactory.ChainDrive(),
            CargoFactory.FuelGenerator(),
            CargoFactory.GreenWeapon2(),
            CargoFactory.GreenWeapon3(),
            CargoFactory.GreenWeapon4(),
            CargoFactory.RedWeapon1(),
            CargoFactory.RedWeapon2(),
            CargoFactory.RedWeapon3(),
            CargoFactory.RedWeapon4(),
            CargoFactory.FuelPlusSpeed(),
            CargoFactory.GrabberNoAtom(),
            CargoFactory.RepairNoAtom(),
            CargoFactory.StarNoAtom(),
            CargoFactory.NoAtomPlusAtom(),
            CargoFactory.NoNuclearPlusSpeed()
        };
    }
}