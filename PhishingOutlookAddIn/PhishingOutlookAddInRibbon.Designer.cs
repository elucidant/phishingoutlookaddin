namespace PhishingOutlookAddIn
{
   partial class PhishingOutlookAddInRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      public PhishingOutlookAddInRibbon()
          : base(Globals.Factory.GetRibbonFactory())
      {
         InitializeComponent();
      }

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.tab1 = this.Factory.CreateRibbonTab();
         this.group1 = this.Factory.CreateRibbonGroup();
         this.button1 = this.Factory.CreateRibbonButton();
         this.menu1 = this.Factory.CreateRibbonMenu();
         this.tab1.SuspendLayout();
         this.group1.SuspendLayout();
         this.SuspendLayout();
         // 
         // tab1
         // 
         this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
         this.tab1.ControlId.OfficeId = "TabMail";
         this.tab1.Groups.Add(this.group1);
         this.tab1.Label = "TabMail";
         this.tab1.Name = "tab1";
         // 
         // group1
         // 
         this.group1.Items.Add(this.button1);
         this.group1.Items.Add(this.menu1);
         this.group1.Label = "{0} - Phishing";
         this.group1.Name = "group1";
         // 
         // button1
         // 
         this.button1.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
         this.button1.Image = global::PhishingOutlookAddIn.Properties.Resources.phish_button;
         this.button1.Label = "Report A Phish";
         this.button1.Name = "button1";
         this.button1.ScreenTip = "Report an eMail as Phish!";
         this.button1.ShowImage = true;
         this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
         // 
         // menu1
         // 
         this.menu1.Dynamic = true;
         this.menu1.Image = global::PhishingOutlookAddIn.Properties.Resources.phish_button;
         this.menu1.Label = "Phishing";
         this.menu1.Name = "menu1";
         this.menu1.ScreenTip = "Customize Phish Reporting Experience";
         this.menu1.ShowImage = true;
         this.menu1.ItemsLoading += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.menu1_ItemsLoading);
         // 
         // PhishingOutlookAddInRibbon
         // 
         this.Name = "PhishingOutlookAddInRibbon";
         this.RibbonType = "Microsoft.Outlook.Explorer";
         this.Tabs.Add(this.tab1);
         this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
         this.tab1.ResumeLayout(false);
         this.tab1.PerformLayout();
         this.group1.ResumeLayout(false);
         this.group1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
      internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
      internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
      internal Microsoft.Office.Tools.Ribbon.RibbonMenu menu1;
   }

   partial class ThisRibbonCollection
   {
      internal PhishingOutlookAddInRibbon PhishingOutlookAddInRibbon
      {
         get { return this.GetRibbon<PhishingOutlookAddInRibbon>(); }
      }
   }
}
