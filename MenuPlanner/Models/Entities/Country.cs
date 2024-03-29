﻿namespace MenuPlanner.Models.Entities
{
    public class Country
    {
        [StringLength(2)]
        public string ISO3166_2 { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;
    }
}
