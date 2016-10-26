using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhishingOutlookAddIn
{
   public partial class PhishingOutlookAddInAboutForm : Form
   {
      public PhishingOutlookAddInAboutForm()
      {
         InitializeComponent();
      }

      /**
       * 
       * Loads the About form with dynamic information, such as the Version.
       * 
       */
      private void PhishingOutlookAddInAboutForm_Load(object sender, EventArgs e)
      {
         //set version info
         Version version =
            System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

         this.label2.Text = String.Format(
            this.label2.Text,
            version.Major,
            version.Minor,
            version.Build,
            version.Revision);

         // Need to add carriage returns if need be...
         string aboutText = string.Format(
            PhishingOutlookAddInRibbon.DEFAULT_ABOUT_INFO_PROPERTY,
            Environment.NewLine);

         this.label3.Text = String.Format(
            this.label3.Text, aboutText);
      }

      private void label2_Click(object sender, EventArgs e)
      {
         // Do nothing here!
      }

      private void label3_Click(object sender, EventArgs e)
      {
         // Do nothing here!
      }

      private void button1_Click(object sender, EventArgs e)
      {
         // Do a Hide() instead of a Close(), which kills the Form object...
         Hide();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {

      }
   }
}
