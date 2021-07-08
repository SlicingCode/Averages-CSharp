using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Averages
{
    public partial class frmAverages : Form
    {
        public frmAverages()
        {
            InitializeComponent();
        }

        private void btnAverages_Click(object sender, EventArgs e)
        {
            int mark1;
            int mark2;
            int mark3;

            double average;

            mark1 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter a mark", "Averages", ""));
            mark2 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter a mark", "Averages", ""));
            mark3 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("please enter a mark", "Averages", ""));

            average = (double) (mark1 + mark2 + mark3) / 3;

            MessageBox.Show("The average mark is \n" + average.ToString());

        }
    }
}
