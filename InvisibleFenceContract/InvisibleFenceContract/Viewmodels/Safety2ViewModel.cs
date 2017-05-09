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
    public class Safety2ViewModel : BindableBase
    {


        private ICommand submitCommand;


        public Safety2ViewModel()
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

        public string GPSPrice
        {

            get
            {
                return "$" + this.c_Order.GPSPrice;
               
            }
            set
            {
                if (value != this.GPSPrice)

                {
                    this.c_Order.GPSPrice = Convert.ToDouble(value);
                    OnPropertyChanged("GPSPrice");
                }
            }
        }

        public string BoundaryPlusPrice
        {
            get
            {


                return "$" + this.c_Order.BoundaryPlusPrice;
               
            }


            set
            {
                if (value != this.BoundaryPlusPrice)
                {
                    this.c_Order.BoundaryPlusPrice = Convert.ToDouble(value);
                    OnPropertyChanged("boundaryPlus");
                }
            }
        }

        public string DigitalTechnologyPrice
        {
            get
            {
               
                return "$" + this.c_Order.DigitalTechnologyPrice;
            }



            set
            {
                if (value != this.PackageSelection)
                {
                    this.c_Order.DigitalTechnologyPrice = Convert.ToDouble(value);
                    OnPropertyChanged("DigitalTechnologyPrice");
                }
            }
        }

        public string PackageSelection
        {
            get
            {
                return this.c_Order.PackageSelection;
            }
            set
            {
                if (value != this.PackageSelection)
                {
                    this.c_Order.PackageSelection = value;
                    OnPropertyChanged("PackageSelection");
                }
            }
        }

        public string PackagePrice
        {
            get
            {
                return "$" + this.c_Order.PackagePrice;
            }
            set
            {
                if (value != this.PackagePrice)
                {
                    this.c_Order.PackagePrice = Convert.ToDouble(value);
                    OnPropertyChanged("PackagePrice");
                }
            }
        }

        public string SafetyTotal
        {
            get
            {
                return "$" + this.c_Order.PackagePrice;
            }
            set
            {
                if (value != this.SafetyTotal)
                {
                    this.c_Order.SafetyTotal = Convert.ToDouble(value);
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }

        public void loadOrder()
        {
            c_Order = Utility.Order;
        }


    }
}
