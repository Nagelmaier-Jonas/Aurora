using Model.Entities;

namespace Domain.LogicHandlers;

public static class SessionExtension{
    
    public static bool CanBuy(this Session session, int price){
        return session.Money >= price;
    }
}