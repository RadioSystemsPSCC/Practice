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

namespace InvisibleFenceContract.Viewmodels
{
    class Safety2ViewModel : BindableBase
    {
        public Safety2ViewModel()
        {
            loadPrices();
        }

        public List<Product> safetyPrices
        {
            get;
            set;
        }

        public string GpsLabel
        {
            get
            {
                return "$" + safetyPrices[12].PartPrice;
            }
            set
            {
                GpsLabel = value;
                OnPropertyChanged("gpsLabel");
            }
        }

        public string BoundaryPlus
        {
            get
            {
                return "$" + safetyPrices[11].PartPrice;
            }
            set
            {
                BoundaryPlus = value;
                OnPropertyChanged("boundaryPlus");
            }
        }

        public string DigitalTechnology
        {
            get
            {
                return "$" + safetyPrices[10].PartPrice;
            }
            set
            {
                DigitalTechnology = value;
                OnPropertyChanged("digitalTechnology");
            }
        }

        public void loadPrices()
        {
            try
            {
                string file = File.ReadAllText(@"../../Resources/Products.JSON");
                List<Product> prices = JsonConvert.DeserializeObject<List<Product>>(file);
                safetyPrices = prices;
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
            }
        }
    }
}
