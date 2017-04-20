using InvisibleFenceContract.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Viewmodels
{
    class Solutions5ViewModel : BindableBase
    {
        public Solutions5ViewModel()
        {
            loadPrices();
        }
        public List<Product> c_Prices
        {
            get;
            set;
        }

        public string SafetyWiredAddPrice
        {
            get
            {
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 76054)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
            }
            set
            {
                SafetyWiredAddPrice = value;
                OnPropertyChanged("SafetyWiredAddPrice");
            }
        }

        public string GPSAddPrice
        {
            get
            {
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 63088)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
            }
            set
            {
                GPSAddPrice = value;
                OnPropertyChanged("GPSAddPrice");
            }
        }

        //THISPART NUMBER IS WRONG!!!!!!!!!GET THE CORRECT PART NUMBER
        //Correct price wrong part!!!!
        public string SingleTrainPrice
        {
            get
            {
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 51264)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
            }
            set
            {
                SafetyWiredAddPrice = value;
                OnPropertyChanged("SingleTrainPrice");
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


