using System.ComponentModel.DataAnnotations;

namespace MenuPlanner.Enums
{
    public enum MeasurementUnit
    {
        [Display(Name = "g")]
        Gram,
        [Display(Name = "kg")]
        Kilogram,
        [Display(Name = "dl")]
        Deciliter,
        [Display(Name = "l")]
        Liter,

        [Display(Name = "oz")]
        Ounce,
        [Display(Name = "fl oz")]
        FluidOunce,
        [Display(Name = "lb")]
        Pound,
        [Display(Name = "pt")]
        Pint,

        [Display(Name = "kopp")]
        Cup,
        [Display(Name = "ts")]
        Teaspoon,
        [Display(Name = "ss")]
        Tablespoon,
        [Display(Name = "klype")]
        Pinch, // En klype salt
        [Display(Name = "stk")]
        Piece // F.eks. 1 vaniljestang, 1 egg, osv.
    }
}
