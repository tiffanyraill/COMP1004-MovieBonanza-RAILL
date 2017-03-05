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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        //disable the timer after first instance and hide splashscreen
        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {

            // 1. Instantiate the next form
            SelectionForm selectionForm = new SelectionForm();

            // 2. pass a reference to the current form to the next form
            selectionForm.PreviousForm = this;

            this.splashScreenTimer.Enabled = false;
            selectionForm.Show();
            this.Hide();


        }
    }
}
