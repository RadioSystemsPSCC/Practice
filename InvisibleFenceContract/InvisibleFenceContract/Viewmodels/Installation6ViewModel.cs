using InvisibleFenceContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Services;
using InvisibleFenceContract.Viewmodels.Commands;
using System.Windows.Input;

namespace InvisibleFenceContract.Viewmodels
{
    class Installation6ViewModel : BindableBase
    {
        private ICommand submitCommand;

        public Order c_Order { get; set; }

        public Installation6ViewModel()
        {
            c_Order = Utility.Order;
            loadOrder();
        }


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

        public string OutdoorInstallCost
        {
            get
            {
                return "$" + this.c_Order.OutdoorInstallCost;
            }
            set
            {
                if (value != this.OutdoorInstallCost)

                {
                    this.c_Order.OutdoorInstallCost = Convert.ToDouble(value);
                    OnPropertyChanged("OutdoorInstallCost");
                }
            }
        }

        public string OutdoorXLoopPrice
        {
            get
            {
                return "$" + this.c_Order.OutdoorXLoopPrice;
            }
            set
            {
                if (value != this.OutdoorXLoopPrice)

                {
                    this.c_Order.OutdoorXLoopPrice = Convert.ToDouble(value);
                    OnPropertyChanged("OutdoorXLoopPrice");
                }
            }
        }

        public string OutdoorXLoopQuantity
        {
            get
            {
                return this.c_Order.OutdoorXLoopQuantity.ToString();

            }
            set
            {
                if (value != this.OutdoorXLoopQuantity)

                {
                    this.c_Order.OutdoorXLoopQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("OutdoorXLoopQuantity");
                }
            }
        }

        public string OutdoorXLoopTotal
        {
            get
            {
                return (Convert.ToDouble(this.c_Order.OutdoorXLoopPrice) * Convert.ToInt32(this.c_Order.OutdoorXLoopQuantity)).ToString();

            }
            set
            {
                if (value != this.OutdoorXLoopTotal)

                {
                    this.c_Order.OutdoorXLoopTotal = Convert.ToDouble(value);
                    OnPropertyChanged("OutdoorXLoopTotal");
                }
            }
        }

        public string IndoorXLoopPrice
        {
            get
            {
                return "$" + this.c_Order.IndoorXLoopPrice;
            }
            set
            {
                if (value != this.IndoorXLoopPrice)

                {
                    this.c_Order.IndoorXLoopPrice = Convert.ToDouble(value);
                    OnPropertyChanged("IndoorXLoopPrice");
                }
            }
        }

        public string IndoorXLoopQuantity
        {
            get
            {
                return this.c_Order.IndoorXLoopQuantity.ToString();
            }
            set
            {
                if (value != this.IndoorXLoopQuantity)

                {
                    this.c_Order.IndoorXLoopQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("IndoorXLoopQuantity");
                }
            }
        }


        public string IndoorXLoopTotal
        {
            get
            {
                return (Convert.ToDouble(this.c_Order.IndoorXLoopPrice) * Convert.ToInt32(this.c_Order.IndoorXLoopQuantity)).ToString();
            }
            set
            {
                if (value != this.IndoorXLoopTotal)

                {
                    this.c_Order.IndoorXLoopTotal = Convert.ToDouble(value);
                    OnPropertyChanged("IndoorXLoopTotal");
                }
            }
        }

        public string PetDoorInstallPrice
        {
            get
            {
                return "$" + this.c_Order.PetDoorInstallPrice;
            }
            set
            {
                if (value != this.PetDoorInstallPrice)

                {
                    this.c_Order.PetDoorInstallPrice = Convert.ToDouble(value);
                    OnPropertyChanged("PetDoorInstallPrice");
                }
            }
        }

        public string PetDoorInstallQuantity
        {
            get
            {

                    return this.c_Order.PetDoorInstallQuantity.ToString();

            }
            set
            {
                if (value != this.PetDoorInstallQuantity)

                {
                    this.c_Order.PetDoorInstallQuantity = Convert.ToInt32(value);
                    OnPropertyChanged("PetDoorInstallQuantity");
                }
            }
        }

