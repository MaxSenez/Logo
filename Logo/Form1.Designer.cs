namespace Logo
{
    partial class Logoform
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
            this.logoButton = new System.Windows.Forms.Button();
            this.testFont = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoButton
            // 
            this.logoButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.logoButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.logoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.logoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.logoButton.Location = new System.Drawing.Point(141, 356);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(201, 76);
            this.logoButton.TabIndex = 0;
            this.logoButton.Text = "Make Logo";
            this.logoButton.UseVisualStyleBackColor = false;
            this.logoButton.Click += new System.EventHandler(this.logoButton_Click);
            // 
            // testFont
            // 
            this.testFont.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testFont.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.testFont.Location = new System.Drawing.Point(59, 51);
            this.testFont.Name = "testFont";
            this.testFont.Size = new System.Drawing.Size(283, 138);
            this.testFont.TabIndex = 1;
            this.testFont.Text = "Test";
            this.testFont.Visible = false;
            // 
            // Logoform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.testFont);
            this.Controls.Add(this.logoButton);
            this.Name = "Logoform";
            this.Text = "Logo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoButton;
        private System.Windows.Forms.Label testFont;
    }
}

