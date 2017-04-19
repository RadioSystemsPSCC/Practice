using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Views;
using InvisibleFenceContract.Viewmodels.Commands;
using System.Windows;
using System.IO;
using Newtonsoft.Json;
using InvisibleFenceContract.Models;

namespace InvisibleFenceContract.Viewmodels
{
    class MainWindowViewModel : BindableBase
    {

        public MainWindowViewModel()
        {
            NavCommand = new MyICommand<string>(OnNav);
            LoadProduct();
            SetApplication();
        }
        private StartViewModel startViewModel = new StartViewModel();
        private SelectCustomerViewModel selectCustomerViewModel = new SelectCustomerViewModel();

        private Contact1ViewModel contact1ViewModel = new Contact1ViewModel();
        private Safety2ViewModel safety2ViewModel = new Safety2ViewModel();
        private Protection3ViewModel protection3ViewModel = new Protection3ViewModel();
        private Freedom4ViewModel freedom4ViewModel = new Freedom4ViewModel();
        private Solutions5ViewModel solution5ViewModel = new Solutions5ViewModel();
        private Installation6ViewModel installation6ViewModel = new Installation6ViewModel();
        private Signature7ViewModel signature7ViewModel = new Signature7ViewModel();
        private ProductLookupViewModel productLookupViewModel = new ProductLookupViewModel();
        private BindableBase _CurrentViewModel;

        public int CusID;
        private string customerID;
        private string packageSelection;
        private double packagePrice;
        private double gPSPrice;
        private double boundaryPlusPrice;
        private double digitalTechnologyPrice;
        private double safetyTotal = 0;
        private int outdoorShieldQuantity = 0;
        private double outdoorShieldPrice1;
        private double outdoorShieldPrice2;
        private double outdoorShieldTotal = 0;
        private double indoorShieldTotal = 0;
        private int indoorShieldQuantity = 0;
        private double indoorShieldPrice1;
        private double indoorShieldPrice2;
        private int microShieldQuantity = 0;
        private double microShieldPrice1;
        private double microShieldPrice2;
        private double microShieldTotal = 0;
        private int shieldsCollarQuantity = 0;
        private double shieldsCollarPrice;
        private double shieldsCollarTotal = 0;
        private int microLiteQuantity = 0;
        private double microLitePrice;
        private double microLiteTotal = 0;
        private double protectionTotal = 0;
        private int doormanPetDoorQuantity = 0;
        private double doormanPetDoorPrice;
        private double doormanPetDoorTotal = 0;
        private int shieldsCollarQuantity2 = 0;
        private double freedomTotal = 0;
        private int safetyWiredAddQuantity = 0;
        private double safetyWiredAddPrice;
        private double safetyWiredAddTotal = 0;
        private int gPSAddQuantity = 0;
        private double gPSAddPrice;
        private double gPSAddTotal = 0;
        private int singleTrainQuantity = 0;
        private double singleTrainPrice;
        private double singleTrainTotal = 0;
        private string couponCode;
        private double discount;
        private double solutionsPageTotal = 0;
        private double outdoorInstallCost = 0;
        private int indoorXLoopQuantity = 0;
        private double indoorXLoopPrice;
        private double indoorXLoopTotal = 0;
        private int outdoorXLoopQuantity = 0;
        private double outdoorXLoopPrice;
        private double outdoorXLoopTotal = 0;
        private int petDoorInstallQuantity = 0;
        private double petDoorInstallPrice;
        private double petDoorInstallTotal = 0;
        private double installTotal = 0;
        private double solutionTotal = 0;
        private double taxRate = .0925;
        private double tax = 0;
        private double total = 0;
        private double deposit = 0;
        private double balance = 0;


        public BindableBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { SetProperty(ref _CurrentViewModel, value); }
        }

        public List<Product> AllPrices
        {
            get;
            set;
        }

        public MyICommand<string> NavCommand { get; private set; }

