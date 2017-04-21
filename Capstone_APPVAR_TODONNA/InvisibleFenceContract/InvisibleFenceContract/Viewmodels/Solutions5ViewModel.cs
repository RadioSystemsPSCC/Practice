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
    class Solutions5ViewModel : BindableBase
    {
        public Solutions5ViewModel()
        {
            SolutionsOrder();
            

        }

        public void SolutionsOrder()
        {
            Order order1 = new Order();
            order1 = (Order)Application.Current.Properties["myOrder"];            
            order1.SafetyWiredAddTotal = 175;
            Application.Current.Properties["myOrder"] = order1;
        }      
    }
}
