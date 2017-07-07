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
   public partial class PhishingOutlookAddInSettingsForm : Form
   {
      private static readonly log4net.ILog log =
         log4net.LogManager.GetLogger(
            System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

      // Default form properties based on Ribbon class' default settings
      // initially...
      private static bool addinDebug;
      private static bool phishingEmailDeleteComplete;
      private static bool phishingEmailConfirmationPrompt;

      private static string phishingEmailAddress;
      private static string phishingEmailSubject;
      private static string phishingEmailFolder;

      private static int phishingEmailMaxReported;

      // Read-write instance properties
      public string PhishingEmailAddress
      {
         get { return phishingEmailAddress; }
         set { phishingEmailAddress = value; }
      }
      public string PhishingEmailSubject
      {
         get { return phishingEmailSubject; }
         set { phishingEmailSubject = value; }
      }
      public string PhishingEmailFolder
      {
         get { return phishingEmailFolder; }
         set { phishingEmailFolder = value; }
      }

      public bool AddInDebug
      {
         get { return addinDebug; }
         set { addinDebug = value; }
      }
      public bool PhishingEmailDeleteComplete
      {
         get { return phishingEmailDeleteComplete; }
         set { phishingEmailDeleteComplete = value; }
      }
      public int PhishingEmailMaxReported
      {
         get { return phishingEmailMaxReported; }
         set { phishingEmailMaxReported = value; }
      }
      public bool PhishingEmailConfirmationPrompt
      {
         get { return phishingEmailConfirmationPrompt; }
         set { phishingEmailConfirmationPrompt = value; }
      }

      public PhishingOutlookAddInSettingsForm()
      {
         log.Debug("In PhishingOutlookAddInSettingsForm Constructor...");

         // Get local file system settings...
         updateUserSettings();

         logSettings();

         InitializeComponent();
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         // Do nothing when each letter is entered...
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {
         // Do nothing when each letter is entered...
      }
      
      private void textBox3_TextChanged(object sender, EventArgs e)
      {
         // Do nothing when each letter is entered...
      }

      private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }
      
      private void label1_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label2_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label3_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label4_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label5_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label6_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void label7_Click(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }
      
      private void checkBox2_CheckedChanged(object sender, EventArgs e)
      {
         // Need to disable the folder selection button if this is checked!
         button1.Enabled = !checkBox2.Checked;
      }
      
      private void checkBox3_CheckedChanged(object sender, EventArgs e)
      {
         // Do nothing for this event...
      }

      /**
       * 
       * Event handler when the Phish Email Folder button is clicked.
       * 
       */

      private void button1_Click(object sender, EventArgs e)
      {
         Microsoft.Office.Interop.Outlook.Application olApp =
            new Microsoft.Office.Interop.Outlook.Application();

         Microsoft.Office.Interop.Outlook.MAPIFolder folder = null;

         // Have the user select the folder here...
         folder = olApp.Session.PickFolder();

         // NOTE: The PickFolder() method will return a NULL folder IF AND
         // ONLY IF the user CANCELs the PickFolder dialogue!!!
         if (folder != null)
         {
            log.Debug(
                  "Outlook Folder Selected: " + folder.Name +
                  "; Full Path: " + folder.FullFolderPath);

             // Now set the Phishing Email Folder property...
             this.textBox3.Text = folder.Name;

             // Refresh the Form to show the change...
             this.Load += new System.EventHandler(this.PhishingOutlookAddInSettingsForm_Load);
             this.ResumeLayout(false);
             this.PerformLayout();
         }
      }

      /**
       * 
       * Event handler when the OK button is clicked.
       * 
       */

      private void button2_Click(object sender, EventArgs e)
      {
         log.Debug(
            "User pressed OK button!\n" + buildFormSettingsString());

         // We DO NOT need to set the phishingEmailFolder here since we are
         // setting the value in the Button Click event for the Outlook
         // folder selection process.
         phishingEmailAddress = textBox1.Text;
         phishingEmailSubject = textBox2.Text;
         phishingEmailFolder = textBox3.Text;

         phishingEmailMaxReported = (int)numericUpDown1.Value;

         phishingEmailDeleteComplete = checkBox2.Checked;
         phishingEmailConfirmationPrompt = checkBox3.Checked;
         addinDebug = checkBox1.Checked;

         // Now we need to persist the values to the Properties file...
         persistPropertySettings();

         logSettings();

         // Do a Hide() instead of a Close(), which kills the Form object...
         Hide();
      }

      /**
       * 
       * This method persists the current form settings to the Add-In User
       * property file on the user's file system.  This is how the settings are
       * used across Outlook application life-cycles for the specific user.
       * 
       */

      public static void persistPropertySettings()
      {
         // Now we need to persist the values to the Properties file...
         Properties.Settings.Default.phishingEmailFolder = phishingEmailFolder;
         Properties.Settings.Default.phishingEmailAddress =
            phishingEmailAddress;
         Properties.Settings.Default.phishingEmailSubject =
            phishingEmailSubject;
         Properties.Settings.Default.phishingEmailMaxReported =
            phishingEmailMaxReported;
         Properties.Settings.Default.phishingEmailDeleteComplete =
            phishingEmailDeleteComplete;
         Properties.Settings.Default.phishingEmailConfirmationPrompt =
            phishingEmailConfirmationPrompt;
         Properties.Settings.Default.addinDebug = addinDebug;

         // Persist changes to user settings between application sessions.
         Properties.Settings.Default.Save();

         // Make sure to update the AddIn Default settings if you persist
         // changes to the Property file.
         PhishingOutlookAddInRibbon.setDefaultsToPropertyValues();
      }

      public static void updateUserSettings()
      {
         phishingEmailFolder =
            Properties.Settings.Default.phishingEmailFolder;
         phishingEmailAddress =
            Properties.Settings.Default.phishingEmailAddress;
         phishingEmailSubject =
            Properties.Settings.Default.phishingEmailSubject;
         phishingEmailMaxReported =
            Properties.Settings.Default.phishingEmailMaxReported;
         phishingEmailDeleteComplete =
            Properties.Settings.Default.phishingEmailDeleteComplete;
         phishingEmailConfirmationPrompt =
            Properties.Settings.Default.phishingEmailConfirmationPrompt;
         addinDebug = Properties.Settings.Default.addinDebug;
      }

      /**
       * 
       * Prior to showing the form, make sure that the properties are sync'd
       * up.
       * 
       */

      public void showForm()
      {
         this.setFormStateBasedOnProperties();

         this.Show();
      }

      /**
       *
       * Event handler when CANCEL button is clicked.
       * 
       */

      private void button3_Click(object sender, EventArgs e)
      {
         log.Debug(
            "User pressed CANCEL button!  " +
            "Reverting back to previous values!\n" +
            buildFormSettingsString());
            
         setFormStateBasedOnProperties();

         // Do a Hide() instead of a Close(), which kills the Form object...
         Hide();
      }

      /**
       *
       * Event handler when Reset To Defaults button is clicked.
       * 
       */
      private void button4_Click(object sender, EventArgs e)
      {
         string emailAddress = null;
         string emailFolder = null;
         string emailSubject = null;

         int maxReported;

         bool deleteComplete = false;
         bool confirmationPrompt = false;
         bool addInDebug = false;

         emailAddress = PhishingOutlookAddInRibbon.
            DEFAULT_PHISHING_EMAIL_ADDRESS_PROPERTY;

         emailSubject = PhishingOutlookAddInRibbon.
            DEFAULT_PHISHING_EMAIL_SUBJECT_PROPERTY;

         emailFolder = PhishingOutlookAddInRibbon.
            DEFAULT_PHISHING_EMAIL_FOLDER_PROPERTY;

         maxReported = PhishingOutlookAddInRibbon.
            DEFAULT_PHISHING_EMAIL_MAX_REPORTED_PROPERTY;

         deleteComplete = PhishingOutlookAddInRibbon.
            DEFAULT_PHISHING_EMAIL_DELETE_COMPLETE_PROPERTY;

         confirmationPrompt = PhishingOutlookAddInRibbon.
            DEFAULT_PHISHING_EMAIL_CONFIRMATION_PROMPT_PROPERTY;

         addInDebug = PhishingOutlookAddInRibbon.
            DEFAULT_ADDIN_DEBUG_PROPERTY;

         log.Debug(
            "User pressed Reset to Defaults button!  " +
            "Reverting back to DEFAULT values!");

         logSettings();

         // We want to set the form state to the default properties, BUT we DO
         // NOT want to set the properties UNTIL the user presses the OK
         // button.  This gives the user the ability to CANCEL out of the
         // process to set the properties permanently!
         setFormState(
            emailAddress,
            emailSubject,
            emailFolder,
            maxReported,
            deleteComplete,
            confirmationPrompt,
            addInDebug);
      }

      /**
       * 
       * Event handler when the form is loaded.  This method will initialize
       * the form default values based on the current form settings.
       * 
       */

      private void PhishingOutlookAddInSettingsForm_Load(object sender, EventArgs e)
      {
         log.Debug("Loading Phish Settings form...");

         setFormStateBasedOnProperties();
      }
      
      /**
       * 
       * Sets the form state based on the current form properties.
       * 
       */

      private void setFormStateBasedOnProperties()
      {
         setFormState(
            phishingEmailAddress,
            phishingEmailSubject,
            phishingEmailFolder,
            phishingEmailMaxReported,
            phishingEmailDeleteComplete,
            phishingEmailConfirmationPrompt,
            addinDebug);
      }

      /**
       * 
       * Sets the form state based on the parameters passed in.
       * 
       */
      private void setFormState(
         string emailAddress,
         string emailSubject,
         string emailFolder,
         int maxReported,
         bool deleteComplete,
         bool confirmationPrompt,
         bool addInDebug)
      {
         this.textBox1.Text = emailAddress;
         this.textBox2.Text = emailSubject;
         this.textBox3.Text = emailFolder;

         this.numericUpDown1.Value = maxReported;

         if (deleteComplete == true)
         {
            this.checkBox2.CheckState = CheckState.Checked;
         }
         else
         {
            this.checkBox2.CheckState = CheckState.Unchecked;
         }

         if (confirmationPrompt == true)
         {
            this.checkBox3.CheckState = CheckState.Checked;
         }
         else
         {
            this.checkBox3.CheckState = CheckState.Unchecked;
         }

         this.button1.Enabled = !deleteComplete;

         if (addInDebug == true)
         {
            this.checkBox1.CheckState = CheckState.Checked;
         }
         else
         {
            this.checkBox1.CheckState = CheckState.Unchecked;
         }
      }

      /**
       * 
       * Helper method to build the form settings string, typically used for
       * DEBUG purposes.
       * 
       */
      private string buildFormSettingsString()
      {
         string formSettingsString =
            "Phishing Email Address: " + phishingEmailAddress + "\n" +
            "Phishing Email Subject: " + phishingEmailSubject + "\n" +
            "Phishing Email Folder: " + phishingEmailFolder + "\n" +
            "Phishing Email Maximum Reported: " + phishingEmailMaxReported + "\n" +
            "Phishing Email Delete Complete: " + phishingEmailDeleteComplete + "\n" +
            "Phishing Email Confirmation Prompt: " + phishingEmailConfirmationPrompt + "\n" +
            "Debug Enabled: " + addinDebug;

         return formSettingsString;
      }

      private void logSettings()
      {
         // Log the current AddIn Settings as well...
         PhishingOutlookAddInRibbon.logSettings();

         log.Debug(
            "AddIn Settings Form Properties:\n" +
            buildFormSettingsString());
      }
   }
}
