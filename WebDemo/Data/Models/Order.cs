using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public Customer Customer { get; set; }



        public ICollection<OrderProduct> OrderProducts { get; set; }

    }
}
