using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace omoore2_mission6.Models //This page explains the relationships for the category table
{
    public class Category
    {
       [Key]
       [Required]
       public int CategoryID { get; set; }
       public string CategoryName { get; set; }
    }
}
