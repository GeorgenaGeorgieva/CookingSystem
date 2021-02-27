﻿namespace CookingSystem.Web.Models.Comments
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public int RecipeId { get; set; }
    }
}
