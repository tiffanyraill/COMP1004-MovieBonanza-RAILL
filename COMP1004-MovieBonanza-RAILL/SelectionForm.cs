///@Movie Bonanza Assignment #3 RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 3/04/2017
///@Description:the user selects the movie from a drop-down list 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_MovieBonanza_RAILL
{
    public partial class SelectionForm : Form
    {
        public splashScreen PreviousForm { get; set; }

        public SelectionForm()
        {
            InitializeComponent();
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            titleTextBox.Text = Convert.ToString(MovieListBox.Text);
            _movieImage();
           // _movieCategory();
            nextButton.Enabled = true;

        }

        private void _movieImage()
        {
            if (titleTextBox.Text == "Cedar Rapids")
            {
                categoryTextBox.Text = "Comedy";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.cedarRapids;
                Program.MyMovieInfo.image = Properties.Resources.cedarRapids;
            }
            else if (titleTextBox.Text == "Company Men")
            {
                categoryTextBox.Text = "Drama";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.companyMen;
                Program.MyMovieInfo.image = Properties.Resources.companyMen;
            }
            else if (titleTextBox.Text == "Death Race 2")
            {
                categoryTextBox.Text = "Action";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.deathRace2;
                Program.MyMovieInfo.image = Properties.Resources.deathRace2;
            }
            else if (titleTextBox.Text == "Footloose")
            {
                categoryTextBox.Text = "New Release";
                costTextBox.Text = "$4.99";
                selectionPictureBox.Image = Properties.Resources.Footloose;
                Program.MyMovieInfo.image = Properties.Resources.Footloose;
            }
            else if (titleTextBox.Text == "Gnomeo and Juliet")
            {
                categoryTextBox.Text = "Family";
                costTextBox.Text = "$0.99";
                selectionPictureBox.Image = Properties.Resources.gnomeoJuliet;
                Program.MyMovieInfo.image = Properties.Resources.gnomeoJuliet;
            }
            else if (titleTextBox.Text == "I am Number Four")
            {
                categoryTextBox.Text = "Sci-Fi";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.numberFour;
                Program.MyMovieInfo.image = Properties.Resources.numberFour;
            }
            else if (titleTextBox.Text == "Just Go With It")
            {
                categoryTextBox.Text = "Comedy";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.justGoWithIt;
                Program.MyMovieInfo.image = Properties.Resources.justGoWithIt;
            }
            else if (titleTextBox.Text == "No Strings Attached")
            {
                categoryTextBox.Text = "Comedy";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.noStrings;
                Program.MyMovieInfo.image = Properties.Resources.noStrings;
            }
            else if (titleTextBox.Text == "Real Steel")
            {
                categoryTextBox.Text = "Action";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.realSteel;
                Program.MyMovieInfo.image = Properties.Resources.realSteel;
            }
            else if (titleTextBox.Text == "Sanctum")
            {
                categoryTextBox.Text = "Action";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.sanctum;
                Program.MyMovieInfo.image = Properties.Resources.sanctum;
            }
            else if (titleTextBox.Text == "Season of the Witch")
            {
                categoryTextBox.Text = "Sci-Fi";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.seasonOfTheWitch;
                Program.MyMovieInfo.image = Properties.Resources.seasonOfTheWitch;
            }
            else if (titleTextBox.Text == "The Dilemma")
            {
                categoryTextBox.Text = "Comedy";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.dilemma;
                Program.MyMovieInfo.image = Properties.Resources.dilemma;
            }
            else if (titleTextBox.Text == "The Eagle")
            {
                categoryTextBox.Text = "Action";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.eagle;
                Program.MyMovieInfo.image = Properties.Resources.eagle;
            }
            else if (titleTextBox.Text == "The Green Hornet")
            {
                categoryTextBox.Text = "Action";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.greenHornet;
                Program.MyMovieInfo.image = Properties.Resources.greenHornet;
            }
            else if (titleTextBox.Text == "The Mechanic")
            {
                categoryTextBox.Text = "Action";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.mechanic;
                Program.MyMovieInfo.image = Properties.Resources.mechanic;
            }
            else if (titleTextBox.Text == "The Other Woman")
            {
                categoryTextBox.Text = "Comedy";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.otherWoman;
                Program.MyMovieInfo.image = Properties.Resources.otherWoman;
            }
            else if (titleTextBox.Text == "The Rite")
            {
                categoryTextBox.Text = "Horror";
                costTextBox.Text = "$2.99";
                selectionPictureBox.Image = Properties.Resources.rite;
                Program.MyMovieInfo.image = Properties.Resources.rite;
            }
            else if (titleTextBox.Text == "The Roommate")
            {
                categoryTextBox.Text = "Thriller";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.roommate;
                Program.MyMovieInfo.image = Properties.Resources.roommate;
            }
            else if (titleTextBox.Text == "The Way Back")
            {
                categoryTextBox.Text = "Drama";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.wayBack;
                Program.MyMovieInfo.image = Properties.Resources.wayBack;
            }
            else if (titleTextBox.Text == "Waiting for Forever")
            {
                categoryTextBox.Text = "Drama";
                costTextBox.Text = "$1.99";
                selectionPictureBox.Image = Properties.Resources.waitingForForever;
                Program.MyMovieInfo.image = Properties.Resources.waitingForForever;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.MyMovieInfo.title = titleTextBox.Text;
                Program.MyMovieInfo.category = categoryTextBox.Text;
                Program.MyMovieInfo.cost = costTextBox.Text;
            }
            catch
            {
                MessageBox.Show("All Fields Are Mandatory");
                return;
            }
            // 1. Instantiate the next form
            OrderForm orderForm = new OrderForm();
            orderForm.Show();

            //hides current form
            this.Hide();
        }
        private void SaveSelection()
        {
            Program.MyMovieInfo.title = titleTextBox.Text;
            Program.MyMovieInfo.cost = costTextBox.Text.TrimStart('$');
            Program.MyMovieInfo.category = categoryTextBox.Text;

        }
        
        //save data so when Back is used, previous selections will still apply
        public void PreviousFormSelections()
        {
            titleTextBox.Text = Program.MyMovieInfo.title;
            costTextBox.Text = Program.MyMovieInfo.cost;
            categoryTextBox.Text = Program.MyMovieInfo.category;
            
            MovieListBox.Text = titleTextBox.Text;
        }
    }
}
