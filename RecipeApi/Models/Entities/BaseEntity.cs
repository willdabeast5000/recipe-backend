using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApi.Models {
    public abstract class BaseEntity {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated {get;set;}
    }
}