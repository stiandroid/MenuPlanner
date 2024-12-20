﻿namespace MenuPlanner.Models.DTOs.Display
{
    public class RecipeDetailsDisplayDTO : IDomainDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Alias { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty; // Autogenerert: "Svenske kjøttboller" => "svenske-kjottboller"

        public LifecycleState State { get; set; } // Kanskje nyttig for å vise status i admin
        public DifficultyLevel DifficultyLevel { get; set; }
        public double? RatingAverage { get; set; }
        public TimeSpan PrepTime { get; set; }
        public CountryDisplayDTO? Country { get; set; }

        public List<RecipeIngredientDisplayDTO>? RecipeIngredients { get; set; }
        public List<RecipeStepDisplayDTO>? Steps { get; set; }
        public List<RecipeNoteDisplayDTO>? Notes { get; set; }

        // Eventuelle SubRecipes vises under hovedoppskriften.
        public List<RecipeDetailsDisplayDTO>? SubRecipes { get; set; }
        public UserDisplayDTO? User { get; set; }
    }
}
