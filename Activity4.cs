using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Activity4 : Form
    {
        //Angel McDaniel
        public Activity4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textSeconds.Text == "")
            {
                MessageBox.Show("Please enter seconds elapsed.");
            }
            else
            {
                int seconds = Convert.ToInt32(textSeconds.Text);

                if (seconds >= 86400)
                {
                    int days = seconds / 86400;
                    textResults.Text = days + " days";
                }
                else if (seconds >= 3600)
                {
                    int hours = seconds / 3600;
                    textResults.Text = hours + " hours";
                }
                else if (seconds >= 60)
                {
                    int minutes = seconds / 60;
                    textResults.Text = minutes + " minutes";
                }
                else
                {
                    textResults.Text = seconds + " seconds";
                }
            }
        }
    }
}
