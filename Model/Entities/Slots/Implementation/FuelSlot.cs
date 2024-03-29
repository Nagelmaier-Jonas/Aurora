﻿using Model.Entities.Cargo;

namespace Model.Entities.Slots.Implementation;

public class FuelSlot : ASlot{
    public override bool IsInsertable(ICargo cargo) => cargo.IsAddable(this);
}