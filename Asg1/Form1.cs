using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Reminder dig = new Reminder();
        private DateTime myRemTime;
        private void LlbUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(dig.ShowDialog()==DialogResult.OK)
            {
                myRemTime = dig.Mycalender.SelectionStart.AddHours(dig.MyTimePicker.Value.Hour).AddMinutes(dig.MyTimePicker.Value.Minute).AddSeconds(dig.MyTimePicker.Value.Second);
                this.Visible = false;
            }
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(myRemTime.CompareTo(DateTime.Now)<0)
            {
                this.Visible = true;
            }
        }
    }
}
