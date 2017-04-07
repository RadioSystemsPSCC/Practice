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

namespace InvisibleFenceContract.Viewmodels
{
    class Contact1ViewModel : BindableBase
    {
        public Contact1ViewModel()
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
        }

    }
}
