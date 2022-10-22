using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_DAL.Models
{
    public class ProductCategory
    {
        [Key]
        public int ProductID { get; set; }
        public string CategoryName { get; set; }




    }
}
