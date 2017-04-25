using InvisibleFenceContract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;


namespace InvisibleFenceContract.Services
{
    public static class Utility
    {

        public static Order Order = new Order();
        private static List<Product> AllPrices
        {
            get;
            set;
        }

        

        public static void InitialLoadOrderData()
        {

            //load all initial order details
            Order.Balance = 0;

            Order.CustomerID = "";
            Order.PackageSelection = "";
            Order.PackagePrice = 0;
            Order.SafetyTotal = 0;
            Order.OutdoorShieldQuantity = 0;
            Order.OutdoorShieldPrice1 = 0;
            Order.OutdoorShieldPrice2 = 0;
            Order.OutdoorShieldTotal = 0;
            Order.IndoorShieldTotal = 0;
            Order.IndoorShieldQuantity = 0;
            Order.IndoorShieldPrice1 = 0;
            Order.IndoorShieldPrice2 = 0;
            Order.MicroShieldQuantity = 0;
            Order.MicroShieldPrice1 = 0;
            Order.MicroShieldPrice2 = 0;
            Order.MicroShieldTotal = 0;
            Order.ShieldsCollarQuantity = 0;
            Order.ShieldsCollarPrice = 0;
            Order.ShieldsCollarTotal = 0;
            Order.MicroLiteQuantity = 0;
            Order.MicroLitePrice = 0;
            Order.MicroLiteTotal = 0;
            Order.ProtectionTotal = 0;
            Order.DoormanPetDoorQuantity = 0;
            Order.DoormanPetDoorPrice = 0;
            Order.DoormanPetDoorTotal = 0;
            Order.ShieldsCollarQuantity2 = 0;
            Order.FreedomTotal = 0;
            Order.SafetyWiredAddQuantity = 0;
            Order.SafetyWiredAddPrice = 0;
            Order.SafetyWiredAddTotal = 0;
            Order.GPSAddQuantity = 0;
            Order.GPSAddPrice = 0;
            Order.GPSAddTotal = 0;
            Order.SingleTrainQuantity = 0;
            Order.SingleTrainPrice = 0;
            Order.SingleTrainTotal = 0;
            Order.CouponCode = "";
            Order.Discount = 0;
            Order.AddAPetTotal = 0;
            Order.OutdoorInstallCost = 0;
            Order.IndoorXLoopQuantity = 0;
            Order.IndoorXLoopPrice = 0;
            Order.IndoorXLoopTotal = 0;
            Order.OutdoorXLoopQuantity = 0;
            Order.OutdoorXLoopPrice = 0;
            Order.OutdoorXLoopTotal = 0;
            Order.PetDoorInstallQuantity = 0;
            Order.PetDoorInstallPrice = 0;
            Order.PetDoorInstallTotal = 0;
            Order.InstallTotal = 0;
            Order.SolutionTotal = 0;
            Order.TaxRate = 0;
            Order.Tax = 0;
            Order.Total = 0;
            Order.Deposit = 0;
            Order.Balance = 0;

            try
            {
                string file = System.IO.File.ReadAllText(@"../../Resources/Products.JSON");
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
                    Order.GPSPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 62138)
                {

                    Order.BoundaryPlusPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 62100)
                {

                    Order.DigitalTechnologyPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29476)
                {

                    Order.OutdoorShieldPrice1 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75857)
                {

                    Order.OutdoorShieldPrice2 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 52246)
                {

                    Order.IndoorShieldPrice1 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75858)
                {

                    Order.IndoorShieldPrice2 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 51264)
                {
                    Order.MicroShieldPrice1 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 75859)
                {
                    Order.MicroShieldPrice2 = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 57594)
                {

                    Order.ShieldsCollarPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29361)
                {

                    Order.MicroLitePrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29191)
                {

                    Order.DoormanPetDoorPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 76054)
                {

                    Order.SafetyWiredAddPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 63088)
                {

                    Order.GPSAddPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29084)
                {

                    Order.SingleTrainPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 28786)
                {
                    Order.OutdoorXLoopPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 28785)
                {

                    Order.IndoorXLoopPrice = AllPrices[i].PartPrice;
                }
                else if (AllPrices[i].PartID == 29193)
                {

                    Order.PetDoorInstallPrice = AllPrices[i].PartPrice;
                }
            }
        }
        }
}