        public string PetDoorInstallTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.PetDoorInstallPrice) * Convert.ToInt32(this.c_Order.PetDoorInstallQuantity)).ToString();
            }
            set
            {
                if (value != this.PetDoorInstallTotal)

                {
                    this.c_Order.PetDoorInstallTotal = Convert.ToDouble(value);
                    OnPropertyChanged("PetDoorInstallTotal");
                }
            }
        }

        public string SafetyTotal
        {
            get
            {
                return this.c_Order.SafetyTotal.ToString();
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
                return this.c_Order.ProtectionTotal.ToString();
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
                return this.c_Order.FreedomTotal.ToString();
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

        public string AddAPetTotal
        {
            get
            {
                return this.c_Order.AddAPetTotal.ToString();
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

        //Subtract discount from SolutionTotal
        public string SolutionTotal
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.SafetyTotal) + Convert.ToDouble(this.c_Order.ProtectionTotal) + Convert.ToDouble(this.c_Order.FreedomTotal) + Convert.ToDouble(this.c_Order.AddAPetTotal) + Convert.ToDouble(this.c_Order.OutdoorXLoopTotal) + Convert.ToDouble(this.c_Order.IndoorXLoopTotal));
            }
            set
            {
                if (value != this.SolutionTotal)

                {
                    this.c_Order.SolutionTotal = Convert.ToDouble(value);
                    OnPropertyChanged("SolutionTotal");
                }
            }
        }


        public string TaxRate
        {
            get
            {
                return this.c_Order.TaxRate.ToString();
            }
            set
            {
                if (value != this.TaxRate)

                {
                    this.c_Order.TaxRate = Convert.ToDouble(value);
                    OnPropertyChanged("TaxRate");
                }
            }
        }

        public string Tax
        {
            get
            {
                return "$" + (Convert.ToDouble(c_Order.SolutionTotal) * Convert.ToDouble(this.c_Order.TaxRate));
            }
            set
            {
                if (value != this.Tax)

                {
                    this.c_Order.Tax = Convert.ToDouble(value);
                    OnPropertyChanged("Tax");
                }
            }
        }


        public string InstallTotal
        {
            get
            {

                return "$" + (Convert.ToDouble(this.c_Order.OutdoorInstallCost) - Convert.ToDouble(this.c_Order.Discount) + Convert.ToDouble(this.c_Order.PetDoorInstallTotal) + Convert.ToDouble(c_Order.SingleTrainTotal));
            }
            set
            {
                if (value != this.InstallTotal)

                {
                    this.c_Order.InstallTotal = Convert.ToDouble(value);
                    OnPropertyChanged("InstallTotal");
                }
            }
        }

        public string Total
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.SolutionTotal) + Convert.ToDouble(this.c_Order.Tax) + Convert.ToDouble(this.c_Order.InstallTotal));
            }
            set
            {
                if (value != this.Total)

                {
                    this.c_Order.Total = Convert.ToDouble(value);
                    OnPropertyChanged("Total");
                }
            }
        }

        public string Deposit
        {
            get
            {
                return "$" + this.c_Order.Deposit;
            }
            set
            {
                if (value != this.Deposit)

                {
                    this.c_Order.Deposit = Convert.ToDouble(value);
                    OnPropertyChanged("Deposit");
                }
            }
        }

        public string Balance
        {
            get
            {
                return "$" + (Convert.ToDouble(this.c_Order.Total) - Convert.ToDouble(this.c_Order.Deposit));
            }
            set
            {
                if (value != this.Balance)

                {
                    this.c_Order.Balance = Convert.ToDouble(value);
                    OnPropertyChanged("Balance");
                }
            }
        }



        public void loadOrder()
        {
            c_Order = Services.Utility.Order;
        }

    }
}
