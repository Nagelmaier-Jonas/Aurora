﻿using Domain.LogicHandlers;
using Model.Entities;
using Model.Entities.Cargo;

namespace Domain.Builder; 

public class ACargoBuilder<TEntity, TBuilder> where TEntity : ACargo
    where TBuilder : ACargoBuilder<TEntity, TBuilder>{
    private readonly TEntity _element;

    public ACargoBuilder(TEntity element){
        _element = element;
        _element.Keywords = new List<Keyword>();
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
        _element.Image = "/cards/" + imagePath + ".png";
        return (this as TBuilder)!;
    }
    
    public TBuilder AddKeyword(EKeyword keyword){
        _element.Keywords.Add(new Keyword{Value = keyword});
        return (this as TBuilder)!;
    }

    public TEntity Build(){
        return _element;
    }
}