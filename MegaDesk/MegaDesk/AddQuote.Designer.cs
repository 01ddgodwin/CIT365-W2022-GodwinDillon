namespace MegaDesk
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.backToMainMenu = new System.Windows.Forms.Button();
            this.fullName = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.numbOfDrawers = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.rushOptions = new System.Windows.Forms.Label();
            this.fullNameTextbox = new System.Windows.Forms.TextBox();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.depthTextbox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drawersDropdown = new System.Windows.Forms.ComboBox();
            this.deskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialDropdown = new System.Windows.Forms.ComboBox();
            this.rushOptionDropdown = new System.Windows.Forms.ComboBox();
            this.Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMainMenu
            // 
            this.backToMainMenu.Location = new System.Drawing.Point(628, 391);
            this.backToMainMenu.Name = "backToMainMenu";
            this.backToMainMenu.Size = new System.Drawing.Size(160, 47);
            this.backToMainMenu.TabIndex = 0;
            this.backToMainMenu.Text = "Back To Main Menu";
            this.backToMainMenu.UseVisualStyleBackColor = true;
            this.backToMainMenu.Click += new System.EventHandler(this.backToMainMenu_Click);
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(202, 38);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(76, 20);
            this.fullName.TabIndex = 1;
            this.fullName.Text = "Full Name";
            this.fullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(213, 91);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(49, 20);
            this.width.TabIndex = 2;
            this.width.Text = "Width";
            this.width.Click += new System.EventHandler(this.width_Click);
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Location = new System.Drawing.Point(213, 142);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(50, 20);
            this.depth.TabIndex = 3;
            this.depth.Text = "Depth";
            this.depth.Click += new System.EventHandler(this.depth_Click);
            // 
            // numbOfDrawers
            // 
            this.numbOfDrawers.AutoSize = true;
            this.numbOfDrawers.Location = new System.Drawing.Point(193, 202);
            this.numbOfDrawers.Name = "numbOfDrawers";
            this.numbOfDrawers.Size = new System.Drawing.Size(94, 20);
            this.numbOfDrawers.TabIndex = 4;
            this.numbOfDrawers.Text = "# of Drawers";
            this.numbOfDrawers.Click += new System.EventHandler(this.numbOfDrawers_Click);
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Location = new System.Drawing.Point(182, 253);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(117, 20);
            this.material.TabIndex = 5;
            this.material.Text = "Surface Material";
            this.material.Click += new System.EventHandler(this.material_Click);
            // 
            // rushOptions
            // 
            this.rushOptions.AutoSize = true;
            this.rushOptions.Location = new System.Drawing.Point(182, 311);
            this.rushOptions.Name = "rushOptions";
            this.rushOptions.Size = new System.Drawing.Size(96, 20);
            this.rushOptions.TabIndex = 6;
            this.rushOptions.Text = "Rush Options";
            this.rushOptions.Click += new System.EventHandler(this.rushOptions_Click);
            // 
            // fullNameTextbox
            // 
            this.fullNameTextbox.Location = new System.Drawing.Point(382, 31);
            this.fullNameTextbox.Name = "fullNameTextbox";
            this.fullNameTextbox.Size = new System.Drawing.Size(253, 27);
            this.fullNameTextbox.TabIndex = 7;
            this.fullNameTextbox.Click += new System.EventHandler(this.fullNameTextbox_Click);
            this.fullNameTextbox.TextChanged += new System.EventHandler(this.fullNameTextbox_TextChanged);
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(382, 84);
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(253, 27);
            this.widthTextbox.TabIndex = 8;
            this.widthTextbox.Click += new System.EventHandler(this.widthTextbox_Click);
            this.widthTextbox.TextChanged += new System.EventHandler(this.widthTextbox_TextChanged);
            // 
            // depthTextbox
            // 
            this.depthTextbox.Location = new System.Drawing.Point(382, 139);
            this.depthTextbox.Name = "depthTextbox";
            this.depthTextbox.Size = new System.Drawing.Size(253, 27);
            this.depthTextbox.TabIndex = 9;
            this.depthTextbox.TextChanged += new System.EventHandler(this.depthTextbox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // drawersDropdown
            // 
            this.drawersDropdown.FormattingEnabled = true;
            this.drawersDropdown.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.drawersDropdown.Location = new System.Drawing.Point(382, 194);
            this.drawersDropdown.Name = "drawersDropdown";
            this.drawersDropdown.Size = new System.Drawing.Size(253, 28);
            this.drawersDropdown.TabIndex = 11;
            this.drawersDropdown.SelectedIndexChanged += new System.EventHandler(this.drawersDropdown_SelectedIndexChanged);
            // 
            // deskBindingSource
            // 
            this.deskBindingSource.DataSource = typeof(MegaDesk.Desk);
            // 
            // materialDropdown
            // 
            this.materialDropdown.FormattingEnabled = true;
            this.materialDropdown.Location = new System.Drawing.Point(382, 245);
            this.materialDropdown.Name = "materialDropdown";
            this.materialDropdown.Size = new System.Drawing.Size(253, 28);
            this.materialDropdown.TabIndex = 12;
            this.materialDropdown.SelectedIndexChanged += new System.EventHandler(this.materialDropdown_SelectedIndexChanged);
            // 
            // rushOptionDropdown
            // 
            this.rushOptionDropdown.FormattingEnabled = true;
            this.rushOptionDropdown.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushOptionDropdown.Location = new System.Drawing.Point(382, 303);
            this.rushOptionDropdown.Name = "rushOptionDropdown";
            this.rushOptionDropdown.Size = new System.Drawing.Size(253, 28);
            this.rushOptionDropdown.TabIndex = 13;
            this.rushOptionDropdown.SelectedIndexChanged += new System.EventHandler(this.rushOptionDropdown_SelectedIndexChanged);
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(362, 373);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(94, 29);
            this.Calculate.TabIndex = 14;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.rushOptionDropdown);
            this.Controls.Add(this.materialDropdown);
            this.Controls.Add(this.drawersDropdown);
            this.Controls.Add(this.depthTextbox);
            this.Controls.Add(this.widthTextbox);
            this.Controls.Add(this.fullNameTextbox);
            this.Controls.Add(this.rushOptions);
            this.Controls.Add(this.material);
            this.Controls.Add(this.numbOfDrawers);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.width);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.backToMainMenu);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backToMainMenu;
        private Label fullName;
        private Label width;
        private Label depth;
        private Label numbOfDrawers;
        private Label material;
        private Label rushOptions;
        public TextBox fullNameTextbox;
        public TextBox widthTextbox;
        private TextBox depthTextbox;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox drawersDropdown;
        private ComboBox materialDropdown;
        private ComboBox rushOptionDropdown;
        private BindingSource deskBindingSource;
        private Button Calculate;
    }
}