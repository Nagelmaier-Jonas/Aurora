using Domain.LogicHandlers.Exceptions;
using Model.Entities;

namespace Domain.LogicHandlers;

public static class ConvoyExtension
{
    public static void AddTruck(this Convoy convoy, Truck truck)
    {
        if (IsFrontTruckPresent(convoy))
            if (IsBackTruckPresent(convoy))
                throw new ConvoyManagementException("Both trucks occupied!");
            else
                convoy.BackTruck = truck;
        else convoy.FrontTruck = truck;
    }

    public static void AddWagon(this Convoy convoy, Wagon wagon, bool front)
    {
        if (!IsFrontTruckPresent(convoy)) throw new ConvoyManagementException("No trucks!");
        if (!IsBackTruckPresent(convoy) && !front) throw new ConvoyManagementException("No rear Truck!");
        if (HasFrontTruckEmptySpaces(convoy) && front)
        {
            convoy.FrontTruck.Wagons.Add(wagon);
            return;
        }

        if (HasBackTruckEmptySpaces(convoy) && !front)
        {
            convoy.BackTruck.Wagons.Add(wagon);
            return;
        }

        throw new ConvoyManagementException("Truck has reached Pull limit");
    }

    public static void RemoveFrontTruck(this Convoy convoy)
    {
        if (convoy.IsBackTruckPresent())
        {
            var temp = convoy.BackTruck;
            convoy.BackTruck.Addon = null;
            convoy.BackTruck = null;
            convoy.FrontTruck = temp;
            return;
        }

        convoy.FrontTruck.Addon = null;
        convoy.FrontTruck = null;
    }

    public static void RemoveTailTruck(this Convoy convoy)
    {
        convoy.BackTruck.Addon = null;
        convoy.BackTruck = null;
    }

    public static void RemoveWagon(this Convoy convoy, Wagon wagon)
    {
        if (LocateWagon(convoy, wagon) == "front") convoy.FrontTruck.Wagons.Remove(wagon);
        if (LocateWagon(convoy, wagon) == "back") convoy.BackTruck.Wagons.Remove(wagon);
        wagon.Addon = null;
        wagon = null;
    }

    public static string LocateWagon(this Convoy convoy, Wagon wagon)
    {
        if (convoy.IsFrontTruckPresent())
            if (convoy.FrontTruck.Wagons.Contains(wagon))
                return "front";
        if (convoy.IsBackTruckPresent())
            if (convoy.BackTruck.Wagons.Contains(wagon))
                return "back";
        return null;
    }

    public static List<Wagon> GetWagonIterator(this Convoy convoy)
    {
        var wagons = new List<Wagon>();
        if (IsFrontTruckPresent(convoy))
            if (convoy.FrontTruck.Wagons.Count > 0)
                wagons.AddRange(convoy.FrontTruck.Wagons);
        if (IsBackTruckPresent(convoy))
            if (convoy.BackTruck.Wagons.Count > 0)
                wagons.AddRange(convoy.BackTruck.Wagons);
        return wagons;
    }

    public static bool IsFrontTruckPresent(this Convoy convoy)
    {
        return convoy.FrontTruck != null;
    }

    public static bool IsBackTruckPresent(this Convoy convoy)
    {
        return convoy.BackTruck != null;
    }

    private static bool HasEmptySpaces(this Convoy convoy)
    {
        return HasFrontTruckEmptySpaces(convoy) || HasBackTruckEmptySpaces(convoy);
    }

    public static bool HasFrontTruckEmptySpaces(this Convoy convoy)
    {
        return convoy.FrontTruck.PullForce > convoy.FrontTruck.Wagons.Count;
    }

    public static bool HasBackTruckEmptySpaces(this Convoy convoy)
    {
        return IsBackTruckPresent(convoy) ? convoy.BackTruck.PullForce > convoy.BackTruck.Wagons.Count : false;
    }
}