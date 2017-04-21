using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using InvisibleFenceContract.Viewmodels.Commands;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using System.Diagnostics;
using InvisibleFenceContract.Models;
using System.Collections.ObjectModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace InvisibleFenceContract.Viewmodels
{
    class Signature7ViewModel : BindableBase
    {
        
        public ViewCommand ViewProperty { get; set; }

        public Signature7ViewModel()
        {
            this.ViewProperty = new ViewCommand(this);
            
        }

       

        public void ViewCommand()
        {
            try
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Invisible Fence Contract";

                PdfPage page = document.AddPage();

                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Times New Roman", 12, XFontStyle.Regular);
                XImage logo = XImage.FromFile(@"../../Images/logo.jpg");
                gfx.DrawImage(logo, 10, 5, logo.PixelWidth - 20, logo.PixelHeight);
                gfx.DrawLine(XPens.CadetBlue, 10, 50, page.Width - 10, 50);

                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 70);
                gfx.DrawLine(XPens.Black, 15, 73, page.Width - 15, 73);
                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 90);
                gfx.DrawLine(XPens.Black, 15, 93, page.Width - 15, 93);


                const string filename = "Contract.pdf";
                document.Save(filename);
                Process.Start(filename);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
