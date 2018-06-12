namespace ControlSmartTagsExample
{
    partial class Form1
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
            this.myControl1 = new ControlSmartTagsExample.MyControl();
            this.SuspendLayout();
            // 
            // myControl1
            // 
            this.myControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myControl1.Items = new string[] {
        "1",
        "2",
        "3"};
            this.myControl1.Location = new System.Drawing.Point(12, 12);
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(150, 150);
            this.myControl1.SomeColorProperty = System.Drawing.Color.Red;
            this.myControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 303);
            this.Controls.Add(this.myControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl myControl1;
    }
}

