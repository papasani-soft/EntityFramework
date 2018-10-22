using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;// this entity will provide we all Entity class DbContext,Database,Dbset 
namespace EntityCodeFirst1.Models
{
    // Context class will provide all the property and methods that r responsible for communicate with specific datasource
    public class NorthWindContext : DbContext
    {
        public NorthWindContext()
            :base("name=NorthWindConnection")
        {

        }
         
        public DbSet<Category> CategoriesTable { get; set; }
        public DbSet<Product> ProductsTable { get; set; }

    }
}