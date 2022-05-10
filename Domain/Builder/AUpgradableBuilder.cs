using Model.Entities;

namespace Domain.Builder;

public abstract class AUpgradableElementBuilder<TEntity, TBuilder> : AConvoyElementBuilder<TEntity, TBuilder>
    where TEntity : AUpgradeable
    where TBuilder : AUpgradableElementBuilder<TEntity, TBuilder>{
    private TEntity _element;

    protected AUpgradableElementBuilder(TEntity element) : base(element){
        _element = element;
    }

    public TBuilder SetAddon(Addon addon){
        _element.Addon = addon;
        return (this as TBuilder)!;
    }
}