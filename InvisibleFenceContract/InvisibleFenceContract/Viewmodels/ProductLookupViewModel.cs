using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows;
using System.Data;

namespace InvisibleFenceContract.Viewmodels
{
    class ProductLookupViewModel : BindableBase
    {
        public ProductLookupViewModel()
        {
            loadPrices();
        }

        public List<Product> c_Products
        {
            get;
            set;
        }

        public void loadPrices()
        {
            try
            {
                string file = File.ReadAllText(@"../../Resources/Products.JSON");
                List<Product> products = JsonConvert.DeserializeObject<List<Product>>(file);
                c_Products = products;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
