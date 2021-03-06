﻿namespace CookingSystem.Services
{
    using CookingSystem.Data.Models;
    using CookingSystem.Services.Models.Articles;
    using System.Collections.Generic;

    public interface IArticleService
    {
        ICollection<Article> Listing();
        void Create(Article model);
        Article FindById(int id);
        bool Exist(int id);
        void Delete(int id);
        void Edit(ArticleEditServiceModel model);
    }
}