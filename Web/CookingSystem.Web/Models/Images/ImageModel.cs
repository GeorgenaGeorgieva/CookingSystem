﻿namespace CookingSystem.Web.Models.Images
{
    using Microsoft.AspNetCore.Http;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ImageModel
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
