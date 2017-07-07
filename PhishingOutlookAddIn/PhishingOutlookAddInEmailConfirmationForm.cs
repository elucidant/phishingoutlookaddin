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
   public partial class PhishingOutlookAddInEmailConfirmationForm : Form
   {
      private static readonly log4net.ILog log =
         log4net.LogManager.GetLogger(
         System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

      public PhishingOutlookAddInEmailConfirmationForm()
      {
         InitializeComponent();
      }

      private void pictureBox1_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label1_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      /**
       * 
       * Event handler when the YES button is clicked.
       * 
       */
      private void button1_Click(object sender, EventArgs e)
      {
         log.Debug(
            "Phishing Email Send Confirmation dialog: User pressed YES button!");

         // First, check if the checkbox to not display in the future is
         // checked.  If checked, we will need to persist the user setting
         // to TURN OFF phsihing email send confirmation.  The only way a
         // user can TURN ON the phishing email send confirmation is to update
         // their user settings (either via the Settings menu option or
         // updating the configuration file for the AddIn in the User's Local
         // Application Data folder for the Phishing Outlook AddIn.
         if (checkBox1.Checked == true)
         {
            Properties.Settings.Default.phishingEmailConfirmationPrompt = false;

            // Persist changes to user settings between application sessions.
            Properties.Settings.Default.Save();

            // Need to update the cached user settings...
            PhishingOutlookAddInSettingsForm.updateUserSettings();

            // Reset the checkbox for next use...
            checkBox1.Checked = false;
         }

         this.DialogResult = DialogResult.Yes;

         // Do a Hide() instead of a Close(), which kills the Form object...
         Hide();
      }

      /**
       * 
       * Event handler when the NO button is clicked.
       * 
       */
      private void button2_Click_1(object sender, EventArgs e)
      {
         // First, check if the checkbox to not display in the future is
         // checked.  If checked, we will need to persist the user setting
         // to TURN OFF phsihing email send confirmation.  The only way a
         // user can TURN ON the phishing email send confirmation is to update
         // their user settings (either via the Settings menu option or
         // updating the configuration file for the AddIn in the User's Local
         // Application Data folder for the Phishing Outlook AddIn.
         if (checkBox1.Checked == true)
         {
            Properties.Settings.Default.phishingEmailConfirmationPrompt = false;

            // Persist changes to user settings between application sessions.
            Properties.Settings.Default.Save();

            // Need to update the cached user settings...
            PhishingOutlookAddInSettingsForm.updateUserSettings();

            // Reset the checkbox for next use...
            checkBox1.Checked = false;
         }

         string message =
            "Phishing Email Send Confirmation dialog: User pressed NO button!";

         log.Debug(message);

         this.DialogResult = DialogResult.No;

         // Do a Hide() instead of a Close(), which kills the Form object...
         Hide();
      }

      private void PhishingOutlookAddInEmailConfirmationForm_Load(object sender, EventArgs e)
      {

      }
   }
}
