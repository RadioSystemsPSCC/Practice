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
    class Installation6ViewModel : BindableBase
    {
       
        public Installation6ViewModel()
        {
            InstallationOrder();
            convertOrder();
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];
            MessageBox.Show("Safety Total " +order1.SafetyTotal.ToString());
            MessageBox.Show("Freedom Total " +order1.FreedomTotal.ToString());
            MessageBox.Show("OutdoorShieldTotal " +order1.OutdoorShieldTotal.ToString());
            MessageBox.Show("SafetyWiredAddTotal " + order1.SafetyWiredAddTotal.ToString());
        }



        public void InstallationOrder()
        {
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];
            order1.InstallTotal = 200;
            Application.Current.Properties["myOrder"] = order1;          
        }

        public void convertOrder()
        {
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];
            File.WriteAllText(@"C:/Users/docon/Documents/Capstone/outputText.JSON", JsonConvert.SerializeObject(order1));

        }
    }
}
