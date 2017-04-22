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
                return this.DoormanPetDoorPrice;
            }
            set
            {
                if (value != this.DoormanPetDoorPrice)
    
            {
                    this.DoormanPetDoorPrice = value;
                    OnPropertyChanged("DoormanPetDoorPrice");
                }
            }
        }


        public string DoormanPetDoorQuantity
        {
            get
            {
                return this.DoormanPetDoorQuantity.ToString();
            }
            set
            {
                if (value != this.DoormanPetDoorQuantity)
    
            {
                    this.DoormanPetDoorQuantity = value;
                    OnPropertyChanged("DoormanPetDoorQuantity");
                }
            }
        }

        public string DoormanPetDoorTotal
        {
            get
            {
                return this.DoormanPetDoorTotal;
            }
            set
            {
                if (value != this.DoormanPetDoorTotal)
    
            {
                    this.DoormanPetDoorTotal = value;
                    OnPropertyChanged("DoormanPetDoorTotal");
                }
            }
        }


        public string ShieldsCollarPrice
        {
            get
            {
                return this.ShieldsCollarPrice;
            }
            set
            {
                if (value != this.ShieldsCollarPrice)
    
            {
                    this.ShieldsCollarPrice = value;
                    OnPropertyChanged("ShieldsCollarPrice");
                }
            }
        }

        public string ShieldsCollarQuantity2
        {
            get
            {
                return this.ShieldsCollarQuantity2;
            }
            set
            {
                if (value != this.ShieldsCollarQuantity2)
    
            {
                    this.ShieldsCollarQuantity2 = value;
                    OnPropertyChanged("ShieldsCollarQuantity2");
                }
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
