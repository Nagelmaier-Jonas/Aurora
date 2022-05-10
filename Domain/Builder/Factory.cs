using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;

namespace Domain.Builder;

public static class Factory {
    // <summary>
    // All methods to create trucks
    // </summary>

    public static Truck CreateExampleTruck() => TruckBuilder.Init()
        .SetCode("ExampleTruck")
        .SetPrice(4)
        .SetSpeed(4)
        .SetPullForce(4)
        .SetImagePath("example")
        .Build();
    

    public static Truck CreateTeslaTank() => TruckBuilder.Init()
        .SetCode("Tesla Tank")
        .SetPrice(140000)
        .SetSpeed(3)
        .SetPullForce(3)
        .SetImagePath("tesla_front_tank")
        .AddDefaultSlot(CreateChainDriveItem()).IsFixedSlot()
        .AddDefaultSlot(CreateTeslaGunItem()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build(); 

    public static Truck CreateBiofuelTruck() => TruckBuilder.Init()
        .SetCode("Biofuel Truck")
        .SetPrice(80000)
        .SetSpeed(4)
        .SetPullForce(3)
        .SetImagePath("biofuel_powered_front_truck")
        .AddDefaultSlot(CreateBiofuelGeneratorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateGatlingGunItem()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build();

    public static Truck CreateApcTruck() => TruckBuilder.Init()
        .SetCode("APC Tank")
        .SetPrice(60000)
        .SetSpeed(2)
        .SetPullForce(3)
        .SetImagePath("apc_front_tank")
        .AddDefaultSlot(CreateChainDriveItem()).IsFixedSlot()
        .AddDefaultSlot(CreateHeavyOrdnance2Item()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build();

    public static Truck CreateRailgunTruck() => TruckBuilder.Init()
        .SetCode("Railgun Truck")
        .SetPrice(140000)
        .SetSpeed(4)
        .SetPullForce(3)
        .SetImagePath("railgun_tank_front_truck")
        .AddDefaultSlot(CreateChainDriveItem()).IsFixedSlot()
        .AddDefaultSlot(CreateRailGunItem()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build();

    public static Truck CreateTruck() => TruckBuilder.Init()
        .SetCode("Truck")
        .SetPrice(40000)
        .SetSpeed(2)
        .SetPullForce(2)
        .SetImagePath("truck_front")
        .AddDefaultSlot(CreateGunItem()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build();

    public static Truck CreateNuclearpoweredTruck() => TruckBuilder.Init()
        .SetCode("Nuclearpowered Truck")
        .SetPrice(100000)
        .SetSpeed(4)
        .SetPullForce(3)
        .SetImagePath("nuclear_powered_front_truck")
        .AddDefaultSlot(CreateNuclearGeneratorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateHeavyOrdnance3Item()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build();
    
    public static List<Truck> GetAllTrucks() => new(){
        CreateTruck(),
        CreateBiofuelTruck(),
        CreateNuclearpoweredTruck(),
        CreateApcTruck(),
        CreateRailgunTruck(),
        CreateTeslaTank(),
    };

    // <summary>
    // All methods to create wagons
    // </summary>
    public static Wagon CreateExampleWagon() => WagonBuilder.Init()
        .SetCode("Example")
        .SetPrice(10)
        .SetImagePath("example")
        .Build();

    public static Wagon CreateReinforcedWagon() => WagonBuilder.Init()
        .SetCode("Reinforced Wagon")
        .SetPrice(7000)
        .SetImagePath("reinforced_wagon")
        .AddDefaultSlot()
        .AddDefaultSlot()
        .AddDefaultSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Wagon CreateReinforcedFuelWagon() => WagonBuilder.Init()
        .SetCode("Reinforced Fuel Wagon")
        .SetPrice(10000)
        .SetImagePath("reinforced_fuel_wagon")
        .AddFuelSlot()
        .AddFuelSlot()
        .AddFuelSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Wagon CreateDoubleReinforcedFuelWagon() => WagonBuilder.Init()
        .SetCode("Double Reinforced Fuel Wagon")
        .SetPrice(12000)
        .SetImagePath("reinforced_fuel_wagon2")
        .AddFuelSlot()
        .AddFuelSlot()
        .AddDefaultSlot(CreateGun2Item()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Wagon CreateWagon() => WagonBuilder.Init()
        .SetCode("Wagon")
        .SetPrice(5000)
        .SetImagePath("wagon")
        .AddDefaultSlot()
        .AddDefaultSlot()
        .AddDefaultSlot()
        .Build();

    public static Wagon CreateMedicalWagon() => WagonBuilder.Init()
        .SetCode("Medical Wagon")
        .SetPrice(15000)
        .SetImagePath("medical_wagon")
        .AddDefaultSlot()
        .AddDefaultSlot()
        .AddFuelSlot()
        .AddDefaultSlot(CreateMedicalbayItem()).IsFixedSlot()
        .Build();
    
    public static List<Wagon> GetAllWagons() => new(){
        CreateWagon(),
        CreateReinforcedWagon(),
        CreateReinforcedFuelWagon(),
        CreateDoubleReinforcedFuelWagon(),
        CreateMedicalWagon()
    };

    // <summary>
    // All methods to create Addons
    // </summary>

    public static Addon CreateSmallStorage() => AddonBuilder.Init()
        .SetCode("Small Storage")
        .SetPrice(1000)
        .SetImagePath("smallstorage_addon")
        .AddDefaultSlot()
        .AddDefaultSlot()
        .Build();

    public static Addon CreateStorage() => AddonBuilder.Init()
        .SetCode("Storage")
        .SetPrice(3000)
        .SetImagePath("storage_addon")
        .AddDefaultSlot()
        .AddDefaultSlot()
        .AddDefaultSlot()
        .Build();

    public static Addon CreateNuclearReactor() => AddonBuilder.Init()
        .SetCode("Nuclearreactor")
        .SetPrice(25000)
        .SetImagePath("nuclearreactor_addon")
        .AddDefaultSlot(CreateNuclearReactorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateHeavyGun() => AddonBuilder.Init()
        .SetCode("Heavy Gun")
        .SetPrice(35000)
        .SetImagePath("heavygun_addon")
        .AddDefaultSlot(CreateHeavyOrdnance4Item()).IsFixedSlot()
        .Build();

    public static Addon CreateArmor() => AddonBuilder.Init()
        .SetCode("Armor")
        .SetPrice(2000)
        .SetImagePath("armor_addon")
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateHeavyArmor() => AddonBuilder.Init()
        .SetCode("Heavy Armor")
        .SetPrice(5000)
        .SetImagePath("heavyarmor_addon")
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateBioFuelGenerator() => AddonBuilder.Init()
        .SetCode("Bio Fuel Generator")
        .SetPrice(25000)
        .SetImagePath("biofuel_generator_addon")
        .AddDefaultSlot(CreateBiofuelGeneratorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateLargeStorage() => AddonBuilder.Init()
        .SetCode("Large Storage")
        .SetPrice(3000)
        .SetImagePath("largestorage_addon")
        .AddDefaultSlot()
        .AddDefaultSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateAutocannon() => AddonBuilder.Init()
        // Hits every enemy
        .SetCode("Autocannon")
        .SetPrice(15000)
        .SetImagePath("autocannon_addon")
        .AddDefaultSlot(CreateGatlingGun2Item()).IsFixedSlot()
        .AddCrewSlot()
        .Build();
        

    public static Addon CreateDrone() => AddonBuilder.Init()
        .SetCode("Drone")
        .SetPrice(10)
        .SetImagePath("drones_addon")
        .AddDefaultSlot(CreateDroneItem()).IsFixedSlot()
        .AddDefaultSlot(CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateZuraw() => AddonBuilder.Init()
        .SetCode("Crane")
        .SetPrice(20000)
        .SetImagePath("crane_addon")
        .AddDefaultSlot(CreateCraneItem()).IsFixedSlot()
        .AddCrewSlot()
        .AddDefaultSlot()
        .Build();

    public static Addon CreateBagpiper() => AddonBuilder.Init()
        .SetCode("Bagpiper")
        .SetPrice(7000)
        .SetImagePath("bagpiper_addon")
        .AddDefaultSlot(CreateBagpiperItem()).IsFixedSlot()
        .AddDefaultSlot()
        .AddDefaultSlot()
        .Build();
    
    public static List<Addon> GetAllAddons() => new(){
        CreateSmallStorage(),
        CreateStorage(),
        CreateArmor(),
        CreateHeavyArmor(),
        CreateBagpiper(),
        CreateBioFuelGenerator(),
        CreateZuraw(),
        CreateDrone(),
        CreateLargeStorage(),
        CreateNuclearReactor(),
        CreateAutocannon(),
        CreateHeavyGun(),
    };

    //<summary>
    // All methods to create fixed Cargo
    //</summary>
    
    public static StandardCargo CreateRacjaZywnosciowa() => StandardCargoBuilder.Init()
        .SetCode("Racja Zywnosciowa")
        .SetPrice(10)
        .SetImagePath("racajaZywnosciowa")
        .AddKeyword(EKeyword.MRE)
        .Build();

    public static StandardCargo CreateGranat() => StandardCargoBuilder.Init()
        .SetCode("Granat")
        .SetPrice(10)
        .SetImagePath("granat")
        .AddKeyword(EKeyword.Grenade)
        .Build();

    public static StandardCargo CreateKombinezonOchronyu() => StandardCargoBuilder.Init()
        .SetCode("Kombinezon Ochronyu")
        .SetPrice(10)
        .SetImagePath("kombinezon_ochronyu")
        .AddKeyword(EKeyword.ProtectionSuit)
        .Build();

    public static StandardCargo CreateKoplowkaOdkazajacaIV() => StandardCargoBuilder.Init()
        .SetCode("Koplowka OdkazajacaIV")
        .SetPrice(10)
        .SetImagePath("koplowkaOdkazajacaIV")
        .AddKeyword(EKeyword.DosingDrip4)
        .Build();

    public static StandardCargo CreateLekPrzeciwOdmrozeniom() => StandardCargoBuilder.Init()
        .SetCode("Lek Przeciw Odmrozeniom")
        .SetPrice(10)
        .SetImagePath("lek_przeciw_odmrozeniom")
        .AddKeyword(EKeyword.AntiFreeze)
        .Build();

    public static StandardCargo CreateMina() => StandardCargoBuilder.Init()
        .SetCode("Mina")
        .SetPrice(10)
        .SetImagePath("mina")
        .AddKeyword(EKeyword.Mine)
        .Build();

    public static StandardCargo CreateMobilnyZagluszacz() => StandardCargoBuilder.Init()
        .SetCode("Mobilny Zagluszacz")
        .SetPrice(10)
        .SetImagePath("mobilny_zagluszacz")
        .AddKeyword(EKeyword.MobileJammer)
        .Build();
    public static FuelCargo CreateNitrometan() => FuelCargoBuilder.Init()
        .SetCode("Nitrometan")
        .SetPrice(10)
        .SetImagePath("nitrometan")
        .AddKeyword(EKeyword.Nitromethane)
        .Build();

    public static StandardCargo CreatePalnikSpawalniczy() => StandardCargoBuilder.Init()
        .SetCode("Palnik Spawalniczy")
        .SetPrice(10)
        .SetImagePath("palnik_spawalniczy")
        .AddKeyword(EKeyword.WeldingTorch)
        .Build();

    public static StandardCargo CreatePociskiZapalajace() => StandardCargoBuilder.Init()
        .SetCode("Pociski Zapalajace")
        .SetPrice(10)
        .SetImagePath("pociskiZapalajace")
        .AddKeyword(EKeyword.Ammo)
        .Build();

    public static StandardCargo CreatePootlenekAzotu() => StandardCargoBuilder.Init()
        .SetCode("Pootlenek Azotu")
        .SetPrice(10)
        .SetImagePath("pootlenek_azotu")
        .AddKeyword(EKeyword.NitrousOxide)
        .Build();

    public static List<ACargo> GetAllFixedCargo() => new(){
        CreateRacjaZywnosciowa(),
        CreateGranat(),
        CreateKombinezonOchronyu(),
        CreateKoplowkaOdkazajacaIV(),
        CreateLekPrzeciwOdmrozeniom(),
        CreateMina(),
        CreateMobilnyZagluszacz(),
        CreateNitrometan(),
        CreatePalnikSpawalniczy(),
        CreatePociskiZapalajace(),
        CreatePootlenekAzotu()
    };

    //<summary>
    // All methods to create addable Cargo
    //</summary>

    public static StandardCargo CreateBiofuelGeneratorItem() => StandardCargoBuilder.Init()
        .SetCode("Biofuel Generator")
        .SetPrice(10)
        .SetImagePath("biofuel_generator2")
        .AddKeyword(EKeyword.Biofuelgenerator)
        .Build();

    public static StandardCargo CreateNuclearGeneratorItem() => StandardCargoBuilder.Init()
        .SetCode("Nuclear Generator")
        .SetPrice(10)
        .SetImagePath("nuclear_generator")
        .AddKeyword(EKeyword.Nucleargenerator)
        .Build();

    public static StandardCargo CreateNuclearReactorItem() => StandardCargoBuilder.Init()
        .SetCode("Nuclear Reactor")
        .SetPrice(10)
        .SetImagePath("radioactive")
        .AddKeyword(EKeyword.Nuclearreactor)
        .Build();

    public static StandardCargo CreateArmorItem() => StandardCargoBuilder.Init()
        .SetCode("Armor")
        .SetPrice(10)
        .SetImagePath("armor")
        .AddKeyword(EKeyword.Armor)
        .Build();

    public static StandardCargo CreateChainDriveItem() => StandardCargoBuilder.Init()
        .SetCode("Chaindrive")
        .SetPrice(10)
        .SetImagePath("chaindrive")
        .AddKeyword(EKeyword.Tracks)
        .Build();

    public static StandardCargo CreateBagpiperItem() => StandardCargoBuilder.Init()
        .SetCode("Bagpiper")
        .SetPrice(10)
        .SetImagePath("radioactive_star")
        .AddKeyword(EKeyword.Bagpiper)
        .Build();

    public static StandardCargo CreateCraneItem() => StandardCargoBuilder.Init()
        .SetCode("Crane")
        .SetPrice(10)
        .SetImagePath("radioactive_crane")
        .AddKeyword(EKeyword.Crane)
        .Build();

    public static StandardCargo CreateDroneItem() => StandardCargoBuilder.Init()
        .SetCode("Drone")
        .SetPrice(10)
        .SetImagePath("dronestation")
        .AddKeyword(EKeyword.Drone)
        .Build();

    public static StandardCargo CreateMedicalbayItem() => StandardCargoBuilder.Init()
        .SetCode("Medicalbay")
        .SetPrice(10)
        .SetImagePath("medical_bay")
        .AddKeyword(EKeyword.Medicalbay)
        .Build();

    public static StandardCargo CreateRailGunItem() => StandardCargoBuilder.Init()
        .SetCode("Rail Gun")
        .SetPrice(10)
        .SetImagePath("green_weapon4")
        .AddKeyword(EKeyword.Railgun)
        .Build();

    public static StandardCargo CreateTeslaGunItem() => StandardCargoBuilder.Init()
        .SetCode("Tesla Gun")
        .SetPrice(10)
        .SetImagePath("green_weapon3")
        .AddKeyword(EKeyword.Teslagun)
        .Build();

    public static StandardCargo CreateGunItem() => StandardCargoBuilder.Init()
        .SetCode("Gun")
        .SetPrice(10)
        .SetImagePath("red_weapon1")
        .AddKeyword(EKeyword.Gun)
        .Build();

    public static StandardCargo CreateGun2Item() => StandardCargoBuilder.Init()
        .SetCode("Gun 2")
        .SetPrice(10)
        .SetImagePath("green_weapon2")
        .AddKeyword(EKeyword.Gun)
        .Build();

    public static StandardCargo CreateHeavyOrdnance2Item() => StandardCargoBuilder.Init()
        .SetCode("Heavy Ordnance 2")
        .SetPrice(10)
        .SetImagePath("green_weapon2")
        .AddKeyword(EKeyword.HeavyOrdnance)
        .Build();

    public static StandardCargo CreateHeavyOrdnance3Item() => StandardCargoBuilder.Init()
        .SetCode("Heavy Ordnance 3")
        .SetPrice(10)
        .SetImagePath("green_weapon3")
        .AddKeyword(EKeyword.HeavyOrdnance)
        .Build();

    public static StandardCargo CreateHeavyOrdnance4Item() => StandardCargoBuilder.Init()
        .SetCode("Heavy Ordnance 4")
        .SetPrice(10)
        .SetImagePath("red_weapon4")
        .AddKeyword(EKeyword.HeavyOrdnance)
        .Build();

    public static StandardCargo CreateGatlingGunItem() => StandardCargoBuilder.Init()
        .SetCode("Gatling Gun")
        .SetPrice(10)
        .SetImagePath("red_weapon3")
        .AddKeyword(EKeyword.Gatlinggun)
        .Build();

    public static StandardCargo CreateGatlingGun2Item() => StandardCargoBuilder.Init()
        .SetCode("Gatling Gun")
        .SetPrice(10)
        .SetImagePath("red_weapon2")
        .AddKeyword(EKeyword.Gatlinggun)
        .Build();
    
    public static List<ACargo> GetAllAddableCargo() => new(){
        CreateBiofuelGeneratorItem(),
        CreateNuclearGeneratorItem(),
        CreateNuclearReactorItem(),
        CreateArmorItem(),
        CreateChainDriveItem(),
        CreateBagpiperItem(),
        CreateCraneItem(),
        CreateDroneItem(),
        CreateMedicalbayItem(),
        CreateRailGunItem(),
        CreateTeslaGunItem(),
        CreateGunItem(),
        CreateGun2Item(),
        CreateHeavyOrdnance2Item(),
        CreateHeavyOrdnance3Item(),
        CreateHeavyOrdnance4Item(),
        CreateGatlingGunItem(),
        CreateGatlingGun2Item()
    };
}