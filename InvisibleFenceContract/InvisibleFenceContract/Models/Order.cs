using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvisibleFenceContract.Models
{
    class Order : BindableBase
    {

        private string customerID;
        private string packageSelection;
        private double packagePrice;
        private double safetyTotal;
        private int outdoorShieldQuantity;
        private double outdoorShieldPrice1;
        private double outdoorShieldPrice2;
        private double outdoorShieldTotal;
        private double indoorShieldTotal;
        private int indoorShieldQuantity = 0;
        private double indoorShieldPrice1;
        private double indoorShieldPrice2;
        private int microShieldQuantity = 0;
        private double microShieldPrice1;
        private double microShieldPrice2;
        private double microShieldTotal = 0;
        private int shieldsCollarQuantity = 0;
        private double shieldsCollarPrice;
        private double shieldsCollarTotal;
        private int microLiteQuantity = 0;
        private double microLitePrice;
        private double microLiteTotal;
        private double protectionTotal;
        private int doormanPetDoorQuantity;
        private double doormanPetDoorPrice;
        private double doormanPetDoorTotal;
        private int shieldsCollarQuantity2;
        private double shieldsCollarPrice2;
        private double freedomTotal;
        private int safetyWiredAddQuantity;
        private double safetyWiredAddPrice;
        private double safetyWiredAddTotal;
        private int gPSAddQuantity;
        private double gPSAddPrice;
        private double gPSAddTotal;
        private int singleTrainQuantity;
        private double singleTrainPrice;
        private double singleTrainTotal;
        private string couponCode;
        private double discount;
        private double solutionsPageTotal;
        private double outdoorInstallCost;
        private int indoorXLoopQuantity;
        private double indoorXLoopPrice;
        private double indoorXLoopTotal;
        private int outdoorXLoopQuantity;
        private double outdoorXLoopPrice;
        private double outdoorXLoopTotal;
        private int petDoorInstallQuantity;
        private double petDoorInstallPrice;
        private double petDoorInstallTotal;
        private double installTotal;
        private double solutionTotal;
        private double taxRate;
        private double tax;
        private double total;
        private double deposit;
        private double balance;


        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
                OnPropertyChanged("CustomerID");
            }
        }

        //Command Parameter of radio button selected 
        public string PackageSelection
        {
            get
            {
                return packageSelection;
            }
            set
            {
                packageSelection = value;
                OnPropertyChanged("PackageSelection");
            }
        }

        //Price based on parameter chosen, 0 if none selected
        public double PackagePrice
        {
            get
            {
                return packagePrice;
            }
            set
            {
                packagePrice = value;
                OnPropertyChanged("PackagePrice");
            }
        }

        public double SafetyTotal
        {
            get
            {
                return safetyTotal;
            }
            set
            {
                safetyTotal = value;
                OnPropertyChanged("SafetyTotal");
            }
        }

        //Page 3
        public int OutdoorShieldQuantity
        {
            get
            {
                return outdoorShieldQuantity;
            }
            set
            {
                outdoorShieldQuantity = value;
                OnPropertyChanged("OutdoorShieldQuantity");
            }
        }

        public double OutdoorShieldPrice1
        {
            get
            {
                return outdoorShieldPrice1;
            }
            set
            {
                outdoorShieldPrice1 = value;
                OnPropertyChanged("OutdoorShieldPrice1");
            }
        }

        public double OutdoorShieldPrice2
        {
            get
            {
                return outdoorShieldPrice2;
            }
            set
            {
                outdoorShieldPrice2 = value;
                OnPropertyChanged("OutdoorShieldPrice2");
            }
        }

        public double OutdoorShieldTotal
        {
            get
            {
                return outdoorShieldTotal;
            }
            set
            {
                outdoorShieldTotal = value;
                OnPropertyChanged("OutdoorShieldTotal");
            }
        }

        public int IndoorShieldQuantity
        {
            get
            {
                return indoorShieldQuantity;

            }
            set
            {
                indoorShieldQuantity = value;
                OnPropertyChanged("IndoorShieldQuantity");
            }
        }

        public double IndoorShieldPrice1
        {
            get
            {
                return indoorShieldPrice1;
            }
            set
            {
                indoorShieldPrice1 = value;
                OnPropertyChanged("IndoorShieldPrice1");
            }
        }

        public double IndoorShieldPrice2
        {
            get
            {
                return indoorShieldPrice2;
            }
            set
            {
                indoorShieldPrice2 = value;
                OnPropertyChanged("IndoorShieldPrice2");
            }
        }

        public double IndoorShieldTotal
        {
            get
            {
                return IndoorShieldTotal;
            }
            set
            {
                indoorShieldTotal = value;
                OnPropertyChanged("IndoorShieldTotal");
            }

        }

        public int MicroShieldQuantity
        {
            get
            {
                return microShieldQuantity;
            }
            set
            {
                microShieldQuantity = value;
                OnPropertyChanged("MicroShieldQuantity");
            }
        }

        public double MicroShieldPrice1
        {
            get
            {
                return microShieldPrice1;
            }
            set
            {
                microShieldPrice1 = value;
                OnPropertyChanged("MicroShieldPrice1");
            }
        }

        public double MicroShieldPrice2
        {
            get
            {
                return microShieldPrice2;
            }
            set
            {
                microShieldPrice2 = value;
                OnPropertyChanged("MicrosShieldPrice2");
            }
        }

        public double MicroShieldTotal
        {
            get
            {
                return MicroShieldTotal;
            }
            set
            {
                MicroShieldTotal = value;
                OnPropertyChanged("MicroShieldTotal");
            }
        }

        public int ShieldsCollarQuantity
        {
            get
            {
                return shieldsCollarQuantity;
            }
            set
            {
                shieldsCollarQuantity = value;
                OnPropertyChanged("ShieldsCollarQuantity");
            }
        }

        public double ShieldsCollarPrice
        {
            get
            {
                return shieldsCollarPrice;
            }
            set
            {
                shieldsCollarPrice = value;
                OnPropertyChanged("ShieldsCollarPrice");
            }
        }

        public double ShieldsCollarTotal
        {
            get
            {
                return shieldsCollarTotal;
            }
            set
            {
                shieldsCollarTotal = value;
                OnPropertyChanged("ShieldsCollarTotal");
            }

        }

        public int MicroLiteQuantity
        {
            get
            {
                return microLiteQuantity;
            }
            set
            {
                microLiteQuantity = value;
                OnPropertyChanged("MicroLiteQuantity");
            }
        }

        public double MicroLitePrice
        {
            get
            {
                return microLitePrice;
            }
            set
            {
                microLitePrice = value;
                OnPropertyChanged("MicroLitePrice");
            }
        }

        public double MicroLiteTotal
        {
            get
            {
                return microLiteTotal;
            }
            set
            {
                microLiteTotal = value;
                OnPropertyChanged("MicroLiteTotal");
            }
        }

        public double ProtectionTotal
        {
            get
            {
                return protectionTotal;
            }
            set
            {
                protectionTotal = value;
                OnPropertyChanged("ProtectionTotal");
            }
        }

        //Freedom
        public int DoormanPetDoorQuantity
        {
            get
            {
                return doormanPetDoorQuantity;
            }
            set
            {
                doormanPetDoorQuantity = value;
                OnPropertyChanged("DoormanPetDoorQuantity");
            }
        }

        public double DoormanPetDoorPrice
        {
            get
            {
                return doormanPetDoorPrice;
            }
            set
            {
                doormanPetDoorPrice = value;
                OnPropertyChanged("DoormanPetDoorPrice");
            }
        }

        public double DoormanPetDoorTotal
        {
            get
            {
                return doormanPetDoorTotal;
            }
            set
            {
                doormanPetDoorTotal = value;
                OnPropertyChanged("DoormanPetDoorTotal");
            }
        }

        // access shieldsCollarTotal 
        public int ShieldsCollarQuantity2
        {
            get
            {
                return shieldsCollarQuantity2;
            }
            set
            {
                shieldsCollarQuantity2 = value;
                OnPropertyChanged("ShieldsCollarQuantity2");
            }
        }

        public double ShieldsCollarPrice2
        {
            get
            {
                return shieldsCollarPrice2;
            }
            set
            {
                shieldsCollarPrice2 = value;
                OnPropertyChanged("ShieldsCollarPrice2");
            }
        }





        //Solution 5
        //Add a Pet
        public int SafetyWiredAddQuantity
        {
            get
            {
                return safetyWiredAddQuantity;
            }
            set
            {
                safetyWiredAddQuantity = value;
                OnPropertyChanged("SafetyWiredAddQuantity");
            }
        }

        public double SafetyWiredAddPrice
        {
            get
            {
                return safetyWiredAddPrice;
            }
            set
            {
                safetyWiredAddPrice = value;
                OnPropertyChanged("SafetyWiredAddPrice");
            }
        }

        public double SafetyWiredAddTotal
        {
            get
            {
                return safetyWiredAddTotal;
            }
            set
            {
                safetyWiredAddTotal = value;
                OnPropertyChanged("SafetyWiredAddTotal");
            }
        }

        public double FreedomTotal
        {
            get
            {
                return freedomTotal;
            }
            set
            {
                freedomTotal = value;
                OnPropertyChanged("FreedomTotal");
            }
        }

        public int GPSAddQuantity
        {
            get
            {
                return gPSAddQuantity;
            }
            set
            {
                gPSAddQuantity = value;
                OnPropertyChanged("GPSAddQuantity");
            }
        }

        public double GPSAddPrice
        {
            get
            {
                return gPSAddQuantity;
            }
            set
            {
                gPSAddPrice = value;
                OnPropertyChanged("GPSAddPrice");
            }
        }

        public double GPSAddTotal
        {
            get
            {
                return gPSAddTotal;
            }
            set
            {
                gPSAddTotal = value;
                OnPropertyChanged("GPSAddTotal");
            }
        }

        public int SingleTrainQuantity
        {
            get
            {
                return singleTrainQuantity;
            }
            set
            {
                singleTrainQuantity = value;
                OnPropertyChanged("SingleTrainQuantity");
            }
        }

        public double SingleTrainPrice
        {
            get
            {
                return singleTrainPrice;
            }
            set
            {
                singleTrainPrice = value;
                OnPropertyChanged("SingleTrainPrice");
            }
        }

        public double SingleTrainTotal
        {
            get
            {
                return singleTrainTotal;
            }
            set
            {
                singleTrainTotal = value;
                OnPropertyChanged("SingleTrainTotal");
            }
        }

        public string CouponCode
        {
            get
            {
                return couponCode;
            }
            set
            {
                couponCode = value;
                OnPropertyChanged("CouponCode");
            }
        }

        public double Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
                OnPropertyChanged("Discount");
            }
        }

        public double SolutionsPageTotal
        {
            get
            {
                return solutionsPageTotal;
            }
            set
            {
                solutionsPageTotal = value;
                OnPropertyChanged("SolutionsPageTotal");
            }
        }

        //Installation
        public double OutdoorInstallCost
        {
            get
            {
                return outdoorInstallCost;
            }
            set
            {
                outdoorInstallCost = value;
                OnPropertyChanged("OutdoorInstallCost");
            }
        }

        public int IndoorXLoopQuantity
        {
            get
            {
                return indoorXLoopQuantity;
            }
            set
            {
                indoorXLoopQuantity = value;
            }
        }

        public double IndoorXLoopPrice
        {
            get
            {
                return indoorXLoopPrice;
            }
            set
            {
                indoorXLoopPrice = value;
                OnPropertyChanged("IndoorXLoopPrice");
            }
        }

        public double IndoorXLoopTotal
        {
            get
            {
                return indoorXLoopTotal;
            }
            set
            {
                indoorXLoopTotal = value;
                OnPropertyChanged("IndoorXLoopTotal");
            }
        }

        public int OutdoorXLoopQuantity
        {
            get
            {
                return outdoorXLoopQuantity;
            }
            set
            {
                outdoorXLoopQuantity = value;
                OnPropertyChanged("OutdoorXLoopQuantity");
            }
        }

        public double OutdoorXLoopPrice
        {
            get
            {
                return outdoorXLoopPrice;
            }
            set
            {
                outdoorXLoopPrice = value;
                OnPropertyChanged("OutdoorXLoopPrice");
            }
        }

        public double OutdoorXLoopTotal
        {
            get
            {
                return outdoorXLoopTotal;
            }
            set
            {
                outdoorXLoopTotal = value;
                OnPropertyChanged("OutdoorXLoopTotal");
            }
        }

        public int PetDoorInstallQuantity
        {
            get
            {
                return petDoorInstallQuantity;
            }
            set
            {
                petDoorInstallQuantity = value;
            }
        }

        public double PetDoorInstallPrice
        {
            get
            {
                return petDoorInstallPrice;
            }
            set
            {
                petDoorInstallPrice = value;
                OnPropertyChanged("PetDoorInstallPrice");
            }
        }

        public double PetDoorInstallTotal
        {
            get
            {
                return petDoorInstallTotal;
            }
            set
            {
                petDoorInstallTotal = value;
                OnPropertyChanged("PetDoorInstallTotal");
            }
        }

        public double InstallTotal
        {
            get
            {
                return installTotal;
            }
            set
            {
                installTotal = value;
                OnPropertyChanged("InstallTotal");
            }
        }

        //Subtotal previous totals into solution total
        public double SolutionTotal
        {
            get
            {
                return solutionTotal;
            }
            set
            {
                solutionTotal = value;
                OnPropertyChanged("SolutionTotal");
            }
        }

        public double TaxRate
        {
            get
            {
                return taxRate;
            }
            set
            {
                taxRate = value;
            }
        }

        public double Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
                OnPropertyChanged("Tax");
            }
        }

        public double Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }

        public double Deposit
        {
            get
            {
                return deposit;
            }
            set
            {
                deposit = value;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
                OnPropertyChanged("Balance");
            }
        }
    }
}




