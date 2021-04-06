using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class ProductModel
    {

        [Required]
        [MaxLength(64)]
        [MinLength(3, ErrorMessage = "Name is too short. Needs ato be at least 3 characters")]
        public string Name { get; set; }
        [Required]
        [Range(0, float.MaxValue)]
        public float Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
