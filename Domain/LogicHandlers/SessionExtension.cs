using Model.Entities;

namespace Domain.LogicHandlers;

public static class SessionExtension{
    
    public static bool CanBuy(this Session session, int price){
        return session.Money >= price;
    }
    
    public static void Buy(this Session session, int price){
        session.Money -= price;
    }
    
    public static void Sell(this Session session, int price){
        session.Money += price;
    }
}