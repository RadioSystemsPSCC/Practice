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
        
        public string DoormanPetDoorPrice
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
                DoormanPetDoorPrice = value;
            }
        }

        public string ShieldsCollarPrice
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
                ShieldsCollarPrice = value;
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
