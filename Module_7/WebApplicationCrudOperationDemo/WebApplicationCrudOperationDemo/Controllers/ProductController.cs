using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplicationCrudOperationDemo.Models;
using WebApplicationCrudOperationDemo.App_Start;
using WebApplicationCrudOperationDemo.BLProducts;

namespace WebApplicationCrudOperationDemo.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my products.
    /// </summary>
    public class ProductController : Controller
    {
        string connectionString = Constants.getConnectionString();
        BLProduct objBlProduct = new BLProduct();

        /// <summary>
        /// Gets a list of all the products.
        /// </summary>
        /// <returns>Return DataTable that contain all the products.</returns>
        [HttpGet]
        // GET: Product
        public ActionResult Index()
        {
            return View(objBlProduct.getAllProducts());
        }


        /// <summary>
        /// Get a new product to create.
        /// </summary>
        /// <returns>Return a new product model.</returns>
       [HttpGet]
        // GET: Product/Create
        public ActionResult Create()
        {
            return View(new ProductModel());
        }

        /// <summary>
        /// Create a product post method.
        /// </summary>
        /// <param name="productModel">Product that we want to create.</param>
        /// <returns>Redirect to Index Page.</returns>
        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel productModel)
        {
           if(ModelState.IsValid)
           {
                objBlProduct.createProduct(productModel);
                return RedirectToAction("Index");
           }

            return View(productModel);
        }

        /// <summary>
        /// Get product's details for edit.
        /// </summary>
        /// <param name="id">The unique identifier for this product.</param>
        /// <returns>Return data of product which we want to edit.</returns>
        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            ProductModel objProductModel = new ProductModel();
           
            DataTable objDtblProduct = objBlProduct.getProductForEdit(id);

            if (objDtblProduct.Rows.Count==1)
            {
                objProductModel.ProductId = Convert.ToInt32(objDtblProduct.Rows[0][0].ToString());
                objProductModel.ProductName = objDtblProduct.Rows[0][1].ToString();
                objProductModel.Price = Convert.ToDecimal(objDtblProduct.Rows[0][2].ToString());
                objProductModel.Count = Convert.ToInt32(objDtblProduct.Rows[0][3].ToString());
                return View(objProductModel);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        /// <summary>
        /// Edit the product's details.
        /// </summary>
        /// <param name="productModel">Produc which we want to edit.</param>
        /// <returns>Redirect to Index Page.</returns>
        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductModel productModel)
        {
            objBlProduct.editProduct(productModel);
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Delete product which we want to delete.
        /// </summary>
        /// <param name="id">The unique identifier for this product.</param>
        /// <returns>Redirect to Index Page.</returns>
        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            objBlProduct.deleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}