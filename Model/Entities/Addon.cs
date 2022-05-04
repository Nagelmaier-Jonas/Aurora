using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Entities;

[Table("ADDONS")]
public class Addon : AConvoyElement{
    public AUpgradeable Upgradeable{ get; set; }
}