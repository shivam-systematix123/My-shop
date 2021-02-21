using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myshop.core.Models
{
    public class Product
    {
        public string Id { get; set; }
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Discription { get; set; }
        [Range(0,10000)]
        public Decimal Price { get; set; }
        public string catagory { get; set; }
        public string image { get; set; }

        public Product()
        {

            this.Id = Guid.NewGuid().ToString();
        }

    }
}
