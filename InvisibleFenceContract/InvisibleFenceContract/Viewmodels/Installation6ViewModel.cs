using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Viewmodels
{
    class Installation6ViewModel : BindableBase
    {
        public string OutdoorInstallCost
        {
            get
            {
                return this.OutdoorInstallCost;
            }
            set
            {
                if (value != this.OutdoorInstallCost)
    
            {
                    this.OutdoorInstallCost = value;
                    OnPropertyChanged("OutdoorInstallCost");
                }
            }
        }

        public string OutdoorXLoopPrice
        {
            get
            {
                return this.OutdoorXLoopPrice;
            }
            set
            {
                if (value != this.OutdoorXLoopPrice)
    
            {
                    this.OutdoorXLoopPrice = value;
                    OnPropertyChanged("OutdoorXLoopPrice");
                }
            }
        }

        public string OutdoorXLoopQuantity
        {
            get
            {
                return this.OutdoorXLoopQuantity.ToString();
            }
            set
            {
                if (value != this.OutdoorXLoopQuantity)
    
            {
                    this.OutdoorXLoopQuantity = value;
                    OnPropertyChanged("OutdoorXLoopQuantity");
                }
            }
        }

        public string OutdoorXLoopTotal
        {
            get
            {
                return this.OutdoorXLoopTotal;
            }
            set
            {
                if (value != this.OutdoorXLoopTotal)
    
            {
                    this.OutdoorXLoopTotal = value;
                    OnPropertyChanged("OutdoorXLoopTotal");
                }
            }
        }

        public string IndoorXLoopPrice
        {
            get
            {
                return this.IndoorXLoopPrice;
            }
            set
            {
                if (value != this.IndoorXLoopPrice)
    
            {
                    this.IndoorXLoopPrice = value;
                    OnPropertyChanged("IndoorXLoopPrice");
                }
            }
        }

        public string IndoorXLoopQuantity
        {
            get
            {
                return this.IndoorXLoopQuantity;
            }
            set
            {
                if (value != this.IndoorXLoopQuantity)
    
            {
                    this.IndoorXLoopQuantity = value;
                    OnPropertyChanged("IndoorXLoopQuantity");
                }
            }
        }


        public string IndoorXLoopTotal
        {
            get
            {
                return this.IndoorXLoopTotal;
            }
            set
            {
                if (value != this.IndoorXLoopTotal)
    
            {
                    this.IndoorXLoopTotal = value;
                    OnPropertyChanged("IndoorXLoopTotal");
                }
            }
        }

        public string PetDoorInstallPrice
        {
            get
            {
                return this.PetDoorInstallPrice;
            }
            set
            {
                if (value != this.PetDoorInstallPrice)
    
            {
                    this.PetDoorInstallPrice = value;
                    OnPropertyChanged("PetDoorInstallPrice");
                }
            }
        }

        public string PetDoorInstallQuantity
        {
            get
            {
                return this.PetDoorInstallQuantity.ToString();
            }
            set
            {
                if (value != this.PetDoorInstallQuantity)
    
            {
                    this.PetDoorInstallQuantity = value;
                    OnPropertyChanged("PetDoorInstallQuantity");
                }
            }
        }

        public string PetDoorInstallTotal
        {
            get
            {
                return this.PetDoorInstallTotal;
            }
            set
            {
                if (value != this.PetDoorInstallTotal)
    
            {
                    this.PetDoorInstallTotal = value;
                    OnPropertyChanged("PetDoorInstallTotal");
                }
            }
        }

        public string SolutionTotal
        {
            get
            {
                return this.SolutionTotal;
            }
            set
            {
                if (value != this.SolutionTotal)
    
            {
                    this.SolutionTotal = value;
                    OnPropertyChanged("SolutionTotal");
                }
            }
        }


        public string TaxRate
        {
            get
            {
                return this.TaxRate;
            }
            set
            {
                if (value != this.TaxRate)

                {
                    this.TaxRate = value;
                    OnPropertyChanged("TaxRate");
                }
            }
        }

        public string Tax
        {
            get
            {
                return this.Tax;
            }
            set
            {
                if (value != this.Tax)
    
            {
                    this.Tax = value;
                    OnPropertyChanged("Tax");
                }
            }
        }


        public string InstallTotal
        {
            get
            {
                return this.InstallTotal;
            }
            set
            {
                if (value != this.InstallTotal)
    
            {
                    this.InstallTotal = value;
                    OnPropertyChanged("InstallTotal");
                }
            }
        }

        public string Total
        {
            get
            {
                return this.Total;
            }
            set
            {
                if (value != this.Total)
    
            {
                    this.Total = value;
                    OnPropertyChanged("Total");
                }
            }
        }

        public string Deposit
        {
            get
            {
                return this.Deposit;
            }
            set
            {
                if (value != this.Deposit)
    
            {
                    this.Deposit = value;
                    OnPropertyChanged("Deposit");
                }
            }
        }

        public string Balance
        {
            get
            {
                return this.Balance;
            }
            set
            {
                if (value != this.Balance)
    
            {
                    this.Balance = value;
                    OnPropertyChanged("Balance");
                }
            }
        }


    }
}
