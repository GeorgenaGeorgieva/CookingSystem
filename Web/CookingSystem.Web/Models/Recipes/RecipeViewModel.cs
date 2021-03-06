﻿namespace CookingSystem.Web.Models.Recipes
{
    using CookingSystem.Data.Models;
    using CookingSystem.Services.Models.Categories;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class RecipeViewModel
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue)]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Recipe title*")]
        public string Name { get; set; }

        [Display(Name = "Cooking time /minutes/*")]
        public int CookingTime { get; set; }

        [Display(Name = "Number of servings*")]
        public int Portion { get; set; }

        [Display(Name = "Degree of Difficulty")]
        public DifficultyLevel Level { get; set; }

        [Required]
        [MaxLength(3000)]
        [Display(Name = "Products (one per row) / Example: potatoes - 1 kg / *")]
        public string ContentIngredients { get; set; }

        [MaxLength(3000)]
        [Display(Name = "Method of preparation *")]
        public string PreparationMethod { get; set; }

        public ICollection<CategoryListingServiceModel> Categories { get; set; }

        public string MainImage { get; set; }

        public string UserName { get; set; }

        public User User { get; set; }

        public string UserId { get; set; }
    }
}
