using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
