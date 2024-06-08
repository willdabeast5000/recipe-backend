namespace RecipeApi.Models {

    public class UserEntity : BaseEntity {
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public DateTime LastLoginDate {get; set;}
        public string? Email {get; set;}
        public string? Username {get; set;}
    }
}