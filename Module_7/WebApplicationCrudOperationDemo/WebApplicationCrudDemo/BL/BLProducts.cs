using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using WebApplicationCrudDemo.Constants;
using WebApplicationCrudDemo.Models;

namespace WebApplicationCrudDemo.BL
{
    public class BLProducts
    {

        public List<ProductModel> convertDataTableToList(DataTable dataTable)
        {
            List<ProductModel> productList = new List<ProductModel>();

            productList = (from DataRow dr in dataTable.Rows
                           select new ProductModel()
                           {
                               ProductId = Convert.ToInt32(dr["ProductId"]),
                               ProductName = (string)dr["ProductName"],
                               Price = Convert.ToDecimal(dr["Price"]),
                               Count = Convert.ToInt32(dr["Count"])
                           }).ToList();

            return productList;
        }

        public List<ProductModel> getAllProducts()
        {
            DataTable objDtblProduct = new DataTable();
            using (SqlConnection objSqlCon = new SqlConnection(Constant.CONNECTION_STRING))
            {
                objSqlCon.Open();
                SqlDataAdapter objSqlDa = new SqlDataAdapter("SELECT ProductId,ProductName,Price,Count FROM Product", objSqlCon);
                objSqlDa.Fill(objDtblProduct);
            }

            return convertDataTableToList(objDtblProduct);
        }

        public string insertProduct(ProductModel productModel)
        {
               try
               {
                    using (SqlConnection objSqlCon = new SqlConnection(Constant.CONNECTION_STRING))
                    {
                        objSqlCon.Open();
                        string query = "INSERT INTO Product VALUES(@ProductName,@Price,@Count)";
                        SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                        objSqlCmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                        objSqlCmd.Parameters.AddWithValue("@Price", productModel.Price);
                        objSqlCmd.Parameters.AddWithValue("@Count", productModel.Count);

                        int success = objSqlCmd.ExecuteNonQuery();

                        if (success > 0)
                        {
                            return "Product Inserted Successfully";
                        }
                        else
                        {
                            return "Product Not Inserted Successfully";
                        }
                    }
                }
               catch(Exception e)
               {
                    return e.Message;
               }
        }

        public string updateProduct(ProductModel productModel)
        {
                try
                {
                    using (SqlConnection objSqlCon = new SqlConnection(Constant.CONNECTION_STRING))
                    {
                        objSqlCon.Open();
                        string query = "UPDATE Product SET ProductName = @ProductName, Price = @Price, Count = @Count Where ProductId = @ProductId";
                        SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                        objSqlCmd.Parameters.AddWithValue("@ProductId", productModel.ProductId);
                        objSqlCmd.Parameters.AddWithValue("@ProductName", productModel.ProductName);
                        objSqlCmd.Parameters.AddWithValue("@Price", productModel.Price);
                        objSqlCmd.Parameters.AddWithValue("@Count", productModel.Count);

                        int success = objSqlCmd.ExecuteNonQuery();

                        if (success > 0)
                        {
                            return "Product Updated Successfully";
                        }
                        else
                        {
                            return "Product Not Updated Successfully";
                        }
                    }
                }
                catch(Exception e)
                {
                    return e.Message;
                }
        }

        public string deleteProduct(int id)
        {
            try
            {
                using (SqlConnection objSqlCon = new SqlConnection(Constant.CONNECTION_STRING))
                {
                    objSqlCon.Open();
                    string query = "DELETE FROM Product Where ProductId = @ProductId";
                    SqlCommand objSqlCmd = new SqlCommand(query, objSqlCon);
                    objSqlCmd.Parameters.AddWithValue("@ProductId", id);

                    int success = objSqlCmd.ExecuteNonQuery();

                    if (success > 0)
                    {
                        return "Product Deleted Successfully";
                    }
                    else
                    {
                        return "Product Not Deleted Successfully";
                    }
                }
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
    }
}