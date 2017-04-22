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

namespace InvisibleFenceContract.Viewmodels
{
    class Protection3ViewModel : BindableBase
    {
       
      
        public Protection3ViewModel()
        {
            loadOrder();

        }

<<<<<<< HEAD
=======
        public Order c_Order
        {
            get;
            set;
        }


>>>>>>> master
        public string OutdoorShieldPrice1
        {
            get
            {
                return this.OutdoorShieldPrice1;
            }
            set
            {
                if (value != this.OutdoorShieldPrice1)

                {
                    this.OutdoorShieldPrice1 = value;
                    OnPropertyChanged("OutdoorShieldPrice1");
                }
            }
        }

        public string OutdoorShieldPrice2
        {
            get
            {
                return this.OutdoorShieldPrice2;
            }
            set
            {
                if (value != this.OutdoorShieldPrice2)
                {
                    this.OutdoorShieldPrice2 = value;
                    OnPropertyChanged("OutdoorShieldPrice2");
                }
            }
        }

        public string OutdoorShieldQuantity
        {
            get
            {
                return this.OutdoorShieldQuantity.ToString();
            }
            set
            {
                if (value != this.OutdoorShieldQuantity)


                {
                    this.OutdoorShieldQuantity = value;
                    OnPropertyChanged("OutdoorShieldQuantity");
                }
            }
        }

        public string OutdoorShieldTotal
        {
            get
            {
                return this.OutdoorShieldTotal;
            }
            set
            {
                if (value != this.OutdoorShieldTotal)


                {
                    this.OutdoorShieldTotal = value;
                    OnPropertyChanged("OutdoorShieldTotal");
                }
            }
        }

        public string IndoorShieldPrice1
        {
            get
            {
                return this.IndoorShieldPrice1;
            }
            set
            {
                if (value != this.IndoorShieldPrice1)


                {
                    this.IndoorShieldPrice1 = value;
                    OnPropertyChanged("IndoorShieldPrice1");
                }
            }
        }


        public string IndoorShieldPrice2
        {
            get
            {
                return this.IndoorShieldPrice2;
            }
            set
            {
                if (value != this.IndoorShieldPrice2)


                {
                    this.IndoorShieldPrice2 = value;
                    OnPropertyChanged("IndoorShieldPrice2");
                }
            }
        }

        public string IndoorShieldQuantity
        {
            get
            {
                return this.IndoorShieldQuantity.ToString();
            }
            set
            {
                if (value != this.IndoorShieldQuantity)


                {
                    this.IndoorShieldQuantity = value;
                    OnPropertyChanged("IndoorShieldQuantity");
                }
            }
        }

        public string IndoorShieldTotal
        {
            get
            {
                return this.IndoorShieldTotal;
            }
            set
            {
                if (value != this.IndoorShieldTotal)


                {
                    this.IndoorShieldTotal = value;
                    OnPropertyChanged("IndoorShieldTotal");
                }
            }
        }

        public string MicroShieldPrice1
        {
            get
            {
                return this.MicroShieldPrice1;
            }
            set
            {
                if (value != this.MicroShieldPrice1)


                {
                    this.MicroShieldPrice1 = value;
                    OnPropertyChanged("MicroShieldPrice1");
                }
            }
        }


        public string MicroShieldPrice2
        {
            get
            {
                return this.MicroShieldPrice2;
            }
            set
            {
                if (value != this.MicroShieldPrice2)


                {
                    this.MicroShieldPrice2 = value;
                    OnPropertyChanged("MicroShieldPrice2");
                }
            }
        }

        public string MicroShieldQuantity
        {
            get
            {
                return this.MicroShieldQuantity.ToString();
            }
            set
            {
                if (value != this.MicroShieldQuantity)


                {
                    this.MicroShieldQuantity = value;
                    OnPropertyChanged("MicroShieldQuantity");
                }
            }
        }

        public string MicroShieldTotal
        {
            get
            {
                return this.MicroShieldTotal;
            }
            set
            {
                if (value != this.MicroShieldTotal)


                {
                    this.MicroShieldTotal = value;
                    OnPropertyChanged("MicroShieldTotal");
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

        public string ShieldsCollarQuantity
        {
            get
            {
                return this.ShieldsCollarQuantity.ToString();
            }
            set
            {
                if (value != this.ShieldsCollarQuantity)


                {
                    this.ShieldsCollarQuantity = value;
                    OnPropertyChanged("ShieldsCollarQuantity");
                }
            }
        }

        public string ShieldsCollarTotal
        {
            get
            {
                return this.ShieldsCollarTotal;
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


        public string MicroLitePrice
        {
            get
            {
                return this.MicroLitePrice;
            }
            set
            {
                if (value != this.MicroLitePrice)


                {
                    this.MicroLitePrice = value;
                    OnPropertyChanged("MicroLitePrice");
                }
            }
        }

        public string MicroLiteQuantity
        {
            get
            {
                return this.MicroLiteQuantity;
            }
            set
            {
                if (value != this.MicroLiteQuantity)

                {
                    this.MicroLiteQuantity = value;
                    OnPropertyChanged("MicroLiteQuantity");
                }
            }
        }

        public string MicroLiteTotal
        {
            get
            {
                return this.MicroLiteTotal;
            }
            set
            {
                if (value != this.MicroLiteTotal)


                {
                    this.MicroLiteTotal = value;
                    OnPropertyChanged("MicroLiteTotal");
                }
            }
        }

        public void loadOrder()
        {
             c_Order = Utility.Order;
        }



    }
}
