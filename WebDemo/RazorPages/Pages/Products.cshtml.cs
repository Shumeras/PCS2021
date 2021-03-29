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
    public class ProductsModel : PageModel
    {

        public List<Product> Products{ get; set; }

        public void OnGet()
        {
            using var dbc = new DataContext();

            Products = dbc.Products.ToList();

        }
    }
}
