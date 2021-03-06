﻿namespace CookingSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Author { get; set; }

        [Required]
        [MaxLength(250)]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public bool IsDeleted { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }

        public Recipe Recipe { get; set; }

        public int RecipeId { get; set; }
    }
}
