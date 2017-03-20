using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parkingup2you.Models
{
    public class Parking
    {

        [Key]
        public int idBlock { get; set; }
        public string Block { get; set; }
        public string Status { get; set; }
    }
}