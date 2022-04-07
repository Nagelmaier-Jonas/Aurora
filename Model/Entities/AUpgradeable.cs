using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("UPGRADEABLES")]
public abstract class AUpgradeable : AConvoyElement
{
    [Column("ADDON_ID")] public int? AddonId { get; set; }

    public Addon? Addon { get; set; }
}