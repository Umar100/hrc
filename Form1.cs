using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dob.Value;
            try
            {
                Control ctrl = new Control(nametxtbx.Text, dt.Month.ToString(), dt.Day.ToString(), dt.Year.ToString());
                resultlbl.Text = "Mr/Mrs " + nametxtbx.Text + ", you are " + ctrl.GetAge() + " years old and your maximum heart rate is " + ctrl.GetMaxHeartRate() + " and your target heart rate is " + ctrl.GetTargetHeartRate();
            }
            catch (Exception ex)
            {
                resultlbl.Text = ex.Message;
            }
        }
    }
}
