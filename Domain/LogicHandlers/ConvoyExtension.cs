using Domain.LogicHandlers.Exceptions;
using Model.Entities.Database;

namespace Domain.LogicHandlers;

public static class ConvoyExtension {
    public static void AddTruck(this Convoy convoy, Truck truck) {
        if (IsFrontTruckPresent(convoy))
            if (IsBackTruckPresent(convoy))
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
        convoy.FrontTruck.Wagons.Add(wagon);
    }

    public static void RemoveFrontTruck(this Convoy convoy) {
        convoy.FrontTruck.Addon = null;
        convoy.FrontTruck = null;
        convoy.FrontTruck.Wagons.Clear();
        if (convoy.IsBackTruckPresent()) {
            convoy.BackTruck.Wagons.Clear();
        }
    }

    public static void RemoveTailTruck(this Convoy convoy) {
        convoy.BackTruck.Addon = null;
        convoy.BackTruck = null;
    }

    public static void RemoveWagon(this Convoy convoy, Wagon wagon) {
        wagon.Addon = null;
        convoy.GetWagonIterator().Remove(wagon);
    }

    public static List<Wagon> GetWagonIterator(this Convoy convoy) =>
        IsBackTruckPresent(convoy)
            ? convoy.FrontTruck.Wagons.Concat(convoy.BackTruck.Wagons).ToList()
            : convoy.FrontTruck.Wagons;


    private static bool IsFrontTruckPresent(this Convoy convoy) => convoy.FrontTruck != null;
    private static bool IsBackTruckPresent(this Convoy convoy) => convoy.BackTruck != null;

    private static bool HasEmptySpaces(this Convoy convoy) =>
        HasFrontTruckEmptySpaces(convoy) || HasBackTruckEmptySpaces(convoy);

    public static bool HasFrontTruckEmptySpaces(this Convoy convoy) =>
        convoy.FrontTruck.Capacity > convoy.FrontTruck.Wagons.Count;

    public static bool HasBackTruckEmptySpaces(this Convoy convoy) =>
        IsBackTruckPresent(convoy) ? convoy.BackTruck.Capacity > convoy.BackTruck.Wagons.Count : false;
}