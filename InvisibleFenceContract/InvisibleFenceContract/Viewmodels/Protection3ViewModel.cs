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
    class Protection3ViewModel : BindableBase
    {
       private ICommand submitCommand;
        

        public Protection3ViewModel()
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

        public string OutdoorShieldPrice1
        {
            get
            {
                return "$" + this.c_Order.OutdoorShieldPrice1;
            }
            set
            {
                if (value != this.OutdoorShieldPrice1)

                {
                    this.c_Order.OutdoorShieldPrice1 = Convert.ToDouble(value);
                    OnPropertyChanged("OutdoorShieldPrice1");
                }
            }
        }

        public string OutdoorShieldPrice2
        {
            get
            {
                return "$" + this.c_Order.OutdoorShieldPrice2;
            }
            set
            {
                if (value != this.OutdoorShieldPrice2)
                {
                    this.c_Order.OutdoorShieldPrice2 = Convert.ToDouble(value);
                    OnPropertyChanged("OutdoorShieldPrice2");
                }
            }
        }

        public string OutdoorShieldQuantity
        {
            get
            {
                return this.c_Order.OutdoorShieldQuantity.ToString();
            }
            set
            {
                if (value != this.OutdoorShieldQuantity)


                {
                    this.c_Order.OutdoorShieldQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("OutdoorShieldQuantity");
                }
            }
        }



        public string OutdoorShieldTotal
        {
            get
            {
                return "$" + (((Convert.ToInt32(this.c_Order.OutdoorShieldQuantity) / 2) * Convert.ToDouble(this.c_Order.OutdoorShieldPrice2)) + ((Convert.ToInt32(this.c_Order.OutdoorShieldQuantity) % 2) * Convert.ToDouble(this.c_Order.OutdoorShieldPrice1))).ToString();
            }
            set
            {
                if (value != this.OutdoorShieldTotal)


                {
                    this.c_Order.OutdoorShieldTotal = Convert.ToDouble(value);
                    OnPropertyChanged("OutdoorShieldTotal");
                }
            }
        }

        public string IndoorShieldPrice1
        {
            get
            {
                return "$" + this.c_Order.IndoorShieldPrice1;
            }
            set
            {
                if (value != this.IndoorShieldPrice1)


                {
                    this.c_Order.IndoorShieldPrice1 = Convert.ToDouble(value);
                    OnPropertyChanged("IndoorShieldPrice1");
                }
            }
        }


        public string IndoorShieldPrice2
        {
            get
            {
                return "$" + this.c_Order.IndoorShieldPrice2;
            }
            set
            {
                if (value != this.IndoorShieldPrice2)


                {
                    this.c_Order.IndoorShieldPrice2 = Convert.ToDouble(value);
                    OnPropertyChanged("IndoorShieldPrice2");
                }
            }
        }

        public string IndoorShieldQuantity
        {
            get
            {
                return this.c_Order.IndoorShieldQuantity.ToString();
            }
            set
            {
                if (value != this.IndoorShieldQuantity)


                {
                    this.c_Order.IndoorShieldQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("IndoorShieldQuantity");
                }
            }
        }

        public string IndoorShieldTotal
        {
            get
            {
                return "$" + (((Convert.ToInt32(this.c_Order.IndoorShieldQuantity) / 2) * Convert.ToDouble(this.c_Order.IndoorShieldPrice2)) + ((Convert.ToInt32(this.c_Order.IndoorShieldQuantity) % 2) * Convert.ToDouble(this.c_Order.IndoorShieldPrice1))).ToString();
            }
            set
            {
                if (value != this.IndoorShieldTotal)


                {
                    this.c_Order.IndoorShieldTotal = Convert.ToDouble(value);
                    OnPropertyChanged("IndoorShieldTotal");
                }
            }
        }

        public string MicroShieldPrice1
        {
            get
            {
                return "$" + this.c_Order.MicroShieldPrice1;
            }
            set
            {
                if (value != this.MicroShieldPrice1)


                {
                    this.c_Order.MicroShieldPrice1 = Convert.ToDouble(value);
                    OnPropertyChanged("MicroShieldPrice1");
                }
            }
        }


        public string MicroShieldPrice2
        {
            get
            {
                return "$" + this.c_Order.MicroShieldPrice2;
            }
            set
            {
                if (value != this.MicroShieldPrice2)


                {
                    this.c_Order.MicroShieldPrice2 = Convert.ToDouble(value);
                    OnPropertyChanged("MicroShieldPrice2");
                }
            }
        }

        public string MicroShieldQuantity
        {
            get
            {
                return this.c_Order.MicroShieldQuantity.ToString();
            }
            set
            {
                if (value != this.MicroShieldQuantity)


                {
                    this.c_Order.MicroShieldQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("MicroShieldQuantity");
                }
            }
        }

        public string MicroShieldTotal
        {
            get
            {
                return "$" + (((Convert.ToInt32(this.c_Order.MicroShieldQuantity) / 2) * Convert.ToDouble(this.c_Order.MicroShieldPrice2)) + ((Convert.ToInt32(this.c_Order.MicroShieldQuantity) % 2) * Convert.ToDouble(this.c_Order.MicroShieldPrice1))).ToString();
            }
            set
            {
                if (value != this.MicroShieldTotal)


                {
                    this.c_Order.MicroShieldTotal = Convert.ToDouble(value);
                    OnPropertyChanged("MicroShieldTotal");
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

        public string ShieldsCollarQuantity
        {
            get
            {
                return this.c_Order.ShieldsCollarQuantity.ToString();
            }
            set
            {
                if (value != this.ShieldsCollarQuantity)


                {
                    this.c_Order.ShieldsCollarQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("ShieldsCollarQuantity");
                }
            }
        }

        public string ShieldsCollarTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.ShieldsCollarPrice) * Convert.ToInt32(this.c_Order.ShieldsCollarQuantity));
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


        public string MicroLitePrice
        {
            get
            {
                return "$" + this.c_Order.MicroLitePrice;
            }
            set
            {
                if (value != this.MicroLitePrice)


                {
                    this.c_Order.MicroLitePrice = Convert.ToDouble(value);
                    OnPropertyChanged("MicroLitePrice");
                }
            }
        }

        public string MicroLiteQuantity
        {
            get
            {
                return this.c_Order.MicroLiteQuantity.ToString();
            }
            set
            {
                if (value != this.MicroLiteQuantity)

                {
                    this.c_Order.MicroLiteQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("MicroLiteQuantity");
                }
            }
        }

        public string MicroLiteTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.MicroLitePrice) * Convert.ToInt32(this.c_Order.MicroLiteQuantity));
            }
            set
            {
                if (value != this.MicroLiteTotal)


                {
                    this.c_Order.MicroLiteTotal = Convert.ToDouble(value);
                    OnPropertyChanged("MicroLiteTotal");
                }
            }
        }

        public string ProtectionTotal
        {
            get
            {
                return (Convert.ToDouble(this.c_Order.OutdoorShieldTotal) + Convert.ToDouble(this.c_Order.IndoorShieldTotal) + Convert.ToDouble(this.c_Order.MicroShieldTotal) + Convert.ToDouble(this.c_Order.ShieldsCollarTotal) + Convert.ToDouble(this.c_Order.MicroLiteTotal)).ToString();
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


        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }


    }
}
