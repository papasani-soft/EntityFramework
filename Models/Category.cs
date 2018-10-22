using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;// schema annotation is responsible for defining structure of table
using System.ComponentModel.DataAnnotations;// model annotations is used for defining model field  


namespace EntityCodeFirst1.Models
{
    [Table("tblCategories")]
    public class Category
    {
        [Key] // primary key CategoryId through this
      public int CategoryId { get; set; }
      public string CategoryName { get; set; }
    }
}