using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlanner
{
    public partial class Planner : Form
    {
        public Planner()
        {
            InitializeComponent();
           
        }

        bool events = false;
        bool changedate = false;
        bool changePlace = false;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dTP = sender as DateTimePicker;
            if (dTP.Value < DateTime.Now)
            {
                dTP.Value = DateTime.Now;
                changedate = true;
            }

        }


        private void priority_MouseClick(object sender, MouseEventArgs e)
        {
            var pr = sender as TextBox;
           
            if (pr.Text == "Low")
            {
                pr.Text = "Normal";
                pr.BackColor = Color.Yellow;
            }
            else if (pr.Text == "Normal")
            {
                pr.Text = "High";
                pr.BackColor = Color.Red;
            }
            else if (pr.Text == "High")
            {
                pr.Text = "Low";
                pr.BackColor = Color.Lime;
            }
        }

        private void eventName_TextChanged(object sender, EventArgs e)
        {
            events = true;
        }

        private void place_TextChanged(object sender, EventArgs e)
        {
            changePlace = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            var tb = sender as TextBox;
          

            foreach (Control item in Controls )
            {
                if (item is TextBox && item.Text != "" && item.Text != "Low" && item.Text != "Normal" && item.Text != "High" && item.Text != null)
                {
                    item.ResetText();
                }
                else if (item.Text == "Normal" || item.Text == "High")
                {
                    item.Text = "Low";
                    item.BackColor = Color.Lime;
                }
          
            }

            var dt = sender as DateTimePicker;
            foreach (Control item in Controls)
            {
                if (item is DateTimePicker )
                {
                    dt.Value = DateTime.Now;
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
