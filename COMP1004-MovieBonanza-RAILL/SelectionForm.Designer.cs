namespace COMP1004_MovieBonanza_RAILL
{
    partial class SelectionForm
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
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.UserDirectionsLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.selectionGroupBox = new System.Windows.Forms.GroupBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.selectionPictureBox = new System.Windows.Forms.PictureBox();
            this.selectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieListBox
            // 
            this.MovieListBox.Font = new System.Drawing.Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 23;
            this.MovieListBox.Items.AddRange(new object[] {
            "Cedar Rapids",
            "Company Men",
            "Death Race 2",
            "Footloose",
            "Gnomeo and Juliet",
            "I am Number Four",
            "Just Go With It",
            "No Strings Attached",
            "Real Steel",
            "Sanctum",
            "Season of the Witch",
            "The Dilemma",
            "The Eagle",
            "The Green Hornet",
            "The Mechanic",
            "The Other Woman",
            "The Rite",
            "The Roommate",
            "The Way Back",
            "Waiting for Forever"});
            this.MovieListBox.Location = new System.Drawing.Point(23, 200);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(210, 303);
            this.MovieListBox.Sorted = true;
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // UserDirectionsLabel
            // 
            this.UserDirectionsLabel.Font = new System.Drawing.Font("Broadway", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDirectionsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UserDirectionsLabel.Location = new System.Drawing.Point(23, 25);
            this.UserDirectionsLabel.Name = "UserDirectionsLabel";
            this.UserDirectionsLabel.Size = new System.Drawing.Size(748, 88);
            this.UserDirectionsLabel.TabIndex = 1;
            this.UserDirectionsLabel.Text = "Choose the Movie You Wish to STREAM from the List Below";
            this.UserDirectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(25, 149);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(208, 27);
            this.CurrentMoviesLabel.TabIndex = 2;
            this.CurrentMoviesLabel.Text = "Current Movies";
            // 
            // selectionGroupBox
            // 
            this.selectionGroupBox.Controls.Add(this.costLabel);
            this.selectionGroupBox.Controls.Add(this.categoryLabel);
            this.selectionGroupBox.Controls.Add(this.titleLabel);
            this.selectionGroupBox.Controls.Add(this.costTextBox);
            this.selectionGroupBox.Controls.Add(this.categoryTextBox);
            this.selectionGroupBox.Controls.Add(this.titleTextBox);
            this.selectionGroupBox.Controls.Add(this.selectionPictureBox);
            this.selectionGroupBox.Font = new System.Drawing.Font("Broadway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionGroupBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.selectionGroupBox.Location = new System.Drawing.Point(273, 149);
            this.selectionGroupBox.Name = "selectionGroupBox";
            this.selectionGroupBox.Size = new System.Drawing.Size(498, 280);
            this.selectionGroupBox.TabIndex = 3;
            this.selectionGroupBox.TabStop = false;
            this.selectionGroupBox.Text = "Your Selection";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.titleTextBox.Location = new System.Drawing.Point(167, 100);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(288, 32);
            this.titleTextBox.TabIndex = 1;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.categoryTextBox.Location = new System.Drawing.Point(167, 190);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(158, 32);
            this.categoryTextBox.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.costTextBox.Location = new System.Drawing.Point(355, 190);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(100, 32);
            this.costTextBox.TabIndex = 3;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(163, 61);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(66, 25);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Title";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(163, 153);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(116, 25);
            this.categoryLabel.TabIndex = 5;
            this.categoryLabel.Text = "Category";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(351, 153);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(62, 25);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "Cost";
            // 
            // nextButton
            // 
            this.nextButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.nextButton.Enabled = false;
            this.nextButton.Font = new System.Drawing.Font("Broadway", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.Black;
            this.nextButton.Location = new System.Drawing.Point(662, 464);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(109, 39);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // selectionPictureBox
            // 
            this.selectionPictureBox.ErrorImage = null;
            this.selectionPictureBox.Location = new System.Drawing.Point(28, 61);
            this.selectionPictureBox.Name = "selectionPictureBox";
            this.selectionPictureBox.Size = new System.Drawing.Size(114, 161);
            this.selectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectionPictureBox.TabIndex = 0;
            this.selectionPictureBox.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(796, 553);
            this.ControlBox = false;
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.selectionGroupBox);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.UserDirectionsLabel);
            this.Controls.Add(this.MovieListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.Text = "Movie Bonanza- Your Online Streaming Service";
            this.selectionGroupBox.ResumeLayout(false);
            this.selectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label UserDirectionsLabel;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.GroupBox selectionGroupBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.PictureBox selectionPictureBox;
        private System.Windows.Forms.Button nextButton;
    }
}

