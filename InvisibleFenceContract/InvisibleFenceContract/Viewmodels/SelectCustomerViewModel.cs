using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvisibleFenceContract.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows;


namespace InvisibleFenceContract.Viewmodels
{

    public class SelectCustomerViewModel : BindableBase
    {
        public int CusID = Convert.ToInt32(Application.Current.Properties["Cus_ID"]);
        public SelectCustomerViewModel()
        {
            LoadClients();
            

        }

        public List<Customer> c_Clients
        {
            get;
            set;
        }

        public void LoadClients()
        {

            string text = System.IO.File.ReadAllText(@"../../Resources/JSON_oneObject_Correct.JSON");

            List<Customer> cc_Clients = JsonConvert.DeserializeObject<List<Customer>>(text);

            c_Clients = cc_Clients;
            foreach (var customer in cc_Clients)
            {
                customer.Parent = this;
            }
            c_Clients = cc_Clients;
        }
    }

}


