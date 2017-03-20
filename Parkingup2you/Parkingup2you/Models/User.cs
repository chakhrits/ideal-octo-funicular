using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parkingup2you.Models
{
    public class User
    {
        [Key]
        public int idUser { get; set; }
        [Required(ErrorMessage = "Input Firstname please...")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Input Lastname please...")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Input Username please...")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Input Password please...")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Input Idcard please...")]
        public string Idcard { get; set; }
        [Required(ErrorMessage = "Input Email please...")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Input Telephone please...")]
        public string Tel { get; set; }

    }
}