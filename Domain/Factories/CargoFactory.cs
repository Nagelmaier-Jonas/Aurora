using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;

namespace Domain.Factories;

public static class CargoFactory{

    #region Fixed

        #region Standard

    public static StandardCargo ChainDrive() => new (){
        Name = "Chain-Drive", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Tracks}
            }
        },
        Image = "cards/ChainDrive.png"
    };

    public static StandardCargo FuelPlusSpeed() => new (){
        Name = "Fuel-Plus-Speed", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Biofuelgenerator}
            },
        },
        Image = "cards/FuelPlusSpeed.png",
    };

    public static StandardCargo NoNuclearPlusSpeed() => new (){
        Name = "No-Nuclear-Plus-Speed", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Nucleargenerator}
            }
        },
        Image = "cards/NoNuclearPlusSpeed.png"
    };

    public static StandardCargo NoAtomPlusAtom() => new (){
        Name = "No-Atom-Plus-Atom", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Medicalbay}
            }
        },
        Image = "cards/NoAtomPlusAtom.png"
    };

    public static StandardCargo FuelGenerator() => new (){
        Name = "Fuel-Generator", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Biofuelgenerator}
            }
        },
        Image = "cards/FuelGenerator.png"
    };

    public static StandardCargo Nuclear() => new (){
        Name = "Nuclear", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Nuclearreactor}
            }
        },
        Image = "cards/Nuclear.png"
    };

    public static StandardCargo RepairNoAtom() => new (){
        Name = "Repair-No-Atom", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Drone}
            }
        },
        Image = "cards/RepairNoAtom.png"
    };

    public static StandardCargo GrabberNoAtom() => new (){
        Name = "Grabber-No-Atom", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Crane}
            }
        },
        Image = "cards/GrabberNoAtom.png"
    };

    public static StandardCargo StarNoAtom() => new (){
        Name = "Star-No-Atom", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Bagpiper}
            }
        },
        Image = "cards/StarNoAtom.png"
    };

    public static StandardCargo BonusStar1() => new (){
        Name = "Bonus-Star-1", Image = "cards/Keyword1Star.png"
    };

    #endregion

    #region Armor

    public static ArmorCargo Armor() => new (){
        Name = "Armor", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Armor}
            }
        },
        Price = 1000, Image = "cards/Armor.png"
    };

    #endregion

    #region Crew

    #endregion

    #region Weapon

    public static WeaponCargo GreenWeapon4() => new (){
        Name = "Green-Weapon-4", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Railgun}
            }
        },
        Image = "cards/WeaponGreen4.png"
    };

    public static WeaponCargo GreenWeapon3() => new (){
        Name = "Green-Weapon-3",
        Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Teslagun}
            }
        },
        Image = "cards/WeaponGreen3.png"
    };

    public static WeaponCargo GreenWeapon2() => new (){
        Name = "Green-Weapon-2", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.HeavyOrdnance}
            }
        },
        Image = "cards/WeaponGreen2.png"
    };

    public static WeaponCargo RedWeapon4() => new (){
        Name = "Red-Weapon-4", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.HeavyOrdnance}
            }
        },
        Image = "cards/WeaponRed4.png"
    };

    public static WeaponCargo RedWeapon3() => new (){
        Name = "Red-Weapon-3", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Gatlinggun}
            }
        },
        Image = "cards/WeaponRed3.png"
    };

    public static WeaponCargo RedWeapon2() => new (){
        Name = "Red-Weapon-2", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Gatlinggun}
            }
        },
        Image = "cards/WeaponRed2.png"
    };

    public static WeaponCargo RedWeapon1() => new (){
        Name = "Red-Weapon-1", Keywords = new List<CargosJtKeywords>{
            new(){
                Keyword = new Keyword{Value = EKeyword.Gun}
            }
        },
        Image = "cards/WeaponRed1.png"
    };

    #endregion

    #region Fuel

    #endregion

    #endregion

    #region Buyable

    #region Standard

        public static StandardCargo Granat() => new(){
        Name = "Granat",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Grenade
                }
            }
        },
        Price = 3
    };
    public static StandardCargo MobilnyZagluszacz() => new(){
        Name = "Mobilny-Zagluszacz",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.MobileJammer
                }
            }
        },
        Price = 3
    };
    public static StandardCargo RacjaZywnosciowa() => new(){
        Name = "Racja-Zywnosciowa",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.MRE
                }
            }
        },
        Price = 3
    };
    public static StandardCargo LekPrzeciwOdmrozeniom() => new(){
        Name = "Lek-Przeciw-Odmrozeniom",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.AntiFreeze
                }
            }
        },
        Price = 10
    };
    public static StandardCargo Mina() => new(){
        Name = "Mina",
        Image = "cards/item/mina.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Mine
                }
            }
        },
        Price = 3
    };
    public static StandardCargo KombinezonOchronny() => new(){
        Name = "Kombinezon-Ochronny",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.ProtectionSuit
                }
            }
        },
        Price = 7
    };
    public static StandardCargo PociskiZapalajace() => new(){
        Name = "Pociski-Zapalajace",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Ammo
                }
            }
        },
        Price = 3
    };

    #endregion

    #region Armor

    

    #endregion

    #region Weapon

    

    #endregion

    #region Crew

    public static CrewCargo Kierowca() => new(){
        Name = "Kierowca",
        Image = "",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Nucleargenerator
                }
            }
        },
        Price = 20,
        Vitality = 1
    };
    
    public static CrewCargo Android() => new(){
        Name = "Android",
        Image = "",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Android
                }
            }
        },
        Price = 20,
        Vitality = 1
    };

    public static CrewCargo Pustelnik() => new(){
        Name = "Pustelnik",
        Image = "",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Nuclearreactor
                }
            }
        },
        Price = 15,
        Vitality = 2
    };

    public static CrewCargo LowcaNagrod() => new(){
        Name = "Lowca-Nagrod",
        Image = "",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.KeywordStarAndFuel
                }
            }
        },
        Price = 20,
        Vitality = 2
    };

    public static CrewCargo Strzelec() => new(){
        Name = "Strzelec",
        Image = "",
        Price = 20,
        Vitality = 2
    };

    #endregion

    #region Fuel

    public static FuelCargo KroplowkaOdkazajacaIV() => new(){
        Name = "Kroplowka-Odkazajaca-IV",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.DosingDrip4
                }
            }
        },
        Price = 20
    };
    public static FuelCargo Nitrometan() => new(){
        Name = "Nitrometan",
        Image = "cards/item/nitrometan.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.Nitromethane
                }
            }
        },
        Price = 3
    };
    public static FuelCargo PalnikSpawalniczy() => new(){
        Name = "Palnik-Spawalniczy",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.WeldingTorch
                }
            }
        },
        Price = 3
    };
    public static FuelCargo PodtlenekAzotu() => new(){
        Name = "Podtlenek-Azotu",
        Image = "cards/item/granat.png",
        Keywords = new List<CargosJtKeywords> {
            new() {
                Keyword = new Keyword {
                    Value = EKeyword.NitrousOxide
                }
            }
        },
        Price = 10
    };

    #endregion
    
    #endregion
}