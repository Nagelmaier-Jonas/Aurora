using Model.Entities;
using Model.Entities.Cargo;

namespace Domain.LogicHandlers;

public static class CargoExtension{

    public static List<EKeyword> GetKeywords(this ACargo cargo){
        return cargo.Keywords.Select(k => k.Keyword.Value).ToList();
    }
}