///@Movie Bonanza Assignment #3 RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 3/04/2017
///@Description:the user is shown the cost of the movie
///the dollar amount is based on the genre of movie selected
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
    public partial class OrderForm : Form
    {
        SelectionForm selectionForm = new SelectionForm();

        public OrderForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            //hide current form
            this.Hide();
            
            selectionForm.Show();
            // Instantiate the previous form
            selectionForm.PreviousFormSelections();

        }

        private void streamButton_Click(object sender, EventArgs e)
        {
            //instantiate the next form
            StreamForm streamForm = new StreamForm();

            streamForm.Show();
            //hide current form
            this.Hide();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // STEP 1: Create a new form
                AboutForm aboutForm = new AboutForm();
                //STEP 2: Show the about form with ShowDialogue (a modal method that displays the form)
                aboutForm.ShowDialog();
            }
        }
    }
}
