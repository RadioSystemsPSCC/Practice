using InvisibleFenceContract.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InvisibleFenceContract.Viewmodels
{
    class Solutions5ViewModel : BindableBase
    {
        public Solutions5ViewModel()
        {

            loadOrder();

        }

        public Order c_Order
        {
            get;
            set;
        }


        public string SafetyTotal
        {
            get
            {
                return this.SafetyTotal;
            }
            set
            {
                if (value != this.SafetyTotal)


                {
                    this.SafetyTotal = value;
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }

        public string ProtectionTotal
        {
            get
            {
                return this.ProtectionTotal;
            }
            set
            {
                if (value != this.ProtectionTotal)


                {
                    this.ProtectionTotal = value;
                    OnPropertyChanged("ProtectionTotal");
                }
            }
        }


        public string FreedomTotal
        {
            get
            {
                return this.FreedomTotal;
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

        public string SafetyWiredAddPrice
        {
            get
            {
                return "$" + this.SafetyWiredAddPrice;
            }
            set
            {
                if (value != this.SafetyWiredAddPrice)


                {
                    this.SafetyWiredAddPrice = value;
                    OnPropertyChanged("SafetyWiredAddPrice");
                }
            }
        }


        public string SafetyWiredAddQuantity
        {
            get
            {
                return this.SafetyWiredAddQuantity.ToString();
            }
            set
            {
                if (value != this.SafetyWiredAddQuantity)


                {
                    this.SafetyWiredAddQuantity = value;
                    OnPropertyChanged("SafetyWiredAddQuantity");
                }
            }
        }

        public string SafetyWiredAddTotal
        {
            get
            {
                return (Convert.ToDouble(this.SafetyWiredAddPrice) * Convert.ToInt32(this.SafetyWiredAddQuantity)).ToString();
            }
            set
            {
                if (value != this.SafetyWiredAddTotal)


                {
                    this.SafetyWiredAddTotal = value;
                    OnPropertyChanged("SafetyWiredAddTotal");
                }
            }
        }


        public string GPSAddPrice
        {
            get
            {
                return "$" + this.GPSAddPrice;
            }
            set
            {
                if (value != this.GPSAddPrice)


                {
                    this.GPSAddPrice = value;
                    OnPropertyChanged("GPSAddPrice");
                }
            }
        }

        public string GPSAddQuantity
        {
            get
            {
                return this.GPSAddQuantity.ToString();
            }
            set
            {
                if (value != this.GPSAddQuantity)


                {
                    this.GPSAddQuantity = value;
                    OnPropertyChanged("GPSAddQuantity");
                }
            }
        }

        public string GPSAddTotal
        {
            get
            {
                return (Convert.ToDouble(this.GPSAddPrice) * Convert.ToInt32(this.GPSAddQuantity)).ToString();
            }
            set
            {
                if (value != this.GPSAddTotal)


                {
                    this.GPSAddTotal = value;
                    OnPropertyChanged("GPSAddTotal");
                }
            }
        }

        public string SingleTrainPrice
        {
            get
            {
                return "$" + this.SingleTrainPrice;
            }
            set
            {
                if (value != this.SingleTrainPrice)
                {
                    this.SingleTrainPrice = value;
                    OnPropertyChanged("SingleTrainPrice");
                }
            }
        }

        public string SingleTrainQuantity
        {
            get
            {
                return this.SingleTrainQuantity;
            }
            set
            {
                if (value != this.SingleTrainQuantity)
                {
                    this.SingleTrainQuantity = value;
                    OnPropertyChanged("SingleTrainQuantity");
                }
            }
        }

        public string SingleTrainTotal
        {
            get
            {
                return (Convert.ToDouble(this.SingleTrainPrice) * Convert.ToInt32(this.SingleTrainQuantity)).ToString();
            }
            set
            {
                if (value != this.SingleTrainTotal)
                {
                    this.SingleTrainTotal = value;
                    OnPropertyChanged("SingleTrainTotal");

                }
            }
        }

        public string CouponCode
        {
            get
            {
                return this.CouponCode;
            }
            set
            {
                if (value != this.CouponCode)

                {
                    this.CouponCode = value;
                    OnPropertyChanged("CouponCode");
                }
            }
        }

        public string Discount
        {
            get
            {
                return "$" + this.Discount;
            }
            set
            {
                if (value != this.Discount)

                {
                    this.Discount = value;
                    OnPropertyChanged("Discount");
                }
            }
        }

        public string SolutionsPageTotal
        {
            get
            {
                return (Convert.ToDouble(SafetyWiredAddTotal) + Convert.ToDouble(GPSAddTotal) + Convert.ToDouble(SingleTrainTotal)).ToString();
            }
            set
            {
                if (value != this.SolutionsPageTotal)

                {
                    this.SolutionsPageTotal = value;
                    OnPropertyChanged("SolutionsPageTotal");
                }
            }
        }


        public void loadAppVariablesIntoOrder()
        {
            Order customerOrder = new Order();
            customerOrder.SafetyTotal = Convert.ToDouble(Application.Current.Properties["SafetyTotal"]);
            customerOrder.ProtectionTotal = Convert.ToDouble(Application.Current.Properties["ProtectionTotal"]);
            customerOrder.FreedomTotal = Convert.ToDouble(Application.Current.Properties["FreedomTotal"]);
            customerOrder.SafetyWiredAddPrice = Convert.ToDouble(Application.Current.Properties["SafetyWiredAddPrice"]);
            customerOrder.GPSAddPrice = Convert.ToDouble(Application.Current.Properties["GPSAddPrice"]);
            customerOrder.GPSAddQuantity = Convert.ToInt32(Application.Current.Properties["GPSAddQuantity"]);
            customerOrder.GPSAddTotal = Convert.ToInt32(Application.Current.Properties["GPSAddTotal"]);

        }

        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}


