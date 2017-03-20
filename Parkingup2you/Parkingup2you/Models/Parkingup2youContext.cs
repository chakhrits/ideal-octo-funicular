using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Parkingup2you.Models
{
    public class Parkingup2youContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Parkingup2youContext() : base("name=Parkingup2youContext")
        {
        }

        public System.Data.Entity.DbSet<Parkingup2you.Models.Parking> Parkings { get; set; }

        public System.Data.Entity.DbSet<Parkingup2you.Models.Device> Devices { get; set; }

        public System.Data.Entity.DbSet<Parkingup2you.Models.User> Users { get; set; }
    }
}
