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

namespace string_json
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        Appointments app1 = new Appointments();
        Appointments app2 = new Appointments();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            
            //this line successfully reads in a json file that has nultiple objects and converts it to a string
            string text = System.IO.File.ReadAllText(@"C:\Users\docon\Documents\Capstone\text_multi_object.JSON");
                       

            //This line successfully converts the string called text to a C# List
            List<Appointments> appointment = JsonConvert.DeserializeObject<List<Appointments>>(text);


            //create two Appointments objects
            app1 = appointment[0];
            app2 = appointment[1];
            //app1.FirstName = "Johnny";

            MessageBox.Show(app1.PetName1);
            
            /*MessageBox.Show(app1.FirstName);
            MessageBox.Show(app1.ReferredBy);
            MessageBox.Show(app1.Address);
            MessageBox.Show(app1.City);
            MessageBox.Show(app1.State);
            MessageBox.Show(app1.Zip);
            MessageBox.Show(app1.HomePhone);
            MessageBox.Show(app1.CellPhone);
            MessageBox.Show(app1.Email);
            MessageBox.Show(app1.PetName1);
            MessageBox.Show(app1.PetBreed1);
            MessageBox.Show(app1.PetAge1);

            MessageBox.Show(app2.FirstName);
            MessageBox.Show(app2.ReferredBy);
            MessageBox.Show(app2.Address);
            MessageBox.Show(app2.City);
            MessageBox.Show(app2.State);
            MessageBox.Show(app2.Zip);
            MessageBox.Show(app2.HomePhone);
            MessageBox.Show(app2.CellPhone);
            MessageBox.Show(app2.Email);
            MessageBox.Show(app2.PetName1);
            MessageBox.Show(app2.PetBreed1);
            MessageBox.Show(app2.PetAge1);*/

            listBox.Items.Add(app1.FirstName + " " + app1.LastName);
            listBox.Items.Add(app2.FirstName + " " + app2.LastName);


            /*This is how a date was written in json format on the json.net documentation. This deserializer program
             should be able deserialize it*/
            //'ExpiryDate': '2000-12-29T00:00Z',
            
            //And this is how the json.net documentation has the 'Sizes' data field 
            //'Sizes': null
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {           
            //this code creates a list of C# objects and converts them to JSON,
            //then writes it back to the json file called outputText.JSON
            List<Appointments> toCrm = new List<Appointments>();
            toCrm.Add(app1);
            toCrm.Add(app2);
            File.WriteAllText(@"C:/Users/docon/Documents/Capstone/outputText.JSON", JsonConvert.SerializeObject(toCrm));                     
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.textBox.Text = this.listBox.SelectedItem.ToString();
        }

        private void changePetNameButton_Click(object sender, RoutedEventArgs e)
        {
            app1.PetName1 = petNameTextBox.Text;
            newPetNameTextBox.Text = app1.PetName1;
            MessageBox.Show(app1.PetName1);
        }
    }

    public class Appointments
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
