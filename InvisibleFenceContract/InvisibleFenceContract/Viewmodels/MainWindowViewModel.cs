using System;
using System.Collections.Generic;
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
            Application.Current.Properties["Cus_ID"] = "23";
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


        private string packageSelection;
        private double packagePrice;
        private double safetyTotal = 0;
        private int outdoorShieldQuantity = 0;
        private double outdoorShieldTotal = 0;
        private double indoorShieldTotal = 0;
        private int indoorShieldQuantity = 0;
        private int microShieldQuantity = 0;
        private double microShieldTotal = 0;
        private int shieldsCollarQuantity = 0;
        private double shieldsCollarTotal = 0;
        private int microLiteQuantity = 0;
        private double microLiteTotal = 0;
        private double protectionTotal = 0;
        private int doormanPetDoorQuantity = 0;
        private double doormanPetDoorTotal = 0;
        private int shieldsCollarQuantity2 = 0;
        private double freedomTotal = 0;
        private int safetyWiredAddQuantity = 0;
        private double safetyWiredAddTotal = 0;
        private int gPSAddQuantity = 0;
        private double gPSAddTotal = 0;
        private int singleTrainQuantity = 0;
        private double singleTrainTotal = 0;
        private string couponCode;
        private double discount;
        private double solutionsPageTotal = 0;
        private double outdoorInstallCost = 0;
        private int indoorXLoopQuantity = 0;
        private double indoorXLoopTotal = 0;
        private int outdoorXLoopQuantity = 0;
        private double outdoorXLoopTotal = 0;
        private int petDoorInstallQuantity = 0;
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
                case "contact":
                    contact1ViewModel.CusID = Convert.ToInt32(Application.Current.Properties["Cus_ID"]);
                    CurrentViewModel = contact1ViewModel;
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
                default:
                    CurrentViewModel = selectCustomerViewModel;
                    break;
            }

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
                if (AllPrices[i].PartID == 62139)
                {
                    Application.Current.Properties["GPSPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 62138)
                {

                    Application.Current.Properties[" BoundaryPlusPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 62100)
                {

                    Application.Current.Properties["DigitalTechnologyPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29476)
                {

                    Application.Current.Properties["OutdoorShieldPrice1"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75857)
                {

                    Application.Current.Properties["OutdoorShieldPrice2"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 52246)
                {

                    Application.Current.Properties["IndoorShieldPrice1"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75858)
                {

                    Application.Current.Properties["IndoorShieldPrice2"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 51264)
                {
                    Application.Current.Properties["MicroShieldPrice1"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75859)
                {
                    Application.Current.Properties["MicroShieldPrice2"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 57594)
                {

                    Application.Current.Properties["ShieldsCollarPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29361)
                {

                    Application.Current.Properties["MicroLitePrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29191)
                {

                    Application.Current.Properties["DoormanPetDoorPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 76054)
                {

                    Application.Current.Properties["SafetyWiredAddPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 63088)
                {

                    Application.Current.Properties["GPSAddPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29084)
                {

                    Application.Current.Properties["SingleTrainPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 28786)
                {
                    Application.Current.Properties["OutdoorXLoopPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 28785)
                {

                    Application.Current.Properties["IndoorXLoopPrice"] = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29193)
                {

                    Application.Current.Properties["PetDoorInstallPrice"] = AllPrices[i].PartPrice;
                }
            }

        }



        public void SetApplication()
        {

            Application.Current.Properties["PackageSelection"] = packageSelection;
            Application.Current.Properties["PackagePrice"] = packagePrice;
            Application.Current.Properties["SafetyTotal"] = safetyTotal;
            Application.Current.Properties["OutdoorShieldQuantity"] = outdoorShieldQuantity;
            Application.Current.Properties["OutdoorShieldTotal"] = outdoorShieldTotal;
            Application.Current.Properties["IndoorShieldTotal"] = indoorShieldTotal;
            Application.Current.Properties["IndoorShieldQuantity"] = indoorShieldQuantity;
            Application.Current.Properties["MicroShieldQuantity"] = microShieldQuantity;
            Application.Current.Properties["MicroShieldTotal"] = microShieldTotal;
            Application.Current.Properties["ShieldsCollarQuantity"] = shieldsCollarQuantity;
            Application.Current.Properties["ShieldsCollarTotal"] = shieldsCollarTotal;
            Application.Current.Properties["MicroLiteQuantity"] = microLiteQuantity;
            Application.Current.Properties["MicroLiteTotal"] = microLiteTotal;
            Application.Current.Properties["ProtectionTotal"] = protectionTotal;
            Application.Current.Properties["DoormanPetDoorQuantity"] = doormanPetDoorQuantity;
            Application.Current.Properties["DoormanPetDoorTotal"] = doormanPetDoorTotal;
            Application.Current.Properties["ShieldsCollarQuantity2"] = shieldsCollarQuantity2;
            Application.Current.Properties["FreedomTotal"] = freedomTotal;
            Application.Current.Properties["SafetyWiredAddQuantity"] = safetyWiredAddQuantity;
            Application.Current.Properties["SafetyWiredAddTotal"] = safetyWiredAddTotal;
            Application.Current.Properties["GPSAddQuantity"] = gPSAddQuantity;
            Application.Current.Properties["GPSAddTotal"] = gPSAddTotal;
            Application.Current.Properties["SingleTrainQuantity"] = singleTrainQuantity;
            Application.Current.Properties["SingleTrainTotal"] = singleTrainTotal;
            Application.Current.Properties["CouponCode"] = couponCode;
            Application.Current.Properties["Discount"] = discount;
            Application.Current.Properties["SolutionsPageTotal"] = solutionsPageTotal;
            Application.Current.Properties["OutdoorInstallationCost"] = outdoorInstallCost;
            Application.Current.Properties["IndoorXLoopQuantity"] = indoorXLoopQuantity;
            Application.Current.Properties["IndoorXLoopTotal"] = indoorXLoopTotal;
            Application.Current.Properties["OutdoorXLoopQuantity"] = outdoorXLoopQuantity;
            Application.Current.Properties["OutdoorXLoopTotal"] = outdoorXLoopTotal;
            Application.Current.Properties["PetDoorInstallQuantity"] = petDoorInstallQuantity;
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
