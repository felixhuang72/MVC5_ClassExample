using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UpdateProductStockVM
    {
        public int ProductId { get; set; }
        public decimal Stock { get; set; }
    }
}