using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GroceryItem
{
    [Key]
    public int ProductId { get; set; }
    public int CategoryId { get; set; } // This links to the Category table
    public string ProdName { get; set; } = string.Empty;
    public decimal Price { get; set; }
}