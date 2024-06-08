using System.ComponentModel;

namespace RecipeApi.Constants {

    public enum UnitOfMeasureEnum {
        [Description("None")]
        None = 0,
        [Description("Cup")]
        Cup = 1,
        [Description("Teaspoon")]
        Teaspoon = 2,
        [Description("Tablespoon")]
        Tablespoon = 3,
        [Description("Gram")]
        Gram = 4,
        [Description("Ounce")]
        Ounce = 5,
        [Description("Pound")]
        Pound = 6,
        [Description("Pint")]
        Pint = 7,
        [Description("Quart")]
        Quart = 8,
        [Description("Gallon")]
        Gallon = 9,
        // To be continued later, there's probably a better way to do this over just listing all of them out.
        // Should look up potential measurement/unit conversion packages/apis
    }
}