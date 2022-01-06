using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage ="Please Enter First Name")]
        public string FirstName { get; set; } = "";

        /// <summary>
        /// The user's last name
        /// </summary>
        [Required(ErrorMessage = "Please Enter Last Name")]
        public string LastName { get; set; } = "";
    }
}