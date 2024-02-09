﻿namespace MenuPlanner.Models.DTOs.Display
{
    public class UserDisplayDTO
    {
        public string Name { get; set; } = string.Empty;
        public bool HasProfileImage { get; set; }
        public bool HasBackgropImage { get; set; }
        public string Introduction { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Website { get; set; }
        public string? Instagram { get; set; }
        public string? TwitterX { get; set; }
        public string? Facebook { get; set; }
        public List<RecipeDetailsDisplayDTO> Recipes { get; set; } = [];
    }
}
