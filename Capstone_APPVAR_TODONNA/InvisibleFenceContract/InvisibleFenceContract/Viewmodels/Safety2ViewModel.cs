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
    class Safety2ViewModel : BindableBase
    {
        //string catchName = "";
        public Safety2ViewModel()
        {          
            safetyOrder();           
            loadPrices();
        }

        public void safetyOrder()
        {
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];
            order1.SafetyTotal = 10;
            Application.Current.Properties["myOrder"] = order1;

        }
       
        public List<Product> safetyPrices
        {
            get;
            set;
        }

        

        public string GpsLabel
        {
            get
            {
                for (int i = 0; i < safetyPrices.Count; i++)
                {
                    if (safetyPrices[i].PartID == 62139)
                    {
                        return "$" + safetyPrices[i].PartPrice;
                    }
                }
                return null;
            }
            set
            {
                GpsLabel = value;
                OnPropertyChanged("gpsLabel");
            }
        }

        public string BoundaryPlus
        {
            get
            {
                for (int i = 0; i < safetyPrices.Count; i++)
                {
                    if (safetyPrices[i].PartID == 62138)
                    {
                        return "$" + safetyPrices[i].PartPrice;
                    }
                }
                return null;
            }
            set
            {
                BoundaryPlus = value;
                OnPropertyChanged("boundaryPlus");
            }
        }

        public string DigitalTechnology
        {
            get
            {
                for (int i = 0; i < safetyPrices.Count; i++)
                {
                    if (safetyPrices[i].PartID == 62100)
                    {
                        return "$" + safetyPrices[i].PartPrice;
                    }
                }
                return null;
            }
            set
            {
                DigitalTechnology = value;
                OnPropertyChanged("digitalTechnology");
            }
        }

        public void loadPrices()
        {
            try
            {
                string file = File.ReadAllText(@"../../Resources/Products.JSON");
                List<Product> prices = JsonConvert.DeserializeObject<List<Product>>(file);
                safetyPrices = prices;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
