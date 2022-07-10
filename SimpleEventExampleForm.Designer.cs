namespace SimpleEventExample
{
    partial class SimpleEventExampleForm
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
            this.clickButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickButton
            // 
            this.clickButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clickButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.clickButton.Location = new System.Drawing.Point(0, 0);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(484, 23);
            this.clickButton.TabIndex = 0;
            this.clickButton.Text = "Button";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(172, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bottom Right Anchor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SimpleEventExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clickButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "SimpleEventExampleForm";
            this.Text = "Simple Event Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Button button1;
    }
}

