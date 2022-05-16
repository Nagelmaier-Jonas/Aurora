using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;

namespace Domain.Builder;

public static class Factory {
    /// <summary>
    /// All methods to create trucks
    /// </summary>
    
    public static Truck CreateTeslaTank() => TruckBuilder.Init()
        .SetCode("Tesla Tank")
        .SetPrice(140000)
        .SetSpeed(3)
        .SetPullForce(3)
        .SetImagePath("truck/tesla_front_tank")
        .AddDefaultSlot(1,CreateChainDriveItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateTeslaGunItem()).IsFixedSlot()
        .AddCrewSlot(3)
        .AddDefaultSlot(4)
        .Build(); 

    public static Truck CreateBiofuelTruck() => TruckBuilder.Init()
        .SetCode("Biofuel Truck")
        .SetPrice(80000)
        .SetSpeed(4)
        .SetPullForce(3)
        .SetImagePath("truck/biofuel_powered_front_truck")
        .AddDefaultSlot(1,CreateBiofuelGeneratorItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateGatlingGunItem()).IsFixedSlot()
        .AddCrewSlot(3)
        .AddDefaultSlot(4)
        .Build();

    public static Truck CreateApcTruck() => TruckBuilder.Init()
        .SetCode("APC Tank")
        .SetPrice(60000)
        .SetSpeed(2)
        .SetPullForce(3)
        .SetImagePath("truck/apc_front_tank")
        .AddDefaultSlot(1,CreateChainDriveItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateHeavyOrdnance2Item()).IsFixedSlot()
        .AddCrewSlot(3)
        .AddDefaultSlot(4)
        .Build();

    public static Truck CreateRailgunTruck() => TruckBuilder.Init()
        .SetCode("Railgun Truck")
        .SetPrice(140000)
        .SetSpeed(4)
        .SetPullForce(3)
        .SetImagePath("truck/railgun_tank_front_truck")
        .AddDefaultSlot(1,CreateChainDriveItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateRailGunItem()).IsFixedSlot()
        .AddCrewSlot(3)
        .Build();

    public static Truck CreateTruck() => TruckBuilder.Init()
        .SetCode("Truck")
        .SetPrice(500000)
        .SetSpeed(2)
        .SetPullForce(2)
        .SetImagePath("truck/truck_front")
        .AddDefaultSlot(1,CreateGunItem()).IsFixedSlot()
        .AddCrewSlot(2)
        .AddDefaultSlot(3)
        .AddDefaultSlot(4)
        .Build();

    public static Truck CreateNuclearpoweredTruck() => TruckBuilder.Init()
        .SetCode("Nuclearpowered Truck")
        .SetPrice(100000)
        .SetSpeed(4)
        .SetPullForce(3)
        .SetImagePath("truck/nuclear_powered_front_truck")
        .AddDefaultSlot(1,CreateNuclearGeneratorItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateHeavyOrdnance3Item()).IsFixedSlot()
        .AddCrewSlot(3)
        .AddDefaultSlot(4)
        .Build();
    
    public static List<Truck> GetAllTrucks() => new(){
        CreateTruck(),
        CreateBiofuelTruck(),
        CreateNuclearpoweredTruck(),
        CreateApcTruck(),
        CreateRailgunTruck(),
        CreateTeslaTank(),
    };

    /// <summary>
    /// All methods to create wagons
    /// </summary>
    public static Wagon CreateExampleWagon() => WagonBuilder.Init()
        .SetCode("Example")
        .SetPrice(10)
        .SetImagePath("wagon/example")
        .Build();

