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
        public List<Customer> c_Clients
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            string text = System.IO.File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + @"\Resources\JSON_singleObject.JSON");

            List<Customer> cc_Clients = JsonConvert.DeserializeObject<List<Customer>>(text);

            c_Clients = cc_Clients;
        }

    }
}
