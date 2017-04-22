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
            loadOrder();
        }

        public Order c_Order
        {
            get;
            set;
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
                return "$" + this.DoormanPetDoorPrice;
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
                return (Convert.ToDouble(this.DoormanPetDoorPrice) * Convert.ToInt32(this.DoormanPetDoorQuantity)).ToString();
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
                return "$" + this.ShieldsCollarPrice;
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

        public string ShieldsCollarTotal
        {
            get
            {
                return (Convert.ToDouble(this.ShieldsCollarTotal) + (Convert.ToDouble(this.ShieldsCollarPrice) * Convert.ToInt32(this.ShieldsCollarQuantity2))).ToString();
            }
            set
            {
                if (value != this.ShieldsCollarTotal)
                {
                    this.ShieldsCollarTotal = value;
                    OnPropertyChanged("ShieldsCollarTotal");
                }
            }
        }

        public string FreedomTotal
        {
            get
            {
                return (Convert.ToDouble(this.DoormanPetDoorTotal) + (Convert.ToDouble(this.ShieldsCollarTotal))).ToString();
            }
            set
            {
                if (value != this.FreedomTotal)
                {
                    this.FreedomTotal = value;
                    OnPropertyChanged("FreedomTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}
