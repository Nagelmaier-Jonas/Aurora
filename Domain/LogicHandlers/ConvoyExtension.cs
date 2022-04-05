using System.Data;
using Domain.LogicHandlers.Exceptions;
using Model.Entities.Logic;
using MudBlazor;

namespace Domain.LogicHandlers;

public static class ConvoyExtension {
    public static void AddTruck(this Convoy convoy, Truck truck) {
        if (IsFrontTruckPresent(convoy))
            if (IsTailTruckPresent(convoy))
                throw new ConvoyManagementException("Both trucks occupied!");
            else
                convoy.TailTruck = truck;
        else convoy.FrontTruck = truck;
    }

    public static void AddWagon(this Convoy convoy, Wagon wagon) {
        if (!IsFrontTruckPresent(convoy))
            throw new ConvoyManagementException("Missing front truck!");
        if (!HasEmptySpaces(convoy))
            throw new ConvoyManagementException("Convoy already full!");
        convoy.Wagons.Add(wagon);
    }

    public static void RemoveFrontTruck(this Convoy convoy) {
        convoy.FrontTruck.Addon = null;
        convoy.FrontTruck = null;
        convoy.Wagons.Clear();
    }
    
    public static void RemoveTailTruck(this Convoy convoy) {
        convoy.TailTruck.Addon = null;
        convoy.TailTruck = null;
    }

    public static void RemoveWagon(this Convoy convoy, Wagon wagon) {
        wagon.Addon = null;
        convoy.Wagons.Remove(wagon);
    }
    private static bool IsFrontTruckPresent(this Convoy convoy) => convoy.FrontTruck != null;
    private static bool IsTailTruckPresent(this Convoy convoy) => convoy.TailTruck != null;
    
    private static bool HasEmptySpaces(this Convoy convoy) =>
        convoy.FrontTruck.MaxContainer + (IsTailTruckPresent(convoy) ? convoy.TailTruck.MaxContainer : 0) >
        convoy.Wagons.Count;
    //TODO: unsure about the calculation
}