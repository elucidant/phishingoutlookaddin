namespace PhishingOutlookAddIn
{
   partial class PhishingOutlookAddInEmailConfirmationForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

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

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhishingOutlookAddInEmailConfirmationForm));
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(27, 26);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(38, 36);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(82, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(349, 18);
         this.label1.TabIndex = 1;
         this.label1.Text = "Are you sure you want to report this email as Phish?";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.Location = new System.Drawing.Point(21, 77);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(237, 17);
         this.checkBox1.TabIndex = 2;
         this.checkBox1.Text = "In the future, do not show me this dialog box.";
         this.checkBox1.UseVisualStyleBackColor = true;
         this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(297, 72);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 3;
         this.button1.Text = "Yes";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.DialogResult = System.Windows.Forms.DialogResult.No;
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.button2.Location = new System.Drawing.Point(378, 72);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 4;
         this.button2.Text = "No";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click_1);
         // 
         // PhishingOutlookAddInEmailConfirmationForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(497, 122);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.checkBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "PhishingOutlookAddInEmailConfirmationForm";
         this.Text = "Phishing Email Send Confirmation";
         this.Load += new System.EventHandler(this.PhishingOutlookAddInEmailConfirmationForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
   }
}