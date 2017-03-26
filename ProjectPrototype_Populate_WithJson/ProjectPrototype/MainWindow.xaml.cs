/*This is the most recent version of the project prototype as of 02/17/2017 with a working method that converts a JSON file to C#
and populates the "customer" screen with it.  The external library newtonsoft JSON.NET is used in this program,
and this will need to be added  to any projects that attempt to run this.You can find it at http://www.newtonsoft.com/json
This program is currently only working with a JSON file stored in my user directories, I haven't been able to get it to
use the JSON file attached in the solution explorer yet.-D.O.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ProjectPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

             Customer cus1 = JsonConvert.DeserializeObject<Customer>(File.ReadAllText(@"C:/Users/docon/Documents/Capstone/text.JSON"));
            //Customer cus1 = JsonConvert.DeserializeObject<Customer>(File.ReadAllText(@"C:/Users/docon/Documents/Capstone/JSON_Practice/jsonFirstSample.JSON"));
           
            nametextbox.Text = cus1.FirstName;
            reftextbox.Text = cus1.ReferredBy;
            addresstextbox.Text = cus1.Address;
            citytextbox.Text = cus1.City;
            statetextbox.Text = cus1.State;
            ziptextbox.Text = cus1.Zip;
            homephonetextbox.Text = cus1.HomePhone;
            cellphonetextbox.Text = cus1.CellPhone;
            emailtextbox.Text = cus1.Email;
            petnametextbox.Text = cus1.PetName1;
            petbreedtextbox.Text = cus1.PetBreed1;
            petagetextbox.Text = cus1.PetAge1;
        }
        
    }


    public class Customer
    {
        public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string ReferredBy { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string HomePhone { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public string PetName1 { get; set; }
        public string PetBreed1 { get; set; }
        public string PetAge1 { get; set; }
    }
}
