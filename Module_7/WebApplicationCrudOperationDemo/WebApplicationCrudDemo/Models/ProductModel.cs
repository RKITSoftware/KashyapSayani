using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationCrudDemo.Models
{
    /// <summary>
    /// Represents One Specific ProductModel
    /// </summary>
    public class ProductModel
    {
            /// <summary>
            /// Id Of A Product
            /// </summary>
            public int ProductId { get; set; }

            /// <summary>
            /// Name Of The Product
            /// </summary>
            [Required(ErrorMessage = "Product Name is required."), DisplayName("Product Name"), StringLength(50, ErrorMessage = "Product Name's Length should be less than 50 CHARACTERS.")]
            public string ProductName { get; set; }

            /// <summary>
            /// Price Of The Product
            /// </summary>
            [Required(ErrorMessage = "Product Price is required."), Range(1, 100000, ErrorMessage = "Price must be less than 100000 and greater than 0.")]
            public decimal Price { get; set; }

            /// <summary>
            /// Count Of The Product
            /// </summary>
            [Required(ErrorMessage = "Product Count is required."), Range(1, 1000, ErrorMessage = "Count must be less than 1000 and greater than 0.")]
            public int Count { get; set; }
    }   
}
