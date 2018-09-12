using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsLibrary
{
    /// <summary>
    /// class to create product object after accessing database
    /// </summary>
    public class Product
    {
        public Product() { }
        public int ProductID { get; set; }
        public string ProdName { get; set; }
    }
}
