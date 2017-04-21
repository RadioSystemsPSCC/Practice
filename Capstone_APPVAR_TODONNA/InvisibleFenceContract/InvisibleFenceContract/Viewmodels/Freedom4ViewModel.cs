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
        //double test = 0;
        //double test1 = 0;
        public Freedom4ViewModel()
        {           
            loadPrices();
            FreedomOrder();            
        }

        public void FreedomOrder()
        {
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];
            order1.FreedomTotal = 50;
            Application.Current.Properties["myOrder"] = order1;
           

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
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 29191)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 57594)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
