using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationCrudOperationDemo.App_Start;
using WebApplicationCrudOperationDemo.Models;

namespace WebApplicationCrudOperationDemo.BLProducts
{
    public class BLProduct
    {
        public DataTable getAllProducts()
        {
            DataTable objDtblProduct = new DataTable();
            using (SqlConnection objSqlCon = new SqlConnection(Constants.getConnectionString()))
            {
                objSqlCon.Open();
                SqlDataAdapter objSqlDa = new SqlDataAdapter("SELECT ProductId,ProductName,Price,Count FROM Product", objSqlCon);
                objSqlDa.Fill(objDtblProduct);
            }

            return objDtblProduct;
        }

        public void createProduct(ProductModel productModel)
        {
            using (SqlConnection objSqlCon = new SqlConnection(Constants.getConnectionString()))
            {
                objSqlCon.Open();
                string query = "INSERT INTO Product VALUES(@ProductName,@Price,@Count)";
                SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                objSqlCmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                objSqlCmd.Parameters.AddWithValue("@Price", productModel.Price);
                objSqlCmd.Parameters.AddWithValue("@Count", productModel.Count);
                objSqlCmd.ExecuteNonQuery();
            }
        }

        public DataTable getProductForEdit(int id)
        {
            DataTable objDtblProduct = new DataTable();
            using (SqlConnection objSqlCon = new SqlConnection(Constants.getConnectionString()))
            {
                objSqlCon.Open();
                string query = "SELECT ProductId,ProductName,Price,Count FROM Product Where ProductID = @ProductID ";
                SqlDataAdapter objSqlDa = new SqlDataAdapter(query, objSqlCon);
                objSqlDa.SelectCommand.Parameters.AddWithValue("@ProductId", id);
                objSqlDa.Fill(objDtblProduct);
            }

            return objDtblProduct;
        }

        public void editProduct(ProductModel productModel)
        {
            using (SqlConnection objSqlCon = new SqlConnection(Constants.getConnectionString()))
            {
                objSqlCon.Open();
                string query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, Count = @Count Where ProductId = @ProductId";
                SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                objSqlCmd.Parameters.AddWithValue("@ProductId", productModel.ProductId);
                objSqlCmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                objSqlCmd.Parameters.AddWithValue("@Price", productModel.Price);
                objSqlCmd.Parameters.AddWithValue("@Count", productModel.Count);
                objSqlCmd.ExecuteNonQuery();
            }
        }

        public void deleteProduct(int id)
        {
            using (SqlConnection objSqlCon = new SqlConnection(Constants.getConnectionString()))
            {
                objSqlCon.Open();
                string query = "DELETE FROM Product Where ProductId = @ProductId";
                SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                objSqlCmd.Parameters.AddWithValue("@ProductId", id);
                objSqlCmd.ExecuteNonQuery();
            }
        }
    }
}