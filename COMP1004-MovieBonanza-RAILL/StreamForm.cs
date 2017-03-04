///@Movie Bonanza Assignment #3 RAILL  COMP1004-02-w2017
///@Tiffany Raill
///@200264388
///App Creation Date: 3/04/2017
///@Description:the user is notified that his credit card has been charged and the video streaming is about to begin
///the dollar amount showing is drawn from orderForm and the movie selection is drawn from SelectionForm
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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
