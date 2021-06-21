using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_Operation_ASP.Models
{
    public class CustometContext:DbContext

    {
        public CustometContext():base("CustomerContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}