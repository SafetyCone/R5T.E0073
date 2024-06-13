using System;


namespace P0005
{
    partial class FormA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new System.Drawing.Point(79, 65);
            Button1.Name = "Button1";
            Button1.Size = new System.Drawing.Size(265, 72);
            Button1.TabIndex = 0;
            Button1.Text = "Click Me!";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // FormA
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Button1);
            Name = "FormA";
            Text = "FormA";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Button1;
    }
}
