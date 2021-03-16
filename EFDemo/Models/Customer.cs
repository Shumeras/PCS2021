using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(64)]
        public string LastName { get; set; }

        [StringLength(256)]
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }


    }
}
