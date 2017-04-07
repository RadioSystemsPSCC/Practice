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
        //this is the customer that the user selects from the list of customers
        string cusPicked = "77";
        
        //load both methods
        public Contact1ViewModel()
        {
            LoadClients();
            getCus();
        }

        //This method searches through all of the customers in c_clients and if it finds
        //a value for CusId that matches what the user selected, it creates the my_Clients
        //List and adds that one item to it. It then sets the value of the sel_Clients List equal to my_Clients.

        public void getCus()
        {
            Customer cus = new Customer();
          
            foreach (Customer item in c_Clients)
            {
                cus.CusId = item.CusId;
                if (cus.CusId == cusPicked)
                {
                    List<Customer> my_Clients = new List<Customer>();                   
                    my_Clients.Add(item);
                    sel_Clients = my_Clients;
                }
            }           
        }         
        public List<Customer> sel_Clients
        {
            get;
            set;
        }
        public List<Customer> c_Clients
        {
            get;
            set;
        }

        //This methods deserializes the json string into text, then it creates the cc_clients List which
        //consists of all of the objects that are in the JSON file. It then sets the value of c_Clients equal to cc_Clients
        public void LoadClients()
        {           
                string text = System.IO.File.ReadAllText(@"../../Resources/JSON_oneObject_Correct.JSON");

                List<Customer> cc_Clients = JsonConvert.DeserializeObject<List<Customer>>(text);

                c_Clients = cc_Clients;                
        }
    }
}



