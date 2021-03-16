using System;
using System.Collections.Generic;

#nullable disable

namespace EFMSQLDemo.Model
{
    public partial class SalesByFilmCategory
    {
        public string Category { get; set; }
        public decimal? TotalSales { get; set; }
    }
}
