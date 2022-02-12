namespace MegaDesk
{
    partial class DisplayQuote
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
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameInputLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.ShippingLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.WidthInputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(628, 391);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(160, 47);
            this.backToMainMenu.TabIndex = 1;
            this.backToMainMenu.Text = "Back";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(301, 84);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(76, 20);
            this.FullNameLabel.TabIndex = 3;
            this.FullNameLabel.Text = "Full Name";
            this.FullNameLabel.Click += new System.EventHandler(this.FullNameLabel_Click);
            // 
            // FullNameInputLabel
            // 
            this.FullNameInputLabel.AutoSize = true;
            this.FullNameInputLabel.Location = new System.Drawing.Point(426, 84);
            this.FullNameInputLabel.Name = "FullNameInputLabel";
            this.FullNameInputLabel.Size = new System.Drawing.Size(27, 20);
            this.FullNameInputLabel.TabIndex = 4;
            this.FullNameInputLabel.Text = "---";
            this.FullNameInputLabel.TextChanged += new System.EventHandler(this.FullNameInputLabel_TextChanged);
            this.FullNameInputLabel.Click += new System.EventHandler(this.FullNameInputLabel_Click);
            this.FullNameInputLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FullNameInputLabel_MouseMove);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(301, 130);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(85, 20);
            this.WidthLabel.TabIndex = 5;
            this.WidthLabel.Text = "Desk Width";
            this.WidthLabel.Click += new System.EventHandler(this.WidthLabel_Click);
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(301, 174);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(86, 20);
            this.DepthLabel.TabIndex = 6;
            this.DepthLabel.Text = "Desk Depth";
            this.DepthLabel.Click += new System.EventHandler(this.DepthLabel_Click);
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(301, 218);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(94, 20);
            this.DrawersLabel.TabIndex = 7;
            this.DrawersLabel.Text = "# of Drawers";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Location = new System.Drawing.Point(301, 262);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(64, 20);
            this.MaterialLabel.TabIndex = 8;
            this.MaterialLabel.Text = "Material";
            // 
            // ShippingLabel
            // 
            this.ShippingLabel.AutoSize = true;
            this.ShippingLabel.Location = new System.Drawing.Point(300, 302);
            this.ShippingLabel.Name = "ShippingLabel";
            this.ShippingLabel.Size = new System.Drawing.Size(68, 20);
            this.ShippingLabel.TabIndex = 9;
            this.ShippingLabel.Text = "Shipping";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(301, 342);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(42, 20);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "Total";
            // 
            // WidthInputLabel
            // 
            this.WidthInputLabel.AutoSize = true;
            this.WidthInputLabel.Location = new System.Drawing.Point(426, 130);
            this.WidthInputLabel.Name = "WidthInputLabel";
            this.WidthInputLabel.Size = new System.Drawing.Size(27, 20);
            this.WidthInputLabel.TabIndex = 11;
            this.WidthInputLabel.Text = "---";
            this.WidthInputLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WidthInputLabel_MouseMove);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WidthInputLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ShippingLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.FullNameInputLabel);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.backToMainMenu);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backToMainMenu;
        private Label FullNameLabel;
        public Label FullNameInputLabel;
        private Label WidthLabel;
        private Label DepthLabel;
        private Label DrawersLabel;
        private Label MaterialLabel;
        private Label ShippingLabel;
        private Label TotalLabel;
        public Label WidthInputLabel;
    }
}