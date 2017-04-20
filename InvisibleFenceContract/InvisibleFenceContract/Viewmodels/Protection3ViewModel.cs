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

        public string OutdoorShieldPrice1
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
                OutdoorShieldPrice1 = value;
            }
        }

        public string OutdoorShieldPrice2
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
                OutdoorShieldPrice2 = value;
            }
        }

        public string IndoorShieldPrice1
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
                IndoorShieldPrice1 = value;
            }
        }

        public string IndoorShieldPrice2
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
                IndoorShieldPrice2 = value;
            }
        }

        public string MicroShieldPrice
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
                MicroShieldPrice = value;
            }
        }

        public string MicroShieldPrice2
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
                MicroShieldPrice2 = value;
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

        public string MicroLitePrice
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
                MicroLitePrice = value;
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
