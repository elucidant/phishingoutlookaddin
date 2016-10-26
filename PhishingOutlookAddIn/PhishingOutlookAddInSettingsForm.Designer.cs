namespace PhishingOutlookAddIn
{
   partial class PhishingOutlookAddInSettingsForm
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhishingOutlookAddInSettingsForm));
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.checkBox1 = new System.Windows.Forms.CheckBox();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.label4 = new System.Windows.Forms.Label();
         this.checkBox2 = new System.Windows.Forms.CheckBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.button4 = new System.Windows.Forms.Button();
         this.checkBox3 = new System.Windows.Forms.CheckBox();
         this.label7 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 13);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(421, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "This dialogue is used to configure the settings of the Phishing Reporting Outlook" +
    " Add-In.";
         this.label1.Click += new System.EventHandler(this.label1_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(87, 47);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(105, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Phish eMail Address:";
         this.label2.Click += new System.EventHandler(this.label2_Click);
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(206, 43);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(269, 20);
         this.textBox1.TabIndex = 2;
         this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(90, 76);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(103, 13);
         this.label3.TabIndex = 3;
         this.label3.Text = "Phish eMail Subject:";
         this.label3.Click += new System.EventHandler(this.label3_Click);
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(206, 74);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(269, 20);
         this.textBox2.TabIndex = 4;
         this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(32, 201);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(156, 23);
         this.button1.TabIndex = 5;
         this.button1.Text = "Phish Email Folder";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(206, 203);
         this.textBox3.Name = "textBox3";
         this.textBox3.ReadOnly = true;
         this.textBox3.Size = new System.Drawing.Size(269, 20);
         this.textBox3.TabIndex = 6;
         this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(310, 276);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 7;
         this.button2.Text = "OK";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(401, 276);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 8;
         this.button3.Text = "Cancel";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // checkBox1
         // 
         this.checkBox1.AutoSize = true;
         this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.checkBox1.Location = new System.Drawing.Point(206, 240);
         this.checkBox1.Name = "checkBox1";
         this.checkBox1.Size = new System.Drawing.Size(15, 14);
         this.checkBox1.TabIndex = 9;
         this.checkBox1.UseVisualStyleBackColor = true;
         this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Location = new System.Drawing.Point(206, 105);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
         this.numericUpDown1.TabIndex = 10;
         this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(10, 108);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(180, 13);
         this.label4.TabIndex = 11;
         this.label4.Text = "Maximum amount of Phish to Report:";
         this.label4.Click += new System.EventHandler(this.label4_Click);
         // 
         // checkBox2
         // 
         this.checkBox2.AutoSize = true;
         this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.checkBox2.Location = new System.Drawing.Point(206, 170);
         this.checkBox2.Name = "checkBox2";
         this.checkBox2.Size = new System.Drawing.Size(15, 14);
         this.checkBox2.TabIndex = 12;
         this.checkBox2.UseVisualStyleBackColor = true;
         this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(16, 170);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(174, 13);
         this.label5.TabIndex = 13;
         this.label5.Text = "Delete Phish Email after forwarding:";
         this.label5.Click += new System.EventHandler(this.label5_Click);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(81, 240);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(113, 13);
         this.label6.TabIndex = 14;
         this.label6.Text = "Enable DEBUG mode:";
         this.label6.Click += new System.EventHandler(this.label6_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(175, 275);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(113, 23);
         this.button4.TabIndex = 15;
         this.button4.Text = "Reset to Defaults";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // checkBox3
         // 
         this.checkBox3.AutoSize = true;
         this.checkBox3.Location = new System.Drawing.Point(206, 140);
         this.checkBox3.Name = "checkBox3";
         this.checkBox3.Size = new System.Drawing.Size(15, 14);
         this.checkBox3.TabIndex = 16;
         this.checkBox3.UseVisualStyleBackColor = true;
         this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(65, 139);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(124, 13);
         this.label7.TabIndex = 17;
         this.label7.Text = "Submission Confirmation:";
         this.label7.Click += new System.EventHandler(this.label7_Click);
         // 
         // PhishingOutlookAddInSettingsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(499, 319);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.checkBox3);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.checkBox2);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.checkBox1);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "PhishingOutlookAddInSettingsForm";
         this.Text = "Phishing Outlook AddIn Settings Form";
         this.Load += new System.EventHandler(this.PhishingOutlookAddInSettingsForm_Load);
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.CheckBox checkBox1;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.CheckBox checkBox2;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.CheckBox checkBox3;
      private System.Windows.Forms.Label label7;
   }
}