namespace P0005.Construction
{
    partial class FormB
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
            Button1.Location = new System.Drawing.Point(94, 53);
            Button1.Name = "Button1";
            Button1.Size = new System.Drawing.Size(181, 87);
            Button1.TabIndex = 0;
            Button1.Text = "Open FormA";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // FormB
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(Button1);
            Name = "FormB";
            Text = "FormB";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Button1;
    }
}
