using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCrudOperationDemo.App_Start
{
    public class Constants
    {
        public static string getConnectionString()
        {
            return @"Data Source = DESKTOP-HHFHACS; Initial Catalog = MvcCrudDB; Integrated Security =True";
        }
    }
}