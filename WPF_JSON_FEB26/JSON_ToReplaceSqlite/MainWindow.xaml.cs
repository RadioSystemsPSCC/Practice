/*Programmer David Oconnor. This program reads in JSON files, converts them to C# objects, then
converts these objects back to JSON and writes them to new JSON files*/

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

namespace JSON_ToReplaceSqlite
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Appointments app1 = new Appointments();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {   //This reads in a JSON file and converts it to a Appointments object that can be manipulated with c# code.               
            app1 = JsonConvert.DeserializeObject<Appointments>(File.ReadAllText(@"C:/Users/docon/Documents/Capstone/text.JSON"));

            //assign new values to cus1 data fields
            app1.City = "New York New York";
            app1.Zip = "77772";                 
            app1.priceFence1 = 20;
            app1.numFence1 = Convert.ToInt32(numFenceTextBox.Text);          
            //call the totalFence1 method to get app1's total price
            app1.totFence1 = app1.totalFence1(app1.numFence1, app1.priceFence1);


            //The code below is for possible future use. Ignore for now
            //Customer cus2 = JsonConvert.DeserializeObject<Customer>(cus1);
            //string json = JsonConvert.SerializeObject(cus1);

            //show the new values in a message box
                       
            totalPriceLabel.Content = Convert.ToString(app1.totFence1);

            MessageBox.Show("Your appointments have been loaded into the system. Press the select customer button to " +
                "select a customer");
        }

        public void button2_Click(object sender, RoutedEventArgs e)
        {

            //convert the object back to a JSON file. Teh new values are reflected in this new JSON file
            File.WriteAllText(@"C:/Users/docon/Documents/Capstone/outputText.JSON", JsonConvert.SerializeObject(app1));
        }
    }

    public class Appointments
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
        public int numFence1 { get; set; }
        public decimal priceFence1 { get; set; }
        public decimal totFence1 { get; set; }
      

        public decimal totalFence1(int num, decimal price)
        {
            decimal total = 0;
            total = num * price;
            return total;
        }
    }
}

    









    
