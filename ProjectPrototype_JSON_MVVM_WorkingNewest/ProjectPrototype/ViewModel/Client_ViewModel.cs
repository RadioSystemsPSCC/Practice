using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPrototype.Model;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ProjectPrototype.ViewModel
{
    class Client_ViewModel
    {
        public List<Clients> c_Clients
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\docon\Documents\Capstone\text_multi_object.JSON");
           
            List<Clients> cc_Clients = JsonConvert.DeserializeObject<List<Clients>>(text);
           
            c_Clients = cc_Clients;
        }
    }
}
