﻿using System.ComponentModel.DataAnnotations;

namespace Abby_WebApp.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "Display order must be in range of 1-100!!!")]
        public int DisplayOrder { get; set; }

    }
}
