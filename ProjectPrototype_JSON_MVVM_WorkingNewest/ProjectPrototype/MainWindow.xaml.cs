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
using ProjectPrototype.Views;

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
        }

        private void ClientsUserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ProjectPrototype.ViewModel.Client_ViewModel clientViewModelObject =
               new ProjectPrototype.ViewModel.Client_ViewModel();
            clientViewModelObject.LoadStudents();

            ClientsUserControl.DataContext = clientViewModelObject;
        }
    }
}
