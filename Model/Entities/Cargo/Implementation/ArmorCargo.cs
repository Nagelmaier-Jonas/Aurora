﻿using Model.Entities.Slots.Implementation;

namespace Model.Entities.Cargo.Implementation;

public class ArmorCargo : ACargo{
    public override bool IsAddable(CrewSlot crewSlot) => false;
    public override bool IsAddable(FuelSlot fuelSlot) => false;
    public override bool IsAddable(ArmorSlot armorSlot) => true;
    public override bool IsAddable(StandardSlot standardSlot) => true;
    public override bool IsAddable(WeaponSlot weaponSlot) => false;
}