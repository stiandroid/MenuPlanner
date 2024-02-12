using MenuPlanner.Components.Badges;
using MenuPlanner.Models.Entities;
using System;

namespace MenuPlanner.Models.AutoMapperProfiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile()
        {
            // Create (Fra EditDTO til Entity)
            CreateMap<RecipeEditDTO, Recipe>();

            // Edit (Fra Entity til EditDTO)
            CreateMap<Recipe, RecipeEditDTO>();

            // View (Fra Entity til DisplayDTO)
            CreateMap<Recipe, RecipeSummaryDisplayDTO>();
            CreateMap<Recipe, RecipeDetailsDisplayDTO>();
        }
    }
}
