﻿namespace Activity_4
{
    partial class Activity4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSeconds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Seconds Elapsed";
            // 
            // textSeconds
            // 
            this.textSeconds.Location = new System.Drawing.Point(231, 53);
            this.textSeconds.Name = "textSeconds";
            this.textSeconds.Size = new System.Drawing.Size(100, 20);
            this.textSeconds.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResults
            // 
            this.textResults.Location = new System.Drawing.Point(231, 108);
            this.textResults.Name = "textResults";
            this.textResults.Size = new System.Drawing.Size(100, 20);
            this.textResults.TabIndex = 3;
            // 
            // Activity4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 160);
            this.Controls.Add(this.textResults);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSeconds);
            this.Controls.Add(this.label1);
            this.Name = "Activity4";
            this.Text = " Seconds Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSeconds;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textResults;
    }
}

