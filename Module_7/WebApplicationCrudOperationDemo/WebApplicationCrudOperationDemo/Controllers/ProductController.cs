using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplicationCrudOperationDemo.Models;

namespace WebApplicationCrudOperationDemo.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my products.
    /// </summary>
    public class ProductController : Controller
    {
        string connectionString = @"Data Source = DESKTOP-HHFHACS; Initial Catalog = MvcCrudDB; Integrated Security =True";

        /// <summary>
        /// Gets a list of all the products.
        /// </summary>
        /// <returns>Return DataTable that contain all the products.</returns>
        [HttpGet]
        // GET: Product
        public ActionResult Index()
        {
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Product", sqlCon);
                sqlDa.Fill(dtblProduct);
            }
            return View(dtblProduct);
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
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string query = "INSERT INTO Product VALUES(@ProductName,@Price,@Count)";
                    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    sqlCmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                    sqlCmd.Parameters.AddWithValue("@Price", productModel.Price);
                    sqlCmd.Parameters.AddWithValue("@Count", productModel.Count);
                    sqlCmd.ExecuteNonQuery();
                }
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
            ProductModel productModel = new ProductModel();
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT * FROM Product Where ProductID = @ProductID ";
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("@ProductId", id);
                sqlDa.Fill(dtblProduct);
            }
            if(dtblProduct.Rows.Count==1)
            {
                productModel.ProductId = Convert.ToInt32(dtblProduct.Rows[0][0].ToString());
                productModel.ProductName = dtblProduct.Rows[0][1].ToString();
                productModel.Price = Convert.ToDecimal(dtblProduct.Rows[0][2].ToString());
                productModel.Count = Convert.ToInt32(dtblProduct.Rows[0][3].ToString());
                return View(productModel);
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
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, Count = @Count Where ProductId = @ProductId";
                SqlCommand sqlCmd = new SqlCommand(query,sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProductId",productModel.ProductId);
                sqlCmd.Parameters.AddWithValue("@ProductName",productModel.ProductName);
                sqlCmd.Parameters.AddWithValue("@Price",productModel.Price);
                sqlCmd.Parameters.AddWithValue("@Count",productModel.Count);
                sqlCmd.ExecuteNonQuery();
            }
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
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "DELETE FROM Product Where ProductId = @ProductId";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@ProductId", id);
                sqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}