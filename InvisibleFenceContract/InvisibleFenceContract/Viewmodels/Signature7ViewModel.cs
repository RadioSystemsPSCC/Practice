﻿using System;
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
                XFont fontTitle = new XFont("Times New Roman", 18, XFontStyle.Bold);
                XFont smallFont = new XFont("Times New Roman", 8, XFontStyle.Regular);
                XImage logo = XImage.FromFile(@"../../Images/logo.jpg");
                gfx.DrawImage(logo, 10, 5, logo.PixelWidth - 20, logo.PixelHeight);
                gfx.DrawLine(XPens.CadetBlue, 10, 50, page.Width - 10, 50);

                //Customer Information
                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 70);
                gfx.DrawLine(XPens.Black, 15, 73, page.Width - 15, 73);
                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 90);
                gfx.DrawLine(XPens.Black, 15, 93, page.Width - 15, 93);
                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 110);
                gfx.DrawLine(XPens.Black, 15, 113, page.Width - 15, 113);
                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 130);
                gfx.DrawLine(XPens.Black, 15, 133, page.Width - 15, 133);
                gfx.DrawString("Name" + "Referred by", font, XBrushes.Black, 15, 150);
                gfx.DrawLine(XPens.Black, 15, 153, page.Width - 15, 153);

                //Solutions Totals
                gfx.DrawString("SOLUTIONS", fontTitle, XBrushes.Black, 15, 170);
                gfx.DrawString("SAFETY SOLUTION                               "
                    + "              Subtotal    $", font, XBrushes.Black, 15, 190);
                gfx.DrawLine(XPens.Black, 15, 193, 400, 193);
                gfx.DrawString("PROTECTION SOLUTION                   "
                    + "                Subtotal    $", font, XBrushes.Black, 15, 210);
                gfx.DrawLine(XPens.Black, 15, 213, 400, 213);
                gfx.DrawString("FREEDOM SOLUTION                      "
                    + "                   Subtotal    $", font, XBrushes.Black, 15, 230);
                gfx.DrawLine(XPens.Black, 15, 233, 400, 233);

                //Add-a-pet totals
                gfx.DrawString("ADD-A-PET", fontTitle, XBrushes.Black, 15, 260);
                gfx.DrawString("(includes Computer Collar Unit, Training, and 1-Year Power Cap Plan)", smallFont, XBrushes.Black, 120, 260);
                gfx.DrawString("SAFETY Wired Add-A-Pet " + "X    $499" + "    $", font, XBrushes.Black, 15, 280);
                gfx.DrawLine(XPens.Black, 15, 283, 400, 283);
                gfx.DrawString("GPS 2.0 Wire Free Add-A-Pet " + "X    $699" + "    $", font, XBrushes.Black, 15, 300);
                gfx.DrawLine(XPens.Black, 15, 303, 400, 303);
                gfx.DrawString("PROTECTION Add-A-Pet " + "X    $" + "    $", font, XBrushes.Black, 15, 320);
                gfx.DrawLine(XPens.Black, 15, 323, 400, 323);
                gfx.DrawString("FREEDOM Add-A-Pet " + "X    $" + "    ", font, XBrushes.Black, 15, 340);
                gfx.DrawLine(XPens.Black, 15, 343, 400, 343);

                //Professional Installation
                gfx.DrawString("PROFESSIONAL INSTALLATION", fontTitle, XBrushes.Black, 15, 370);
                gfx.DrawString("Outdoor Installation " + "             $" + "    $", font, XBrushes.Black, 15, 390);
                gfx.DrawLine(XPens.Black, 15, 393, 400, 393);
                gfx.DrawString("Indoor Extension Loop (Up to 100') " + "       X $99" + "    $", font, XBrushes.Black, 15, 410);
                gfx.DrawLine(XPens.Black, 15, 413, 400, 413);
                gfx.DrawString("Outdoor Extension Loop (Up to 100') " + "        X $99" + "    $", font, XBrushes.Black, 15, 430);
                gfx.DrawLine(XPens.Black, 15, 433, 400, 433);
                gfx.DrawString("Pet Door Installation " + "            X $" + "       $", font, XBrushes.Black, 15, 450);
                gfx.DrawLine(XPens.Black, 15, 453, 400, 453);



                const string filename = "Contract.pdf";
                document.Save(filename);
                Process.Start(filename);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}