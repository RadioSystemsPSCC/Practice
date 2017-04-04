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
    class Protection3ViewModel : BindableBase
    {
        public Protection3ViewModel()
        {
            loadPrices();
        }

        public List<Product> c_Prices
        {
            get;
            set;
        }

        public string OutdoorLabel1
        {
            get
            {
                return "$" + c_Prices[6].PartPrice;
            }
            set
            {
                OutdoorLabel1 = value;
            }
        }

        public string OutdoorLabel2
        {
            get
            {
                return "$" + c_Prices[15].PartPrice;
            }
            set
            {
                OutdoorLabel2 = value;
            }
        }

        public string IndoorShieldsLabel1
        {
            get
            {
                return "$" + c_Prices[8].PartPrice;
            }
            set
            {
                IndoorShieldsLabel1 = value;
            }
        }

        public string IndoorShieldsLabel2
        {
            get
            {
                return "$" + c_Prices[16].PartPrice;
            }
            set
            {
                IndoorShieldsLabel2 = value;
            }
        }

        public string MShieldsUnit
        {
            get
            {
                return "$" + c_Prices[7].PartPrice;
            }
            set
            {
                MShieldsUnit = value;
            }
        }

        public string MShieldsUnit2
        {
            get
            {
                return "$" + c_Prices[6].PartPrice;
            }
            set
            {
                MShieldsUnit2 = value;
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

        public string MicroLiteComputerCollar
        {
            get
            {
                return "$" + c_Prices[17].PartPrice;
            }
            set
            {
                MicroLiteComputerCollar = value;
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
