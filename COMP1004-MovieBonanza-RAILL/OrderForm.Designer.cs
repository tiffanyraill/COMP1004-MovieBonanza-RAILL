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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.yourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.backButton2 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.streamButton = new System.Windows.Forms.Button();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.orderCategoryTextBox = new System.Windows.Forms.TextBox();
            this.orderTitleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cetegoryLabel = new System.Windows.Forms.Label();
            this.orderCostTextBox = new System.Windows.Forms.TextBox();
            this.orderTotalTextBox = new System.Windows.Forms.TextBox();
            this.orderSubtotalTextBox = new System.Windows.Forms.TextBox();
            this.orderTaxTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.orderCostLabel = new System.Windows.Forms.Label();
            this.orderDVDLabel = new System.Windows.Forms.Label();
            this.orderSubtotalLabel = new System.Windows.Forms.Label();
            this.orderTaxLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.orderDVDcheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.movieSelectedGroupBox.SuspendLayout();
            this.yourOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 33);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.streamToolStripMenuItem.Text = "Strea&m";
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.cancelToolStripMenuItem.Text = "Canc&el";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // movieSelectedGroupBox
            // 
            this.movieSelectedGroupBox.Controls.Add(this.cetegoryLabel);
            this.movieSelectedGroupBox.Controls.Add(this.titleLabel);
            this.movieSelectedGroupBox.Controls.Add(this.orderTitleTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.orderCategoryTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.orderPictureBox);
            this.movieSelectedGroupBox.Location = new System.Drawing.Point(43, 69);
            this.movieSelectedGroupBox.Name = "movieSelectedGroupBox";
            this.movieSelectedGroupBox.Size = new System.Drawing.Size(354, 558);
            this.movieSelectedGroupBox.TabIndex = 1;
            this.movieSelectedGroupBox.TabStop = false;
            this.movieSelectedGroupBox.Text = "Movie Selected";
            // 
            // yourOrderGroupBox
            // 
            this.yourOrderGroupBox.Controls.Add(this.orderDVDcheckBox);
            this.yourOrderGroupBox.Controls.Add(this.orderTotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderTaxLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderSubtotalLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderDVDLabel);
            this.yourOrderGroupBox.Controls.Add(this.orderCostLabel);
            this.yourOrderGroupBox.Controls.Add(this.textBox5);
            this.yourOrderGroupBox.Controls.Add(this.orderTaxTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderSubtotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderTotalTextBox);
            this.yourOrderGroupBox.Controls.Add(this.orderCostTextBox);
            this.yourOrderGroupBox.Location = new System.Drawing.Point(429, 69);
            this.yourOrderGroupBox.Name = "yourOrderGroupBox";
            this.yourOrderGroupBox.Size = new System.Drawing.Size(376, 426);
            this.yourOrderGroupBox.TabIndex = 2;
            this.yourOrderGroupBox.TabStop = false;
            this.yourOrderGroupBox.Text = "Your Order";
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(429, 593);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(75, 33);
            this.backButton2.TabIndex = 3;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(585, 594);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 33);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // streamButton
            // 
            this.streamButton.Location = new System.Drawing.Point(730, 593);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(75, 34);
            this.streamButton.TabIndex = 5;
            this.streamButton.Text = "Stream!";
            this.streamButton.UseVisualStyleBackColor = true;
            // 
            // orderPictureBox
            // 
            this.orderPictureBox.Location = new System.Drawing.Point(16, 186);
            this.orderPictureBox.Name = "orderPictureBox";
            this.orderPictureBox.Size = new System.Drawing.Size(316, 352);
            this.orderPictureBox.TabIndex = 0;
            this.orderPictureBox.TabStop = false;
            // 
            // orderCategoryTextBox
            // 
            this.orderCategoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderCategoryTextBox.Location = new System.Drawing.Point(16, 134);
            this.orderCategoryTextBox.Name = "orderCategoryTextBox";
            this.orderCategoryTextBox.ReadOnly = true;
            this.orderCategoryTextBox.Size = new System.Drawing.Size(316, 26);
            this.orderCategoryTextBox.TabIndex = 1;
            // 
            // orderTitleTextBox
            // 
            this.orderTitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderTitleTextBox.Location = new System.Drawing.Point(16, 66);
            this.orderTitleTextBox.Name = "orderTitleTextBox";
            this.orderTitleTextBox.ReadOnly = true;
            this.orderTitleTextBox.Size = new System.Drawing.Size(316, 26);
            this.orderTitleTextBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(16, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(38, 20);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Title";
            // 
            // cetegoryLabel
            // 
            this.cetegoryLabel.AutoSize = true;
            this.cetegoryLabel.Location = new System.Drawing.Point(16, 111);
            this.cetegoryLabel.Name = "cetegoryLabel";
            this.cetegoryLabel.Size = new System.Drawing.Size(73, 20);
            this.cetegoryLabel.TabIndex = 4;
            this.cetegoryLabel.Text = "Category";
            // 
            // orderCostTextBox
            // 
            this.orderCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderCostTextBox.Location = new System.Drawing.Point(196, 55);
            this.orderCostTextBox.Name = "orderCostTextBox";
            this.orderCostTextBox.ReadOnly = true;
            this.orderCostTextBox.Size = new System.Drawing.Size(100, 26);
            this.orderCostTextBox.TabIndex = 0;
            // 
            // orderTotalTextBox
            // 
            this.orderTotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderTotalTextBox.Location = new System.Drawing.Point(196, 269);
            this.orderTotalTextBox.Name = "orderTotalTextBox";
            this.orderTotalTextBox.ReadOnly = true;
            this.orderTotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.orderTotalTextBox.TabIndex = 1;
            // 
            // orderSubtotalTextBox
            // 
            this.orderSubtotalTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderSubtotalTextBox.Location = new System.Drawing.Point(196, 162);
            this.orderSubtotalTextBox.Name = "orderSubtotalTextBox";
            this.orderSubtotalTextBox.ReadOnly = true;
            this.orderSubtotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.orderSubtotalTextBox.TabIndex = 2;
            // 
            // orderTaxTextBox
            // 
            this.orderTaxTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.orderTaxTextBox.Location = new System.Drawing.Point(196, 220);
            this.orderTaxTextBox.Name = "orderTaxTextBox";
            this.orderTaxTextBox.ReadOnly = true;
            this.orderTaxTextBox.Size = new System.Drawing.Size(100, 26);
            this.orderTaxTextBox.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(196, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 4;
            this.textBox5.Visible = false;
            // 
            // orderCostLabel
            // 
            this.orderCostLabel.AutoSize = true;
            this.orderCostLabel.Location = new System.Drawing.Point(136, 61);
            this.orderCostLabel.Name = "orderCostLabel";
            this.orderCostLabel.Size = new System.Drawing.Size(42, 20);
            this.orderCostLabel.TabIndex = 5;
            this.orderCostLabel.Text = "Cost";
            // 
            // orderDVDLabel
            // 
            this.orderDVDLabel.AutoSize = true;
            this.orderDVDLabel.Location = new System.Drawing.Point(110, 105);
            this.orderDVDLabel.Name = "orderDVDLabel";
            this.orderDVDLabel.Size = new System.Drawing.Size(77, 20);
            this.orderDVDLabel.TabIndex = 6;
            this.orderDVDLabel.Text = "Add DVD";
            this.orderDVDLabel.Visible = false;
            // 
            // orderSubtotalLabel
            // 
            this.orderSubtotalLabel.AutoSize = true;
            this.orderSubtotalLabel.Location = new System.Drawing.Point(118, 168);
            this.orderSubtotalLabel.Name = "orderSubtotalLabel";
            this.orderSubtotalLabel.Size = new System.Drawing.Size(69, 20);
            this.orderSubtotalLabel.TabIndex = 7;
            this.orderSubtotalLabel.Text = "Subtotal";
            // 
            // orderTaxLabel
            // 
            this.orderTaxLabel.AutoSize = true;
            this.orderTaxLabel.Location = new System.Drawing.Point(63, 223);
            this.orderTaxLabel.Name = "orderTaxLabel";
            this.orderTaxLabel.Size = new System.Drawing.Size(124, 20);
            this.orderTaxLabel.TabIndex = 8;
            this.orderTaxLabel.Text = "Sales Tax (13%)";
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(94, 275);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(93, 20);
            this.orderTotalLabel.TabIndex = 9;
            this.orderTotalLabel.Text = "Grand Total";
            // 
            // orderDVDcheckBox
            // 
            this.orderDVDcheckBox.AutoSize = true;
            this.orderDVDcheckBox.Location = new System.Drawing.Point(16, 382);
            this.orderDVDcheckBox.Name = "orderDVDcheckBox";
            this.orderDVDcheckBox.Size = new System.Drawing.Size(345, 24);
            this.orderDVDcheckBox.TabIndex = 10;
            this.orderDVDcheckBox.Text = "Order the DVD (Adds $10.00 to Your Order)";
            this.orderDVDcheckBox.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 679);
            this.ControlBox = false;
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.yourOrderGroupBox);
            this.Controls.Add(this.movieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.Text = "Your Order";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.movieSelectedGroupBox.ResumeLayout(false);
            this.movieSelectedGroupBox.PerformLayout();
            this.yourOrderGroupBox.ResumeLayout(false);
            this.yourOrderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox orderTitleTextBox;
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox orderTaxTextBox;
        private System.Windows.Forms.TextBox orderSubtotalTextBox;
        private System.Windows.Forms.TextBox orderTotalTextBox;
        private System.Windows.Forms.TextBox orderCostTextBox;
    }
}