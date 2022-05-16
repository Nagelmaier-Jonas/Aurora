using Domain.LogicHandlers.Exceptions;
using Model.Entities;

namespace Domain.LogicHandlers;

public static class ConvoyExtension
{
    public static void AddTruck(this Convoy convoy, Truck truck, Session session){
        if (session.CanBuy(truck.Price)){
            session.Money -= truck.Price;
        }
        else{
            throw new ConvoyManagementException("Not enough Money!");
        }
        if (IsFrontTruckPresent(convoy))
            if (IsBackTruckPresent(convoy))
                throw new ConvoyManagementException("Both trucks occupied!");
            else
                convoy.BackTruck = truck;
        else convoy.FrontTruck = truck;
    }

    public static void AddWagon(this Convoy convoy, Wagon wagon, bool front, Session session)
    {
        if (!IsFrontTruckPresent(convoy)) throw new ConvoyManagementException("No trucks!");
        if (!IsBackTruckPresent(convoy) && !front) throw new ConvoyManagementException("No rear Truck!");
        if (HasFrontTruckEmptySpaces(convoy) && front)
        {
            if (session.CanBuy(wagon.Price)){
                session.Money -= wagon.Price;
            }else{
                throw new ConvoyManagementException("Not enough Money!");
            }
            convoy.FrontTruck.Wagons.Add(wagon);
            return;
        }

        if (HasBackTruckEmptySpaces(convoy) && !front)
        {
            if (session.CanBuy(wagon.Price)){
                session.Money -= wagon.Price;
            }else{
                throw new ConvoyManagementException("Not enough Money!");
            }
            convoy.BackTruck.Wagons.Add(wagon);
            return;
        }

        throw new ConvoyManagementException("Truck has reached Pull limit");
    }

    public static void RemoveFrontTruck(this Convoy convoy, Session session)
    {
        if (convoy.FrontTruck.IsAddonPresent()){
            session.Money += convoy.FrontTruck.Addon.Price;
            foreach (var slot in convoy.FrontTruck.Addon.Slots.Where(slot => slot.IsConstant == false)){
                slot.RemoveCargo(session);
            }
        }
        foreach (var slot in convoy.FrontTruck.Slots){
            slot.RemoveCargo(session);
        }
        session.Money += convoy.FrontTruck.Price;
        
        if (convoy.BackTruck is not null){
            var tempTruck = convoy.BackTruck;
            convoy.BackTruck = null;
            convoy.FrontTruck = tempTruck;
            return;
        }

        convoy.FrontTruckId = null;
        convoy.FrontTruck = null;
    }

    public static void RemoveTailTruck(this Convoy convoy, Session session)
    {
        if (convoy.BackTruck.IsAddonPresent()){
            session.Money += convoy.BackTruck.Addon.Price;
            foreach (var slot in convoy.BackTruck.Addon.Slots){
                slot.RemoveCargo(session);
            }
        }
        foreach (var slot in convoy.BackTruck.Slots.Where(slot => slot.IsConstant == false)){
            slot.RemoveCargo(session);
        }
        session.Money += convoy.BackTruck.Price;
        
        convoy.BackTruck.Addon = null;
        convoy.BackTruck = null;
    }

    public static void RemoveWagon(this Convoy convoy, Wagon wagon, Session session)
    {
        if (LocateWagon(convoy, wagon) == "front") convoy.FrontTruck.Wagons.Remove(wagon);
        if (LocateWagon(convoy, wagon) == "back") convoy.BackTruck.Wagons.Remove(wagon);
        if (wagon.IsAddonPresent()){
            session.Money += wagon.Addon.Price;
            foreach (var slot in wagon.Addon.Slots){
                slot.RemoveCargo(session);
            }
        }
        foreach (var slot in wagon.Slots.Where(slot => slot.IsConstant == false)){
            slot.RemoveCargo(session);
        }
        session.Money += wagon.Price;
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