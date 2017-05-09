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
using InvisibleFenceContract.Viewmodels.Commands;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels
{
    class ProductLookupViewModel : BindableBase
    {
        public ProductLookupViewModel()
        {
            loadPrices();
        }

        private ICommand submitCommand;

        public List<Product> c_Products
        {
            get;
            set;
        }

        public Order c_Order { get; set; }

        public ICommand SubmitCommand
        {
            get
            {
                if (submitCommand == null)
                {
                    submitCommand = new SubmitCommand(this.c_Order);
                }
                return submitCommand;
            }
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
