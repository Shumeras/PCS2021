using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        [Required]
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

    }
}
