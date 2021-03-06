﻿namespace CookingSystem.Services.Models.Recipes
{
    using CookingSystem.Data.Models;
    using System.ComponentModel.DataAnnotations;

    public class RecipeEditServiceModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Category { get; set; }

        public int CategoryId { get; set; }

        public DifficultyLevel Level { get; set; }

        public int CookingTime { get; set; }

        public int Portion { get; set; }

        [Required]
        [MaxLength(3000)]
        public string ContentIngredients { get; set; }

        [MaxLength(3000)]
        public string PreparationMehtod { get; set; }
    }
}
