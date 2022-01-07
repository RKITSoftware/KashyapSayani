using System.Web.Http;
using WebApplicationCrudDemo.BL;
using WebApplicationCrudDemo.Constants;
using WebApplicationCrudDemo.Models;

namespace WebApplicationCrudDemo.Controllers
{

    /// <summary>
    /// This is where I give you all the information about my products.
    /// </summary>
    public class ProductController : ApiController
    {
        string connectionString = Constant.CONNECTION_STRING;
        BLProducts objBlProduct = new BLProducts();

        /// <summary>
        /// Gets a list of all the products.
        /// </summary>
        /// <returns>Return DataTable that contain all the products.</returns>
        [Route("api/Products/getAllProducts")]
        [HttpGet]
        public IHttpActionResult getAllProduct()
        {
            return Ok(objBlProduct.getAllProducts());
        }

        /// <summary>
        /// Create a product post method.
        /// </summary>
        /// <param name="productModel">Product that we want to create.</param>
        /// <returns>Redirect to Index Page.</returns>
        [Route("api/Product/insertProduct")]
        [HttpPost]
        public IHttpActionResult insertProduct([FromBody] ProductModel productModel)
        {

            return Ok(objBlProduct.insertProduct(productModel));
        }

        /// <summary>
        /// Edit the product's details.
        /// </summary>
        /// <param name="productModel">Produc which we want to edit.</param>
        /// <returns>Redirect to Index Page.</returns>
        [Route("api/Product/updateProduct")]
        [HttpPost]
        public IHttpActionResult updateProduct([FromBody] ProductModel productModel)
        {
            return Ok(objBlProduct.updateProduct(productModel));
        }


        /// <summary>
        /// Delete product which we want to delete.
        /// </summary>
        /// <param name="id">The unique identifier for this product.</param>
        /// <returns>Redirect to Index Page.</returns>
        [Route("api/Product/deleteProduct")]
        [HttpGet]
        public IHttpActionResult deleteProduct(int id)
        {
            return Ok(objBlProduct.deleteProduct(id));
        }
    }
}
