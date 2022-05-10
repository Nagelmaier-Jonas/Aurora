using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Slots.Implementation;

namespace Domain.Builder;

public class AConvoyElementBuilder<TEntity, TBuilder> where TEntity : AConvoyElement
    where TBuilder : AConvoyElementBuilder<TEntity, TBuilder>{
    private readonly TEntity _element;

    public AConvoyElementBuilder(TEntity element){
        _element = element;
    }

    public TBuilder AddCrewSlot(ACargo? cargo = null){
        _element.Slots.Add(new CrewSlot()
            { Element = _element, Cargo = cargo});

        return (this as TBuilder)!;
    }

    public TBuilder AddDefaultSlot(ACargo? cargo = null){
        _element.Slots.Add(new StandardSlot()
            { Element = _element, Cargo = cargo});

        return (this as TBuilder)!;
    }

    public TBuilder AddFuelSlot(ACargo? cargo = null){
        _element.Slots.Add(new FuelSlot()
            { Element = _element, Cargo = cargo});

        return (this as TBuilder)!;
    }

    public TBuilder IsFixedSlot(){
        if (_element.Slots.Count > 0)
            _element.Slots.Last().IsConstant = false;

        return (this as TBuilder)!;
    }

    public TBuilder SetCode(string code){
        _element.Code = code;
        return (this as TBuilder)!;
    }

    public TBuilder SetPrice(int price){
        _element.Price = price;
        return (this as TBuilder)!;
    }

    public TBuilder SetImagePath(string imagePath){
        _element.Image = imagePath;
        return (this as TBuilder)!;
    }

    public TEntity Build(){
        return _element;
    }
}