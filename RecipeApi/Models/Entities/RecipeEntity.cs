using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApi.Models {

    public class RecipeEntity : BaseEntity {
        public IList<IngredientEntity>? Ingredients { get; set; }
        public string? Name {get; set;}
        public string? Instructions {get; set;}
        public string? PreparationTime {get; set;}
        [ForeignKey("CreatedBy")]
        public long? CreatedById {get; set;}
        public UserEntity? CreatedBy {get; set;}
    }
}