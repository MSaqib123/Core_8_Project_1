﻿using System.ComponentModel.DataAnnotations;

namespace Implement_Project.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
    }
}
