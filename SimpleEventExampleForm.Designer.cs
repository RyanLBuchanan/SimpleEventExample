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
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.displayPasswordButton = new System.Windows.Forms.Button();
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
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(192, 129);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.inputPasswordTextBox.TabIndex = 2;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.AutoSize = true;
            this.displayPasswordLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPasswordLabel.Location = new System.Drawing.Point(192, 177);
            this.displayPasswordLabel.MaximumSize = new System.Drawing.Size(97, 23);
            this.displayPasswordLabel.MinimumSize = new System.Drawing.Size(97, 23);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(97, 23);
            this.displayPasswordLabel.TabIndex = 3;
            this.displayPasswordLabel.Text = "\r\n";
            this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(195, 224);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(97, 23);
            this.displayPasswordButton.TabIndex = 4;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SimpleEventExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.displayPasswordButton);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clickButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "SimpleEventExampleForm";
            this.Text = "Simple Event Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.Button displayPasswordButton;
    }
}

