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
        //public SelectionForm previousForm { get; set; }

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
            // 1. Instantiate the previous form
            SelectionForm selectionForm = new SelectionForm();
            selectionForm.Show();
           
        }
    }
}
