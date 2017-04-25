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
using InvisibleFenceContract.Services;
using InvisibleFenceContract.Viewmodels.Commands;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels
{
    class Freedom4ViewModel : BindableBase
    {

        private string doormanPetDoorPrice;
        private string doormanPetDoorQuantity;
        private string doormanPetDoorTotal;
        private string shieldsCollarPrice;
        private string shieldsCollarQuantity2;
        private string shieldsCollarTotal;
        private string freedomTotal;

        private ICommand submitCommand;

     
        public Freedom4ViewModel()
        {

            loadOrder();
        }

        public Order c_Order { get; set; }

        public ICommand SubmitCommand
        {
            get
            {
                if (submitCommand == null)
                {
                    submitCommand = new SubmitCommand(this.c_Order);
                }
                return submitCommand;
            }
        }


        public string DoormanPetDoorPrice
        {
            get
            {
                return "$" + this.c_Order.DoormanPetDoorPrice;
            }
            set
            {
                if (value != this.DoormanPetDoorPrice)

                {
                    this.c_Order.DoormanPetDoorPrice = Convert.ToDouble(value);
                    OnPropertyChanged("DoormanPetDoorPrice");
                }
            }
        }


        public string DoormanPetDoorQuantity
        {
            get
            {
                return this.c_Order.DoormanPetDoorQuantity.ToString();
            }
            set
            {
                if (value != this.DoormanPetDoorQuantity)

                {
                    this.c_Order.DoormanPetDoorQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("DoormanPetDoorQuantity");
                }
            }
        }

        public string DoormanPetDoorTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.DoormanPetDoorPrice) * Convert.ToInt32(this.c_Order.DoormanPetDoorQuantity)).ToString();
            }
            set
            {
                if (value != this.DoormanPetDoorTotal)

                {
                    this.c_Order.DoormanPetDoorTotal = Convert.ToDouble(value);
                    OnPropertyChanged("DoormanPetDoorTotal");
                }
            }
        }


        public string ShieldsCollarPrice
        {
            get
            {
                return "$" + this.c_Order.ShieldsCollarPrice;
            }
            set
            {
                if (value != this.ShieldsCollarPrice)

                {
                    this.c_Order.ShieldsCollarPrice = Convert.ToDouble(value);
                    OnPropertyChanged("ShieldsCollarPrice");
                }
            }
        }

        public string ShieldsCollarQuantity2
        {
            get
            {
                return this.c_Order.ShieldsCollarQuantity2.ToString();
            }
            set
            {
                if (value != this.ShieldsCollarQuantity2)

                {
                    this.c_Order.ShieldsCollarQuantity2 = Convert.ToInt32(value);
                    OnPropertyChanged("ShieldCollarQuantity2");
                }
            }
        }

        public string ShieldsCollarTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.ShieldsCollarTotal) + (Convert.ToDouble(this.c_Order.ShieldsCollarPrice) * Convert.ToInt32(this.c_Order.ShieldsCollarQuantity2))).ToString();
            }
            set
            {
                if (value != this.ShieldsCollarTotal)
                {
                    this.c_Order.ShieldsCollarTotal = Convert.ToDouble(value);
                    OnPropertyChanged("ShieldsCollarTotal");
                }
            }
        }

        public string FreedomTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.DoormanPetDoorTotal) + (Convert.ToDouble(this.c_Order.ShieldsCollarTotal))).ToString();
            }
            set
            {
                if (value != this.FreedomTotal)
                {
                    this.c_Order.FreedomTotal = Convert.ToDouble(value);
                    OnPropertyChanged("FreedomTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Utility.Order;
        }

    }
}
