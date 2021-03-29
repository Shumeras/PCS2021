using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]public string ProductName { get; set; }
        [BindProperty]public string ProductPrice { get; set; }
        [BindProperty]public string ProductImageUrl { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(string.IsNullOrWhiteSpace(ProductName) || float.Parse(ProductPrice) <= 0 )
            {
                return BadRequest();
            }

            using var dbc = new DataContext();

            dbc.Products.Add(new Product { 
                Name = ProductName,
                Price = float.Parse(ProductPrice),
                ImageURL = ProductImageUrl
            });
            dbc.SaveChangesAsync();

            return Page();

        }
    }
}
