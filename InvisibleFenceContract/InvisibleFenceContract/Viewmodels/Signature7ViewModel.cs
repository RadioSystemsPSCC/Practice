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

namespace InvisibleFenceContract.Viewmodels
{
    class Signature7ViewModel : BindableBase
    {
        const string contract = "Invisible Fence Contract" + "\n\n" + "Name " + "           " + "Referred by " +
            "\n" + "Address " + "                                       " + "City " + "                 " + "State " + "             " + "ZIP " +
            "\n" + "Home Phone " + "Cell Phone " + "Email " +
            "\n" + "My property contains unmarked underground: " +
            "\n" + "Pet Name(s) " + "Breed(s) " + "Age(s) " + "Pre-existing Sensitivities " +
            "\n\n" + "SOLUTIONS " +
            "\n" + "Safety Solution " + "Subtotal " + "$" +
            "\n" + "Protection Solution" + "Subtotal" + "$" +
            "\n" + "Freedom Solution" + "Subtotal" + "$" +
            "\n\n" + "ADD-A-PET" + "(includes Computer Collar Unit, Training, and 1-Year Power Cap Plan)" +
            "\n" + "SAFETY Wired Add-A-Pet" + "x $499" + "$" +
            "\n" + "GPS 2.0 Wire Free Add-A-Pet" + "x $499" + "$" +
            "\n" + "PROTECTION Add-A-Pet" + "x $" + "$" +
            "\n" + "FREEDOM Add-A-Pet" + "x $" +
            "\n\n" + "PROFESSIONAL INSTALLATION" +
            "\n" + "Outdoor Installation" + "$" + "$" +
            "\n" + "Indoor Extension Loop (Up to 100')" + "x $99" + "$" +
            "\n" + "Outdoor Extension Loop (Up to 100')" + "x $99" + "$" +
            "\n" + "Pet Door Installation" + "x $" + "$" +
            "\n\n" + "TRAINING" +
            "\n" + "Single Refresher Train" + "x $" + "$" +
            "\n\n" + "Solution Total $" +
            "\n" + "Tax $" +
            "\n" + "Labor/Install Total $" +
            "\n\n" + "Total $" +
            "\n" + "Less Deposit $" +
            "\n" + "Balance $" +
            "\n\n" + "Prices are valid for 10 days. Balance payable at time of delivery." +
            "\n\n" + "By signing here I agree to the terms and conditions listed on the back of this agreement:" +
            "\n\n" + "Power Cap Battery Plan Renewal Information: When Client's Power Cap Battery Plan (\"Plan\")" +
"\n" + "is 30 days for expiration, Company will send a notice to the email address" +
"\n" + "provided by client.The notice will contain the client's account status, as well as any" +
"\n" + "revisions to the terms and conditions of the plan.The client has a valid credit card number" +
"\n" + "on file, automatic renewal of the plan will occur for another term, which will be the same" +
"\n" + "length as the prior term.The fee willl not exceed the current price, excluding promotional" +
"\n" + "and discount pricing.For plan subsciptions of one year or more, processing of" +
"\n" + "payments will occur within 30 days following the anniversary date.If client does not" +
"\n" + "want to have subscription automatically renewed, clent may turn off the auto renewal" +
"\n" + "option at any time by contacting Invisible Fence&#174; Brand Client Care at 800-578-3647" +
"\n" + "or by emailing ccc@invisiblefence.net. If client subscription of one year or more is" +
"\n" + "automatically renewed, and client contacts Customer Care department for a refund" +
"\n" + "within 45 days of the renewal, company will refund the full subscription price to client.";

        public ViewCommand ViewProperty { get; set; }

        public Signature7ViewModel()
        {
            this.ViewProperty = new ViewCommand(this);
        }

        public void ViewCommand()
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Invisible Fence Contract";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Times New Roman", 12, XFontStyle.Regular);
            XTextFormatter tf = new XTextFormatter(gfx);
            tf.Alignment = XParagraphAlignment.Left;

            XRect rec = new XRect(0, 0, page.Width, page.Height);
            gfx.DrawRectangle(XBrushes.White, rec);
            tf.DrawString(contract, font, XBrushes.Black, rec, XStringFormats.TopLeft);

            const string filename = "Contract.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