    public static Wagon CreateReinforcedWagon() => WagonBuilder.Init()
        .SetCode("Reinforced Wagon")
        .SetPrice(7000)
        .SetImagePath("wagon/reinforced_wagon")
        .AddDefaultSlot(1)
        .AddDefaultSlot(2)
        .AddDefaultSlot(3)
        .AddDefaultSlot(4,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Wagon CreateReinforcedFuelWagon() => WagonBuilder.Init()
        .SetCode("Reinforced Fuel Wagon")
        .SetPrice(10000)
        .SetImagePath("wagon/reinforced_fuel_wagon")
        .AddFuelSlot(1)
        .AddFuelSlot(2)
        .AddFuelSlot(3)
        .AddDefaultSlot(4,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Wagon CreateDoubleReinforcedFuelWagon() => WagonBuilder.Init()
        .SetCode("Double Reinforced Fuel Wagon")
        .SetPrice(12000)
        .SetImagePath("wagon/reinforced_fuel_wagon2")
        .AddFuelSlot(1)
        .AddFuelSlot(2)
        .AddDefaultSlot(3,CreateGun2Item()).IsFixedSlot()
        .AddDefaultSlot(4,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Wagon CreateWagon() => WagonBuilder.Init()
        .SetCode("Wagon")
        .SetPrice(5000)
        .SetImagePath("wagon/wagon")
        .AddDefaultSlot(1)
        .AddDefaultSlot(2)
        .AddDefaultSlot(3)
        .Build();

    public static Wagon CreateMedicalWagon() => WagonBuilder.Init()
        .SetCode("Medical Wagon")
        .SetPrice(15000)
        .SetImagePath("wagon/medical_wagon")
        .AddDefaultSlot(1)
        .AddDefaultSlot(2)
        .AddFuelSlot(3)
        .AddDefaultSlot(4,CreateMedicalbayItem()).IsFixedSlot()
        .Build();
    
    public static List<Wagon> GetAllWagons() => new(){
        CreateWagon(),
        CreateReinforcedWagon(),
        CreateReinforcedFuelWagon(),
        CreateDoubleReinforcedFuelWagon(),
        CreateMedicalWagon()
    };

    /// <summary>
    /// All methods to create Addons
    /// </summary>

    public static Addon CreateSmallStorage() => AddonBuilder.Init()
        .SetCode("Small Storage")
        .SetPrice(1000)
        .SetImagePath("addon/smallstorage_addon")
        .AddDefaultSlot(1)
        .AddDefaultSlot(2)
        .Build();

    public static Addon CreateStorage() => AddonBuilder.Init()
        .SetCode("Storage")
        .SetPrice(3000)
        .SetImagePath("addon/storage_addon")
        .AddDefaultSlot(1)
        .AddDefaultSlot(2)
        .AddDefaultSlot(3)
        .Build();

    public static Addon CreateNuclearReactor() => AddonBuilder.Init()
        .SetCode("Nuclearreactor")
        .SetPrice(25000)
        .SetImagePath("addon/nuclearreactor_addon")
        .AddDefaultSlot(1,CreateNuclearReactorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateHeavyGun() => AddonBuilder.Init()
        .SetCode("Heavy Gun")
        .SetPrice(35000)
        .SetImagePath("addon/heavygun_addon")
        .AddDefaultSlot(1,CreateHeavyOrdnance4Item()).IsFixedSlot()
        .Build();

    public static Addon CreateArmor() => AddonBuilder.Init()
        .SetCode("Armor")
        .SetPrice(2000)
        .SetImagePath("addon/armor_addon")
        .AddDefaultSlot(1,CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(3,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateHeavyArmor() => AddonBuilder.Init()
        .SetCode("Heavy Armor")
        .SetPrice(5000)
        .SetImagePath("addon/heavyarmor_addon")
        .AddDefaultSlot(1,CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(3,CreateArmorItem()).IsFixedSlot()
        .AddDefaultSlot(4,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateBioFuelGenerator() => AddonBuilder.Init()
        .SetCode("Bio Fuel Generator")
        .SetPrice(25000)
        .SetImagePath("addon/biofuel_generator_addon")
        .AddDefaultSlot(1,CreateBiofuelGeneratorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateLargeStorage() => AddonBuilder.Init()
        .SetCode("Large Storage")
        .SetPrice(3000)
        .SetImagePath("addon/largestorage_addon")
        .AddDefaultSlot(1)
        .AddDefaultSlot(2)
        .AddDefaultSlot(3,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateAutocannon() => AddonBuilder.Init()
        // Hits every enemy
        .SetCode("Autocannon")
        .SetPrice(15000)
        .SetImagePath("addon/autocannon_addon")
        .AddDefaultSlot(1,CreateGatlingGun2Item()).IsFixedSlot()
        .AddCrewSlot(2)
        .Build();
        

    public static Addon CreateDrone() => AddonBuilder.Init()
        .SetCode("Drone")
        .SetPrice(10)
        .SetImagePath("addon/drones_addon")
        .AddDefaultSlot(1,CreateDroneItem()).IsFixedSlot()
        .AddDefaultSlot(2,CreateArmorItem()).IsFixedSlot()
        .Build();

    public static Addon CreateZuraw() => AddonBuilder.Init()
        .SetCode("Crane")
        .SetPrice(20000)
        .SetImagePath("addon/crane_addon")
        .AddDefaultSlot(1,CreateCraneItem()).IsFixedSlot()
        .AddCrewSlot(2)
        .AddDefaultSlot(3)
        .Build();

    public static Addon CreateBagpiper() => AddonBuilder.Init()
        .SetCode("Bagpiper")
        .SetPrice(7000)
        .SetImagePath("addon/bagpiper_addon")
        .AddDefaultSlot(1,CreateBagpiperItem()).IsFixedSlot()
        .AddDefaultSlot(2)
        .AddDefaultSlot(3)
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

    ///<summary>
    /// All methods to create fixed Cargo
    ///</summary>
    
    public static StandardCargo CreateRacjaZywnosciowa() => StandardCargoBuilder.Init()
        .SetCode("Racja Zywnosciowa")
        .SetPrice(10)
        .SetImagePath("item/racajaZywnosciowa")
        .AddKeyword(EKeyword.MRE)
        .Build();

    public static StandardCargo CreateGranat() => StandardCargoBuilder.Init()
        .SetCode("Granat")
        .SetPrice(10)
        .SetImagePath("item/granat")
        .AddKeyword(EKeyword.Grenade)
        .Build();

    public static StandardCargo CreateKombinezonOchronyu() => StandardCargoBuilder.Init()
        .SetCode("Kombinezon Ochronyu")
        .SetPrice(10)
        .SetImagePath("item/kombinezon_ochronyu")
        .AddKeyword(EKeyword.ProtectionSuit)
        .Build();

    public static StandardCargo CreateKoplowkaOdkazajacaIV() => StandardCargoBuilder.Init()
        .SetCode("Koplowka OdkazajacaIV")
        .SetPrice(10)
        .SetImagePath("item/koplowkaOdkazajacaIV")
        .AddKeyword(EKeyword.DosingDrip4)
        .Build();

    public static StandardCargo CreateLekPrzeciwOdmrozeniom() => StandardCargoBuilder.Init()
        .SetCode("Lek Przeciw Odmrozeniom")
        .SetPrice(10)
        .SetImagePath("item/lek_przeciw_odmrozeniom")
        .AddKeyword(EKeyword.AntiFreeze)
        .Build();

    public static StandardCargo CreateMina() => StandardCargoBuilder.Init()
        .SetCode("Mina")
        .SetPrice(10)
        .SetImagePath("item/mina")
        .AddKeyword(EKeyword.Mine)
        .Build();

    public static StandardCargo CreateMobilnyZagluszacz() => StandardCargoBuilder.Init()
        .SetCode("Mobilny Zagluszacz")
        .SetPrice(10)
        .SetImagePath("item/mobilny_zagluszacz")
        .AddKeyword(EKeyword.MobileJammer)
        .Build();

    public static StandardCargo CreatePociskiZapalajace() => StandardCargoBuilder.Init()
        .SetCode("Pociski Zapalajace")
        .SetPrice(10)
        .SetImagePath("item/pociskiZapalajace")
        .AddKeyword(EKeyword.Ammo)
        .Build();

    public static List<ACargo> GetAllFixedCargo() => new(){
        CreateRacjaZywnosciowa(),
        CreateGranat(),
        CreateKombinezonOchronyu(),
        CreateKoplowkaOdkazajacaIV(),
        CreateLekPrzeciwOdmrozeniom(),
        CreateMina(),
        CreateMobilnyZagluszacz(),
        CreatePociskiZapalajace()
    };

    ///<summary>
    /// All methods to create addable Cargo
    ///</summary>
    
    public static FuelCargo CreateNitrometan() => FuelCargoBuilder.Init()
        .SetCode("Nitrometan")
        .SetPrice(10)
        .SetImagePath("item/nitrometan")
        .AddKeyword(EKeyword.Nitromethane)
        .Build();
    
    public static FuelCargo CreatePalnikSpawalniczy() => FuelCargoBuilder.Init()
        .SetCode("Palnik Spawalniczy")
        .SetPrice(10)
        .SetImagePath("item/palnik_spawalniczy")
        .AddKeyword(EKeyword.WeldingTorch)
        .Build();
    
    public static FuelCargo CreatePootlenekAzotu() => FuelCargoBuilder.Init()
        .SetCode("Pootlenek Azotu")
        .SetPrice(10)
        .SetImagePath("item/pootlenek_azotu")
        .AddKeyword(EKeyword.NitrousOxide)
        .Build();
    public static CrewCargo CreateCyborg() => CrewCargoBuilder.Init()
        .SetCode("Cyborg")
        .SetPrice(10)
        .SetImagePath("crew/Cyborg")
        .AddKeyword(EKeyword.Cyborg)
        .Build();
    
    public static CrewCargo CreateAndroid() => CrewCargoBuilder.Init()
        .SetCode("Android")
        .SetPrice(10)
        .SetImagePath("crew/Android")
        .AddKeyword(EKeyword.Android)
        .Build();
    
    public static CrewCargo CreateMechanik() => CrewCargoBuilder.Init()
        .SetCode("Mechanik")
        .SetPrice(10)
        .SetImagePath("crew/Mechanik")
        .AddKeyword(EKeyword.Mechanic)
        .Build();
    
    public static CrewCargo CreateRenegat() => CrewCargoBuilder.Init()
        .SetCode("Renegat")
        .SetPrice(10)
        .SetImagePath("crew/Renegat")
        .AddKeyword(EKeyword.Renegade)
        .Build();
    
    public static CrewCargo CreatePustelnik() => CrewCargoBuilder.Init()
        .SetCode("Pustelnik")
        .SetPrice(10)
        .SetImagePath("crew/Pustelnik")
        .AddKeyword(EKeyword.Pustelnik)
        .Build();

    public static StandardCargo CreateBiofuelGeneratorItem() => StandardCargoBuilder.Init()
        .SetCode("Biofuel Generator")
        .SetPrice(10)
        .SetImagePath("items/biofuel_generator2")
        .AddKeyword(EKeyword.Biofuelgenerator)
        .Build();

    public static StandardCargo CreateNuclearGeneratorItem() => StandardCargoBuilder.Init()
        .SetCode("Nuclear Generator")
        .SetPrice(10)
        .SetImagePath("items/nuclear_generator")
        .AddKeyword(EKeyword.Nucleargenerator)
        .Build();

    public static StandardCargo CreateNuclearReactorItem() => StandardCargoBuilder.Init()
        .SetCode("Nuclear Reactor")
        .SetPrice(10)
        .SetImagePath("items/radioactive")
        .AddKeyword(EKeyword.Nuclearreactor)
        .Build();

    public static ArmorCargo CreateArmorItem() => ArmorCargoBuilder.Init()
        .SetCode("Armor")
        .SetPrice(10)
        .SetImagePath("items/armor")
        .AddKeyword(EKeyword.Armor)
        .Build();

    public static StandardCargo CreateChainDriveItem() => StandardCargoBuilder.Init()
        .SetCode("Chaindrive")
        .SetPrice(10)
        .SetImagePath("items/chaindrive")
        .AddKeyword(EKeyword.Tracks)
        .Build();

    public static StandardCargo CreateBagpiperItem() => StandardCargoBuilder.Init()
        .SetCode("Bagpiper")
        .SetPrice(10)
        .SetImagePath("items/radioactive_star")
        .AddKeyword(EKeyword.Bagpiper)
        .Build();

    public static StandardCargo CreateCraneItem() => StandardCargoBuilder.Init()
        .SetCode("Crane")
        .SetPrice(10)
        .SetImagePath("items/radioactive_crane")
        .AddKeyword(EKeyword.Crane)
        .Build();

    public static StandardCargo CreateDroneItem() => StandardCargoBuilder.Init()
        .SetCode("Drone")
        .SetPrice(10)
        .SetImagePath("items/dronestation")
        .AddKeyword(EKeyword.Drone)
        .Build();

    public static StandardCargo CreateMedicalbayItem() => StandardCargoBuilder.Init()
        .SetCode("Medicalbay")
        .SetPrice(10)
        .SetImagePath("items/medical_bay")
        .AddKeyword(EKeyword.Medicalbay)
        .Build();

    public static WeaponCargo CreateRailGunItem() => WeaponCargoBuilder.Init()
        .SetCode("Rail Gun")
        .SetPrice(10)
        .SetImagePath("items/green_weapon4")
        .AddKeyword(EKeyword.Railgun)
        .Build();

    public static WeaponCargo CreateTeslaGunItem() => WeaponCargoBuilder.Init()
        .SetCode("Tesla Gun")
        .SetPrice(10)
        .SetImagePath("items/green_weapon3")
        .AddKeyword(EKeyword.Teslagun)
        .Build();

    public static WeaponCargo CreateGunItem() => WeaponCargoBuilder.Init()
        .SetCode("Gun")
        .SetPrice(10)
        .SetImagePath("items/red_weapon1")
        .AddKeyword(EKeyword.Gun)
        .Build();

    public static WeaponCargo CreateGun2Item() => WeaponCargoBuilder.Init()
        .SetCode("Gun 2")
        .SetPrice(10)
        .SetImagePath("items/green_weapon2")
        .AddKeyword(EKeyword.Gun)
        .Build();

    public static WeaponCargo CreateHeavyOrdnance2Item() => WeaponCargoBuilder.Init()
        .SetCode("Heavy Ordnance 2")
        .SetPrice(10)
        .SetImagePath("items/green_weapon2")
        .AddKeyword(EKeyword.HeavyOrdnance)
        .Build();

    public static WeaponCargo CreateHeavyOrdnance3Item() => WeaponCargoBuilder.Init()
        .SetCode("Heavy Ordnance 3")
        .SetPrice(10)
        .SetImagePath("items/green_weapon3")
        .AddKeyword(EKeyword.HeavyOrdnance)
        .Build();

    public static WeaponCargo CreateHeavyOrdnance4Item() => WeaponCargoBuilder.Init()
        .SetCode("Heavy Ordnance 4")
        .SetPrice(10)
        .SetImagePath("items/red_weapon4")
        .AddKeyword(EKeyword.HeavyOrdnance)
        .Build();

    public static WeaponCargo CreateGatlingGunItem() => WeaponCargoBuilder.Init()
        .SetCode("Gatling Gun")
        .SetPrice(10)
        .SetImagePath("items/red_weapon3")
        .AddKeyword(EKeyword.Gatlinggun)
        .Build();

    public static WeaponCargo CreateGatlingGun2Item() => WeaponCargoBuilder.Init()
        .SetCode("Gatling Gun")
        .SetPrice(10)
        .SetImagePath("items/red_weapon2")
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
        CreateGatlingGun2Item(),
        CreateCyborg(),
        CreateAndroid(),
        CreateMechanik(),
        CreatePustelnik(),
        CreateRenegat(),
        CreateNitrometan(),
        CreatePalnikSpawalniczy(),
        CreatePootlenekAzotu()
    };
}