        private void OnNav(string destination)
        {

            switch (destination)
            {
                case "start":
                    CurrentViewModel = startViewModel;
                    break;
                case "selectCustomer":
                    CurrentViewModel = selectCustomerViewModel;
                    break;
                case "signature":
                    CurrentViewModel = signature7ViewModel;
                    break;
                case "installation":
                    CurrentViewModel = installation6ViewModel;
                    break;
                case "solutions":
                    CurrentViewModel = solution5ViewModel;
                    break;
                case "freedom":
                    CurrentViewModel = freedom4ViewModel;
                    break;
                case "protection":
                    CurrentViewModel = protection3ViewModel;
                    break;
                case "safety":
                    CurrentViewModel = safety2ViewModel;
                    break;
                case "productLookup":
                    CurrentViewModel = productLookupViewModel;
                    break;
                case "contact":
                default:
                    CurrentViewModel = contact1ViewModel;
                    break;
            }
            if (destination.Length < 1)
                CurrentViewModel = contact1ViewModel;
        }

        public void LoadProduct()
        {
            try
            {
                string file = File.ReadAllText(@"../../Resources/Products.JSON");
                List<Product> prices = JsonConvert.DeserializeObject<List<Product>>(file);
                AllPrices = prices;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
            for (int i = 0; i < AllPrices.Count; i++)
            {
                if (AllPrices[i].PartID == 62139 && gPSPrice == 0)
                {
                    gPSPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 62138 && boundaryPlusPrice == 0)
                {
                    boundaryPlusPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 62100 && digitalTechnologyPrice == 0)
                {
                    digitalTechnologyPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29476 && outdoorShieldPrice1 == 0)
                {
                    outdoorShieldPrice1 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75857 && outdoorShieldPrice2 == 0)
                {
                    outdoorShieldPrice2 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 52246 && indoorShieldPrice1 == 0)
                {
                    indoorShieldPrice1 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75858 && indoorShieldPrice2 == 0)
                {
                    indoorShieldPrice2 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 51264 && microShieldPrice1 == 0)
                {
                    microShieldPrice1 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75859 && microShieldPrice2 == 0)
                {
                    microShieldPrice2 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 57594 && shieldsCollarPrice == 0)
                {
                    shieldsCollarPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29361 && microLitePrice == 0)
                {
                    microLitePrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29191 && doormanPetDoorPrice == 0)
                {
                    doormanPetDoorPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 76054 && safetyWiredAddPrice == 0)
                {
                    safetyWiredAddPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 63088 && gPSAddPrice == 0)
                {
                    gPSAddPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29084 && singleTrainPrice == 0)
                {
                    singleTrainPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 28786 && outdoorXLoopPrice == 0)
                {
                    outdoorXLoopPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 28785 && indoorXLoopPrice == 0)
                {
                    indoorXLoopPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29193 && petDoorInstallPrice == 0)
                {
                    petDoorInstallPrice = AllPrices[i].PartPrice;
                }
            }

        }

        public void SetApplication()
        {

            Application.Current.Properties["Cus_ID"] = CusID;
            Application.Current.Properties["GPSPrice"] = gPSPrice;
            Application.Current.Properties["BoundaryPlusPrice"] = boundaryPlusPrice;
            Application.Current.Properties["DigitalTechnologyPrice"] = digitalTechnologyPrice;
            Application.Current.Properties["PackageSelection"] = packageSelection;
            Application.Current.Properties["PackagePrice"] = packagePrice;
            Application.Current.Properties["SafetyTotal"] = safetyTotal;
            Application.Current.Properties["OutdoorShieldQuantity"] = outdoorShieldQuantity;
            Application.Current.Properties["OutdoorShieldPrice1"] = outdoorShieldPrice1;
            Application.Current.Properties["OutdoorShieldPrice2"] = outdoorShieldPrice2;
            Application.Current.Properties["OutdoorShieldTotal"] = outdoorShieldTotal;
            Application.Current.Properties["IndoorShieldTotal"] = indoorShieldTotal;
            Application.Current.Properties["IndoorShieldQuantity"] = indoorShieldQuantity;
            Application.Current.Properties["IndoorShieldPrice1"] = indoorShieldPrice1;
            Application.Current.Properties["IndoorShieldPrice2"] = indoorShieldPrice2;
            Application.Current.Properties["MicroShieldQuantity"] = microShieldQuantity;
            Application.Current.Properties["MicroShieldPrice1"] = microShieldPrice1;
            Application.Current.Properties["MicroShieldPrice2"] = microShieldPrice2;
            Application.Current.Properties["MicroShieldTotal"] = microShieldTotal;
            Application.Current.Properties["ShieldsCollarQuantity"] = shieldsCollarQuantity;
            Application.Current.Properties["ShieldsCollarPrice"] = shieldsCollarPrice;
            Application.Current.Properties["ShieldsCollarTotal"] = shieldsCollarTotal;
            Application.Current.Properties["MicroLiteQuantity"] = microLiteQuantity;
            Application.Current.Properties["MicroLitePrice"] = microLitePrice;
            Application.Current.Properties["MicroLiteTotal"] = microLiteTotal;
            Application.Current.Properties["ProtectionTotal"] = protectionTotal;
            Application.Current.Properties["DoormanPetDoorQuantity"] = doormanPetDoorQuantity;
            Application.Current.Properties["DoormanPetDoorPrice"] = doormanPetDoorPrice;
            Application.Current.Properties["DoormanPetDoorTotal"] = doormanPetDoorTotal;
            Application.Current.Properties["ShieldsCollarQuantity2"] = shieldsCollarQuantity2;
            Application.Current.Properties["FreedomTotal"] = freedomTotal;
            Application.Current.Properties["SafetyWiredAddQuantity"] = safetyWiredAddQuantity;
            Application.Current.Properties["SafetyWiredAddPrice"] = safetyWiredAddPrice;
            Application.Current.Properties["SafetyWiredAddTotal"] = safetyWiredAddTotal;
            Application.Current.Properties["GPSAddQuantity"] = gPSAddQuantity;
            Application.Current.Properties["GPSAddPrice"] = gPSAddPrice;
            Application.Current.Properties["GPSAddTotal"] = gPSAddTotal;
            Application.Current.Properties["SingleTrainQuantity"] = singleTrainQuantity;
            Application.Current.Properties["SingleTrainPrice"] = singleTrainPrice;
            Application.Current.Properties["SingleTrainTotal"] = singleTrainTotal;
            Application.Current.Properties["CouponCode"] = couponCode;
            Application.Current.Properties["Discount"] = discount;
            Application.Current.Properties["SolutionsPageTotal"] = solutionsPageTotal;
            Application.Current.Properties["OutdoorInstallationCost"] = outdoorInstallCost;
            Application.Current.Properties["IndoorXLoopQuantity"] = indoorXLoopQuantity;
            Application.Current.Properties["IndoorXLoopPrice"] = indoorXLoopPrice;
            Application.Current.Properties["IndoorXLoopTotal"] = indoorXLoopTotal;
            Application.Current.Properties["OutdoorXLoopQuantity"] = outdoorXLoopQuantity;
            Application.Current.Properties["OutdoorXLoopPrice"] = outdoorXLoopPrice;
            Application.Current.Properties["OutdoorXLoopTotal"] = outdoorXLoopTotal;
            Application.Current.Properties["PetDoorInstallQuantity"] = petDoorInstallQuantity;
            Application.Current.Properties["PetDoorInstallPrice"] = petDoorInstallPrice;
            Application.Current.Properties["PetDoorInstallTotal"] = petDoorInstallTotal;
            Application.Current.Properties["InstallTotal"] = installTotal;
            Application.Current.Properties["SolutionTotal"] = solutionTotal;
            Application.Current.Properties["TaxRate"] = taxRate;
            Application.Current.Properties["Tax"] = tax;
            Application.Current.Properties["Total"] = total;
            Application.Current.Properties["Deposit"] = deposit;
            Application.Current.Properties["Balance"] = balance;
        }
    }
}
