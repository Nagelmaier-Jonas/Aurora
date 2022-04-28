using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;
using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

namespace Domain.Factories;

public static class TruckFactory
{
        public static Truck CzolgTesli() => new() {
        Code = "CZOLG TESLI",
        Image = "cards/Truck1.png",
        Price = 100000,
        Speed = 3,
        PullForce = 3,
        Slots = new List<ASlot> {
            new StandardSlot {
                Cargo = new StandardCargo
                    {Name = "Ketten-Laufwek", Keywords = new List<CargosJtKeywords> {
                            new() {
                                Keyword = new Keyword{Value = EKeyword.Tracks}
                            }
                        },
                        Image = "cards/ChainDrive.png"},
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot {
                
                Cargo = new WeaponCargo {
                    Name = "Grüne waffe mit 3 irgendwas hald",
                    Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Teslagun}
                        }
                    },
                    Image = "cards/WeaponGreen3.png"
                },
                OrderId = 2
            },
            new CrewSlot {OrderId = 3},
            new StandardSlot {OrderId = 4}
        }
    };

    public static Truck TurboCiezarowka() => new() {
        Code = "TURBO CIEZAROWKA NA BIO-PALIWO",
        Image = "cards/Truck2.png",
        Price = 80000,
        Speed = 4,
        PullForce = 3,
        Slots = new List<ASlot> {
            new StandardSlot {
                Cargo = new StandardCargo {
                    Name = "genertiet dir halt fuel und du kaunst schöller foarn", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Biofuelgenerator}
                        },
                    },
                    Image = "cards/FuelPlusSpeed.png",
                },
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot {
                Cargo = new WeaponCargo {
                    Name = "Rote waffe mit 3 irgendwas hald", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Gatlinggun}
                        }
                    },
                    Image = "cards/WeaponRed3.png"
                },
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot {OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck Apc() => new() {
        Code = "APC",
        Image = "cards/Truck3.png",
        Price = 60000,
        Speed = 2,
        PullForce = 3,
        Slots = new List<ASlot> {
            new StandardSlot {
                Cargo = new StandardCargo
                    {Name = "Ketten-Laufwek", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Tracks}
                        }
                    }, Image = "cards/ChainDrive.png"},
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot {
                Cargo = new WeaponCargo {
                    Name = "Grüne waffe mit 2 irgendwas hald", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.HeavyOrdnance}
                        }
                    },
                    Image = "cards/WeaponGreen2.png"
                },
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot {OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck CzolgImpulsowy() => new() {
        Code = "CZOLG IMPULSOWY",
        Image = "cards/Truck4.png",
        Price = 140000,
        Speed = 4,
        PullForce = 3,
        Slots = new List<ASlot> {
            new StandardSlot {
                Cargo = new StandardCargo
                    {Name = "Ketten-Laufwek", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Tracks}
                        }
                    }, Image = "cards/ChainDrive.png"},
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot {
                Cargo = new WeaponCargo {
                    Name = "Grüne waffe mit 4 irgendwas hald", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Railgun}
                        }
                    },
                    Image = "cards/WeaponGreen4.png"
                },
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot {OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck Ciezarowka() => new() {
        Code = "CIEZAROWKA",
        Image = "cards/Truck5.png",
        Price = 40000,
        Speed = 2,
        PullForce = 2,
        Slots = new List<ASlot> {
            new WeaponSlot {
                Cargo = new WeaponCargo {
                    Name = "Rote waffe mit 1nem irgendwas hald", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Gun}
                        }
                    },
                    Image = "cards/WeaponRed1.png"
                },
                IsConstant = true,
                OrderId = 1
            },
            new CrewSlot {OrderId = 2},
            new StandardSlot{OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };

    public static Truck NuklearnaCiezarowka() => new() {
        Code = "NUKLEARNA CIEZAROWKA",
        Image = "cards/Truck6.png",
        Price = 100000,
        Speed = 4,
        PullForce = 3,
        Slots = new List<ASlot> {
            new StandardSlot {
                Cargo = new StandardCargo {
                    Name = "ja keine ahnung macht halt was", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.Nucleargenerator}
                        }
                    },
                    Image = "cards/NoNuclearPlusSpeed.png"
                },
                IsConstant = true,
                OrderId = 1
            },
            new WeaponSlot {
                Cargo = new WeaponCargo {
                    Name = "Grüne waffe mit 3 irgendwas hald", Keywords = new List<CargosJtKeywords> {
                        new() {
                            Keyword = new Keyword{Value = EKeyword.HeavyOrdnance}
                        }
                    },
                    Image = "cards/WeaponGreen3.png"
                },
                IsConstant = true,
                OrderId = 2
            },
            new CrewSlot {OrderId = 3},
            new StandardSlot{OrderId = 4}
        }
    };
}