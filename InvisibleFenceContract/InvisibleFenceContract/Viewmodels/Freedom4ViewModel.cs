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
    class Freedom4ViewModel : BindableBase
    {
        public Freedom4ViewModel()
        {
            loadPrices();
        }

        public List<Product> c_Prices
        {
            get;
            set;
        }
        
        public string Doorman
        {
            get
            {
                return "$" + c_Prices[3].PartPrice;
            }
            set
            {
                Doorman = value;
            }
        }

        public string ShieldsComputerCollar
        {
            get
            {
                return "$" + c_Prices[9].PartPrice;
            }
            set
            {
                ShieldsComputerCollar = value;
            }
        }

        public void loadPrices()
        {
            try
            {
                string file = File.ReadAllText(@"../../Resources/Products.JSON");
                List<Product> prices = JsonConvert.DeserializeObject<List<Product>>(file);
                c_Prices = prices;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
