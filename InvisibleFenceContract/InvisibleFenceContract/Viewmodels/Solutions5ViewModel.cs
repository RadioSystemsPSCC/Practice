using InvisibleFenceContract.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using InvisibleFenceContract.Services;
using InvisibleFenceContract.Viewmodels.Commands;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels
{
    class Solutions5ViewModel : BindableBase
    {
        public Solutions5ViewModel()
        {

            loadOrder();

        }

        private ICommand submitCommand;

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

        public string SafetyTotal
        {
            get
            {
                return "$" + this.c_Order.SafetyTotal;
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

        public string ProtectionTotal
        {
            get
            {
                return "$" + this.c_Order.ProtectionTotal;
            }
            set
            {
                if (value != this.ProtectionTotal)


                {
                    this.c_Order.ProtectionTotal = Convert.ToDouble(value);
                    OnPropertyChanged("ProtectionTotal");
                }
            }
        }


        public string FreedomTotal
        {
            get
            {
                return "$" + this.c_Order.FreedomTotal;
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

        public string SafetyWiredAddPrice
        {
            get
            {
                return "$" + this.c_Order.SafetyWiredAddPrice;
            }
            set
            {
                if (value != this.SafetyWiredAddPrice)


                {
                    this.c_Order.SafetyWiredAddPrice = Convert.ToDouble(value);
                    OnPropertyChanged("SafetyWiredAddPrice");
                }
            }
        }


        public string SafetyWiredAddQuantity
        {
            get
            {


                return this.c_Order.SafetyWiredAddQuantity.ToString();


            }
            set
            {
                if (value != this.SafetyWiredAddQuantity)


                {
                    this.c_Order.SafetyWiredAddQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("SafetyWiredAddQuantity");
                }
            }
        }

        public string SafetyWiredAddTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.SafetyWiredAddPrice) * Convert.ToInt32(this.c_Order.SafetyWiredAddQuantity)).ToString();
            }
            set
            {
                if (value != this.SafetyWiredAddTotal)


                {
                    this.c_Order.SafetyWiredAddTotal = Convert.ToDouble(value);
                    OnPropertyChanged("SafetyWiredAddTotal");
                }
            }
        }


        public string GPSAddPrice
        {
            get
            {
                return "$" + this.c_Order.GPSAddPrice;
            }
            set
            {
                if (value != this.GPSAddPrice)


                {
                    this.c_Order.GPSAddPrice = Convert.ToDouble(value);
                    OnPropertyChanged("GPSAddPrice");
                }
            }
        }

        public string GPSAddQuantity
        {
            get
            {

                return this.c_Order.GPSAddQuantity.ToString();

            }
            set
            {
                if (value != this.GPSAddQuantity)


                {
                    this.c_Order.GPSAddQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("GPSAddQuantity");
                }
            }
        }

        public string GPSAddTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.GPSAddPrice) * Convert.ToInt32(this.c_Order.GPSAddQuantity)).ToString();
            }
            set
            {
                if (value != this.GPSAddTotal)


                {
                    this.c_Order.GPSAddTotal = Convert.ToDouble(value);
                    OnPropertyChanged("GPSAddTotal");
                }
            }
        }

        //Does not include discount in total
        public string AddAPetTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.SafetyWiredAddTotal) + Convert.ToDouble(this.c_Order.GPSAddTotal)).ToString();
            }
            set
            {
                if (value != this.AddAPetTotal)

                {
                    this.c_Order.AddAPetTotal = Convert.ToDouble(value);
                    OnPropertyChanged("AddAPetTotal");
                }
            }
        }


        public string SingleTrainPrice
        {
            get
            {
                return "$" + this.c_Order.SingleTrainPrice;
            }
            set
            {
                if (value != this.SingleTrainPrice)
                {
                    this.c_Order.SingleTrainPrice = Convert.ToDouble(value);
                    OnPropertyChanged("SingleTrainPrice");
                }
            }
        }

        public string SingleTrainQuantity
        {
            get
            {
                return this.c_Order.SingleTrainQuantity.ToString();
            }
            set
            {
                if (value != this.SingleTrainQuantity)
                {
                    this.c_Order.SingleTrainQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("SingleTrainQuantity");
                }
            }
        }

        public string SingleTrainTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.SingleTrainPrice) * Convert.ToInt32(this.c_Order.SingleTrainQuantity)).ToString();
            }
            set
            {
                if (value != this.SingleTrainTotal)
                {
                    this.c_Order.SingleTrainTotal = Convert.ToDouble(value);
                    OnPropertyChanged("SingleTrainTotal");

                }
            }
        }

        public string CouponCode
        {
            get
            {
                return this.c_Order.CouponCode;
            }
            set
            {
                if (value != this.CouponCode)

                {
                    this.c_Order.CouponCode = value;
                    OnPropertyChanged("CouponCode");
                }
            }
        }

        public string Discount
        {
            get
            {
                return "$" + this.c_Order.Discount;
            }
            set
            {
                if (value != this.Discount)

                {
                    this.c_Order.Discount = Convert.ToDouble(value);
                    OnPropertyChanged("Discount");
                }
            }
        }


        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}


