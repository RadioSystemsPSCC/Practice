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
                return "$" + Application.Current.Properties["SafetyTotal"];
            }
            set
            {
                if (SafetyTotal != value)
                {
                    Application.Current.Properties["SafetyTotal"] = value;
                    OnPropertyChanged("SafetyTotal");
                }
            }
        }


        public string ProtectionTotal
        {
            get
            {
                return "$" + Application.Current.Properties["ProtectionTotal"];
            }
            set
            {
                if (ProtectionTotal != value)
                {
                    Application.Current.Properties["ProtectionTotal"] = value;
                    OnPropertyChanged("ProtectionTotal");
                }
            }
        }
        public string FreedomTotal
        {
            get
            {
                return "$" + Application.Current.Properties["FreedomTotal"];
            }
            set
            {
                if (FreedomTotal != value)
                {
                    Application.Current.Properties["FreedomTotal"] = value;
                    OnPropertyChanged("FreedomTotal");
                }
            }
        }

        public string SafetyWiredAddPrice
        {
            get
            {
                return "$" + Application.Current.Properties["SafetyWiredAddPrice"];
            }
            set
            {
                if (SafetyWiredAddPrice != value)
                {
                    Application.Current.Properties["SafetyWiredAddPrice"] = value;
                    OnPropertyChanged("SafetyWiredAddPrice");
                }
            }
        }

        public string SafetyWiredAddQuantity
        {
            get
            {
                return Application.Current.Properties["SafetyWiredAddQuantity"].ToString();
            }
            set
            {
                if (SafetyWiredAddQuantity != value)
                {
                    Application.Current.Properties["SafetyWiredAddQuantity"] = value;
                    OnPropertyChanged("SafetyWiredAdd");
                }
            }
        }

        public string SafetyWiredAddTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(Application.Current.Properties["SafetyWiredAddPrice"]) * Convert.ToDouble(Application.Current.Properties["SafetyWiredAddQuantity"]));
            }
            set
            {
                Application.Current.Properties["SafetyWiredAddTotal"] = value;
                OnPropertyChanged("SafetyWiredAddTotal");
            }

        }

        public double GPSAddPrice
        {
            get
            {
                return Convert.ToDouble(Application.Current.Properties["GPSAddPrice"]);
            }
            set
            {
                Application.Current.Properties["GPSAddPrice"] = value;
                OnPropertyChanged("GPSAddPrice");
            }
        }

        public double GPSAddTotal
        {
            get
            {
                return 3.0; /*+ (this.GPSAddQuantity * this.GPSAddPrice)*/
            }
            set
            {
                if (this.GPSAddTotal != value)
                {
                    this.GPSAddTotal = value;
                    OnPropertyChanged("GPSAddTotal");
                }
            }
        }

        public double GPSAddQuantity
        {
            get
            {
                return Convert.ToDouble(Application.Current.Properties["GPSAddQuantity"]);
            }
            set
            {
                Application.Current.Properties["GPSAddQuantity"] = value;

                OnPropertyChanged("GPSAddQuantity");
            }
        }

        //THISPART NUMBER IS WRONG!!!!!!!!!GET THE CORRECT PART NUMBER
        //Correct price wrong part!!!!
        public string SingleTrainPrice
        {
            get
            {
                return "$" + Application.Current.Properties["SingleTrainPrice"];
            }
            set
            {
                Application.Current.Properties["SingleTrainPrice"] = value;
                OnPropertyChanged("SingleTrainPrice");
            }
        }

        public string SingleTrainQuantity
        {
            get
            {
                return Application.Current.Properties["SingleTrainQuantity"].ToString();
            }
            set
            {
                Application.Current.Properties["SingleTrainQuantity"] = value;
                OnPropertyChanged("SingleTrainQuantity");
            }
        }
        public string SingleTrainTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(Application.Current.Properties["SingleTrainPrice"]) * Convert.ToDouble(Application.Current.Properties["SingleTrainQuantity"]));
            }
            set
            {
                Application.Current.Properties["SingleTrainTotal"] = value;
                OnPropertyChanged("SingleTrainTotal");
            }
        }

        public string CouponCode
        {
            get
            {
                if (Application.Current.Properties["CouponCode"] == null)
                {
                    return "none";
                }
                else
                {
                    return Application.Current.Properties["CouponCode"].ToString();
                }

            }
            set
            {
                Application.Current.Properties["CouponCode"] = value;
                OnPropertyChanged("CouponCode");
            }
        }

        public string Discount
        {
            get
            {
                return "$" + (Convert.ToDouble(Application.Current.Properties["Discount"]));
            }
            set
            {
                Application.Current.Properties["Discount"] = value;
                OnPropertyChanged("Discount");
            }
        }

        public string SolutionsPageTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(Application.Current.Properties["SafetyWiredAddTotal"]) + Convert.ToDouble(Application.Current.Properties["GPSAddTotal"]) + Convert.ToDouble(Application.Current.Properties["SingleTrainTotal"]));
            }
            set
            {
                Application.Current.Properties["SolutionsPageTotal"] = value;
                OnPropertyChanged("SolutionsPageTotal");
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


