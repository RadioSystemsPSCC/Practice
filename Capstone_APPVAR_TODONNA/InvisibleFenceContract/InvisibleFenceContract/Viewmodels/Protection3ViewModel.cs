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
            ProtectionOrder();          
        }

        public void ProtectionOrder()
        {
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];
            order1.OutdoorShieldTotal = 25;
            Application.Current.Properties["myOrder"] = order1;
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
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 29476)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 75857)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 52246)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 75858)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
                MShieldsUnit = value;
            }
        }

        public string MShieldsUnit2
        {
            get
            {
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 75859)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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

        public string MicroLiteComputerCollar
        {
            get
            {
                for (int i = 0; i < c_Prices.Count; i++)
                {
                    if (c_Prices[i].PartID == 29361)
                    {
                        return "$" + c_Prices[i].PartPrice;
                    }
                }
                return null;
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
