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

namespace InvisibleFenceContract.Viewmodels
{
    class Contact1ViewModel : BindableBase
    {
        public int CusID = Convert.ToInt32(Application.Current.Properties["Cus_ID"]);
        public Contact1ViewModel()
        {
            
            LoadClients();
            LoadPets();
            pickPet();
        }
        public List<Customer> c_Clients
        {
            get;
            set;
        }
        public List<Pet> c_Pets
        {
            get;
            set;
        }
        public List<Pet> sel_Pets
        {
            get;
            set;
        }
        public int CustomerID
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if ((c_Clients[i].CustomerID == CusID) && (CusID != 0))
                    {
                        return c_Clients[i].CustomerID;
                    }
                }
                MessageBox.Show("Customer not found");
                return -1;
            }
            set
            {
                this.CustomerID = value;
            }
        }
        public string FirstName
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if ((c_Clients[i].CustomerID == CusID))
                    {
                        return c_Clients[i].FirstName;
                    }
                }
              
                return null;
            }
            set
            {
                this.FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if ((c_Clients[i].CustomerID == CusID))
                    {
                        return c_Clients[i].LastName;
                    }
                }
                return null;
            }
            set
            {
                this.LastName = value;
            }
        }
        public string ReferredBy
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if ((c_Clients[i].CustomerID == CusID))
                    {
                        return c_Clients[i].ReferredBy;
                    }
                }
                
                return null;
            }
            set
            {
                this.ReferredBy = value;
            }
        }
        public string Address
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if ((c_Clients[i].CustomerID == CusID))
                    {
                        return c_Clients[i].Address;
                    }
                }
               
                return null;
            }
            set
            {
                this.Address = value;
            }
        }
        public string City
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if (c_Clients[i].CustomerID == CusID)
                    {
                        return c_Clients[i].City;
                    }
                }
               
                return null;
            }
            set
            {
                this.City = value;
            }
        }
        public string State
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if (c_Clients[i].CustomerID == CusID)
                    {
                        return c_Clients[i].State;
                    }
                }
             
                return null;
            }
            set
            {
                this.State = value;
            }
        }
        public string Zip
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if (c_Clients[i].CustomerID == CusID)
                    {
                        return c_Clients[i].Zip;
                    }
                }
               
                return null;
            }
            set
            {
                this.Zip = value;
            }
        }
        public string HomePhone
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if (c_Clients[i].CustomerID == CusID)
                    {
                        return c_Clients[i].HomePhone;
                    }
                }
               
                return null;
            }
            set
            {
                this.HomePhone = value;
            }
        }
        public string CellPhone
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if (c_Clients[i].CustomerID == CusID)
                    {
                        return c_Clients[i].CellPhone;
                    }
                }
               
                return null;
            }
            set
            {
                this.CellPhone = value;
            }
        }
        public string Email
        {
            get
            {
                for (int i = 0; i < c_Clients.Count; i++)
                {
                    if (c_Clients[i].CustomerID == CusID)
                    {
                        return c_Clients[i].Email;
                    }
                }
                return null;
            }
            set
            {
                this.Email = value;
                OnPropertyChanged("Email");
            }
        }

        public void pickPet()
        {
            List<Pet> pick_Pet = new List<Pet>();
            foreach (Pet item in sel_Pets)
            {
                if (item.CustomerID == CustomerID)
                {

                    pick_Pet.Add(item);
                }
            }
            c_Pets = pick_Pet;
        }

        public void LoadPets()
        {

            string text = System.IO.File.ReadAllText(@"../../Resources/Pet.json");

            List<Pet> cc_Pets = JsonConvert.DeserializeObject<List<Pet>>(text);
            sel_Pets = cc_Pets;
        }

        public void LoadClients()
        {

            string text = System.IO.File.ReadAllText(@"../../Resources/JSON_oneObject_Correct.JSON");
            
            List<Customer> cc_Clients = JsonConvert.DeserializeObject<List<Customer>>(text);

            c_Clients = cc_Clients;
        }

    }
}