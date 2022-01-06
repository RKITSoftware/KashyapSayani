using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplicationCrudOperationDemo.Models;
using WebApplicationCrudOperationDemo.App_Start;

namespace WebApplicationCrudOperationDemo.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my products.
    /// </summary>
    public class ProductController : Controller
    {
        string connectionString = Constants.getConnectionString();

        public static object Constant { get; private set; }

        /// <summary>
        /// Gets a list of all the products.
        /// </summary>
        /// <returns>Return DataTable that contain all the products.</returns>
        [HttpGet]
        // GET: Product
        public ActionResult Index()
        {
            DataTable objDtblProduct = new DataTable();
            using (SqlConnection objSqlCon = new SqlConnection(connectionString))
            {
                objSqlCon.Open();
                SqlDataAdapter objSqlDa = new SqlDataAdapter("SELECT ProductId,ProductName,Price,Count FROM Product", objSqlCon);
                objSqlDa.Fill(objDtblProduct);
            }
            return View(objDtblProduct);
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
                using (SqlConnection objSqlCon = new SqlConnection(connectionString))
                {
                    objSqlCon.Open();
                    string query = "INSERT INTO Product VALUES(@ProductName,@Price,@Count)";
                    SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                    objSqlCmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                    objSqlCmd.Parameters.AddWithValue("@Price", productModel.Price);
                    objSqlCmd.Parameters.AddWithValue("@Count", productModel.Count);
                    objSqlCmd.ExecuteNonQuery();
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
            ProductModel objProductModel = new ProductModel();
            DataTable objDtblProduct = new DataTable();
            using (SqlConnection objSqlCon = new SqlConnection(connectionString))
            {
                objSqlCon.Open();
                string query = "SELECT ProductId,ProductName,Price,Count FROM Product Where ProductID = @ProductID ";
                SqlDataAdapter objSqlDa = new SqlDataAdapter(query, objSqlCon);
                objSqlDa.SelectCommand.Parameters.AddWithValue("@ProductId", id);
                objSqlDa.Fill(objDtblProduct);
            }
            if(objDtblProduct.Rows.Count==1)
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
            using (SqlConnection objSqlCon = new SqlConnection(connectionString))
            {
                objSqlCon.Open();
                string query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, Count = @Count Where ProductId = @ProductId";
                SqlCommand objSqlCmd = new SqlCommand(query,objSqlCon);
                objSqlCmd.Parameters.AddWithValue("@ProductId",productModel.ProductId);
                objSqlCmd.Parameters.AddWithValue("@ProductName",productModel.ProductName);
                objSqlCmd.Parameters.AddWithValue("@Price",productModel.Price);
                objSqlCmd.Parameters.AddWithValue("@Count",productModel.Count);
                objSqlCmd.ExecuteNonQuery();
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
            using (SqlConnection objSqlCon = new SqlConnection(connectionString))
            {
                objSqlCon.Open();
                string query = "DELETE FROM Product Where ProductId = @ProductId";
                SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                objSqlCmd.Parameters.AddWithValue("@ProductId", id);
                objSqlCmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}