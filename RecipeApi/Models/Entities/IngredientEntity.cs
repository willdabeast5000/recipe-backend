using RecipeApi.Constants;

namespace RecipeApi.Models
{
    public class IngredientEntity : BaseEntity {
        public string? Name { get; set; }
        public long Amount { get; set; }
        public UnitOfMeasureEnum Unit { get; set; }
        // For when the user can't/doesn't want to select from the list of available units
        public string? FreeTextUnit { get; set; }
    }
}