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
<<<<<<< HEAD
            string text = System.IO.File.ReadAllText(@"C:\Users\docon\Documents\Capstone\text_multi_object.JSON");
=======
            string text = System.IO.File.ReadAllText(@"~/App_Data/JSON_singleObject.JSON");
>>>>>>> e8fd3674ed0cc547ac2cbac46e5d99e0a5a8c09c

            List<Customer> cc_Clients = JsonConvert.DeserializeObject<List<Customer>>(text);

            c_Clients = cc_Clients;
        }

    }
}
