﻿namespace COMP1004_MovieBonanza_RAILL
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.cetegoryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.orderTitleTextBox = new System.Windows.Forms.TextBox();
            this.orderCategoryTextBox = new System.Windows.Forms.TextBox();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.yourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.orderDVDcheckBox = new System.Windows.Forms.CheckBox();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.orderTaxLabel = new System.Windows.Forms.Label();
            this.orderSubtotalLabel = new System.Windows.Forms.Label();
            this.orderDVDLabel = new System.Windows.Forms.Label();
            this.orderCostLabel = new System.Windows.Forms.Label();
            this.addDvdTextBox = new System.Windows.Forms.TextBox();
            this.orderTaxTextBox = new System.Windows.Forms.TextBox();
            this.orderSubtotalTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.orderCostTextBox = new System.Windows.Forms.TextBox();
            this.backButton2 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.streamButton = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.movieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).BeginInit();
            this.yourOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 27);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.streamToolStripMenuItem.Text = "Strea&m";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.cancelToolStripMenuItem.Text = "Canc&el";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 27);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // movieSelectedGroupBox
            // 
            this.movieSelectedGroupBox.Controls.Add(this.cetegoryLabel);
            this.movieSelectedGroupBox.Controls.Add(this.titleLabel);
            this.movieSelectedGroupBox.Controls.Add(this.orderTitleTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.orderCategoryTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.orderPictureBox);
            this.movieSelectedGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.movieSelectedGroupBox.Location = new System.Drawing.Point(43, 53);
            this.movieSelectedGroupBox.Name = "movieSelectedGroupBox";
            this.movieSelectedGroupBox.Size = new System.Drawing.Size(398, 574);
            this.movieSelectedGroupBox.TabIndex = 1;
            this.movieSelectedGroupBox.TabStop = false;
            this.movieSelectedGroupBox.Text = "Movie Selected";
            // 
            // cetegoryLabel
            // 
            this.cetegoryLabel.AutoSize = true;
            this.cetegoryLabel.Location = new System.Drawing.Point(31, 120);
            this.cetegoryLabel.Name = "cetegoryLabel";
            this.cetegoryLabel.Size = new System.Drawing.Size(124, 27);
            this.cetegoryLabel.TabIndex = 4;
            this.cetegoryLabel.Text = "Category";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(31, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(71, 27);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title";
            // 
            // orderTitleTextBox
            // 
            this.orderTitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderTitleTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderTitleTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTitleTextBox.Location = new System.Drawing.Point(36, 66);
            this.orderTitleTextBox.Name = "orderTitleTextBox";
            this.orderTitleTextBox.ReadOnly = true;
            this.orderTitleTextBox.Size = new System.Drawing.Size(316, 32);
            this.orderTitleTextBox.TabIndex = 2;
            // 
            // orderCategoryTextBox
            // 
            this.orderCategoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderCategoryTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderCategoryTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCategoryTextBox.Location = new System.Drawing.Point(36, 150);
            this.orderCategoryTextBox.Name = "orderCategoryTextBox";
            this.orderCategoryTextBox.ReadOnly = true;
            this.orderCategoryTextBox.Size = new System.Drawing.Size(316, 32);
            this.orderCategoryTextBox.TabIndex = 1;
            // 
            // orderPictureBox
            // 
            this.orderPictureBox.Location = new System.Drawing.Point(36, 202);
            this.orderPictureBox.Name = "orderPictureBox";
            this.orderPictureBox.Size = new System.Drawing.Size(316, 352);
            this.orderPictureBox.TabIndex = 0;
            this.orderPictureBox.TabStop = false;
            // 
            // yourOrderGroupBox
            // 
            this.yourOrderGroupBox.Controls.Add(this.orderDVDcheckBox);
            this.yourOrderGroupBox.Controls.Add(this.orderTotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderTaxLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderSubtotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderDVDLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderCostLabel);
            this.yourOrderGroupBox.Controls.Add(this.addDvdTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderTaxTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderSubtotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderTotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderCostTextBox);
            this.yourOrderGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.yourOrderGroupBox.Location = new System.Drawing.Point(469, 53);
            this.yourOrderGroupBox.Name = "yourOrderGroupBox";
            this.yourOrderGroupBox.Size = new System.Drawing.Size(532, 518);
            this.yourOrderGroupBox.TabIndex = 2;
            this.yourOrderGroupBox.TabStop = false;
            this.yourOrderGroupBox.Text = "Your Order";
            // 
            // orderDVDcheckBox
            // 
            this.orderDVDcheckBox.AutoSize = true;
            this.orderDVDcheckBox.Font = new System.Drawing.Font("Broadway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDVDcheckBox.Location = new System.Drawing.Point(28, 458);
            this.orderDVDcheckBox.Name = "orderDVDcheckBox";
            this.orderDVDcheckBox.Size = new System.Drawing.Size(498, 26);
            this.orderDVDcheckBox.TabIndex = 10;
            this.orderDVDcheckBox.Text = "Order the DVD (Adds $10.00 to Your Order)";
            this.orderDVDcheckBox.UseVisualStyleBackColor = true;
            this.orderDVDcheckBox.CheckedChanged += new System.EventHandler(this.DVDCheckBox_CheckedChanged);
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(164, 357);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(169, 27);
            this.orderTotalLabel.TabIndex = 9;
            this.orderTotalLabel.Text = "Grand Total";
            // 
            // orderTaxLabel
            // 
            this.orderTaxLabel.AutoSize = true;
            this.orderTaxLabel.Location = new System.Drawing.Point(124, 286);
            this.orderTaxLabel.Name = "orderTaxLabel";
            this.orderTaxLabel.Size = new System.Drawing.Size(209, 27);
            this.orderTaxLabel.TabIndex = 8;
            this.orderTaxLabel.Text = "Sales Tax (13%)";
            // 
            // orderSubtotalLabel
            // 
            this.orderSubtotalLabel.AutoSize = true;
            this.orderSubtotalLabel.Location = new System.Drawing.Point(211, 210);
            this.orderSubtotalLabel.Name = "orderSubtotalLabel";
            this.orderSubtotalLabel.Size = new System.Drawing.Size(122, 27);
            this.orderSubtotalLabel.TabIndex = 7;
            this.orderSubtotalLabel.Text = "Subtotal";
            // 
            // orderDVDLabel
            // 
            this.orderDVDLabel.AutoSize = true;
            this.orderDVDLabel.Location = new System.Drawing.Point(205, 132);
            this.orderDVDLabel.Name = "orderDVDLabel";
            this.orderDVDLabel.Size = new System.Drawing.Size(128, 27);
            this.orderDVDLabel.TabIndex = 6;
            this.orderDVDLabel.Text = "Add DVD";
            this.orderDVDLabel.Visible = false;
            // 
            // orderCostLabel
            // 
            this.orderCostLabel.AutoSize = true;
            this.orderCostLabel.Location = new System.Drawing.Point(268, 66);
            this.orderCostLabel.Name = "orderCostLabel";
            this.orderCostLabel.Size = new System.Drawing.Size(65, 27);
            this.orderCostLabel.TabIndex = 5;
            this.orderCostLabel.Text = "Cost";
            // 
            // addDvdTextBox
            // 
            this.addDvdTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.addDvdTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.addDvdTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDvdTextBox.Location = new System.Drawing.Point(389, 129);
            this.addDvdTextBox.Name = "addDvdTextBox";
            this.addDvdTextBox.ReadOnly = true;
            this.addDvdTextBox.Size = new System.Drawing.Size(100, 32);
            this.addDvdTextBox.TabIndex = 4;
            this.addDvdTextBox.Visible = false;
            // 
            // orderTaxTextBox
            // 
            this.orderTaxTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderTaxTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderTaxTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTaxTextBox.Location = new System.Drawing.Point(389, 278);
            this.orderTaxTextBox.Name = "orderTaxTextBox";
            this.orderTaxTextBox.ReadOnly = true;
            this.orderTaxTextBox.Size = new System.Drawing.Size(100, 32);
            this.orderTaxTextBox.TabIndex = 3;
            // 
            // orderSubtotalTextBox
            // 
            this.orderSubtotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderSubtotalTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderSubtotalTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderSubtotalTextBox.Location = new System.Drawing.Point(389, 202);
            this.orderSubtotalTextBox.Name = "orderSubtotalTextBox";
            this.orderSubtotalTextBox.ReadOnly = true;
            this.orderSubtotalTextBox.Size = new System.Drawing.Size(100, 32);
            this.orderSubtotalTextBox.TabIndex = 2;
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderTotalTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderTotalTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderTotalTextBox.Location = new System.Drawing.Point(389, 349);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.ReadOnly = true;
            this.orderTotalTextBox.Size = new System.Drawing.Size(100, 32);
            this.orderTotalTextBox.TabIndex = 1;
            // 
            // orderCostTextBox
            // 
            this.orderCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderCostTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderCostTextBox.Font = new System.Drawing.Font("Berlin Sans FB", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCostTextBox.Location = new System.Drawing.Point(389, 58);
            this.orderCostTextBox.Name = "orderCostTextBox";
            this.orderCostTextBox.ReadOnly = true;
            this.orderCostTextBox.Size = new System.Drawing.Size(100, 32);
            this.orderCostTextBox.TabIndex = 0;
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(507, 595);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(143, 33);
            this.backButton2.TabIndex = 3;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(680, 594);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 33);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // streamButton
            // 
            this.streamButton.Location = new System.Drawing.Point(858, 594);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(143, 34);
            this.streamButton.TabIndex = 5;
            this.streamButton.Text = "Stream!";
            this.streamButton.UseVisualStyleBackColor = true;
            this.streamButton.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1042, 679);
            this.ControlBox = false;
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.yourOrderGroupBox);
            this.Controls.Add(this.movieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.movieSelectedGroupBox.ResumeLayout(false);
            this.movieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).EndInit();
            this.yourOrderGroupBox.ResumeLayout(false);
            this.yourOrderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox movieSelectedGroupBox;
        private System.Windows.Forms.GroupBox yourOrderGroupBox;
        private System.Windows.Forms.Label cetegoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox orderCategoryTextBox;
        private System.Windows.Forms.PictureBox orderPictureBox;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button streamButton;
        private System.Windows.Forms.CheckBox orderDVDcheckBox;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label orderTaxLabel;
        private System.Windows.Forms.Label orderSubtotalLabel;
        private System.Windows.Forms.Label orderDVDLabel;
        private System.Windows.Forms.Label orderCostLabel;
        private System.Windows.Forms.TextBox addDvdTextBox;
        private System.Windows.Forms.TextBox orderTaxTextBox;
        private System.Windows.Forms.TextBox orderSubtotalTextBox;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.TextBox orderCostTextBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox orderTitleTextBox;
    }
}