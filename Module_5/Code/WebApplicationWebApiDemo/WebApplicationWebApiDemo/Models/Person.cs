using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWebApiDemo.Models
{
    /// <summary>
    /// Represents one specific person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// ID From SQL
        /// </summary>
        public int id { get; set; } = 0;

        /// <summary>
        /// The user's first name.
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// The user's last name
        /// </summary>
        public string LastNAme { get; set; } = "";
    }
}