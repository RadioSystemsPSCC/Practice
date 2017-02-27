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

namespace InvisibleFenceContract.Content
{
    /// <summary>
    /// Interaction logic for Signature7.xaml
    /// </summary>
    public partial class Signature7 : Page
    {
        public Signature7()
        {
            InitializeComponent();
        }

        private void CustomerSignatureCanvas_TouchDown(object sender, TouchEventArgs e)
        {
            CustomerSignatureCanvas.Height = 100;
            CustomerSignatureCanvas.Width = 500;
            canvasView.Height = 100;
            canvasView.Width = 500;
            CustomerSignatureCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void CustomerSignatureCanvas_TouchUp(object sender, TouchEventArgs e)
        {
            canvasView.Width = 346;
            canvasView.Height = 35;
        }
    }
}
