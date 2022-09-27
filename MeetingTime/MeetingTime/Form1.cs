using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeetingTime {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            DateTime date, dateTime;
            date = dtTmPckrDate.Value.Date;
            dateTime = dtTmPckrTime.Value;
            date = date.AddHours(dateTime.Hour);
            date = date.AddMinutes(dateTime.Minute);
            date = date.AddSeconds(dateTime.Second);

            lblMeeting.Text = date.ToString();
            lblCurrent.Text = today.ToString();
            if (date < today) lblEvaluate.Text = "You have missed it!";
            else {
                TimeSpan remainTime = date.Subtract(today);

                lblEvaluate.Text = "Remains " + remainTime.Days.ToString() + " days " +
                                             remainTime.Hours.ToString() + " hours " + 
                                             remainTime.Minutes.ToString() + " minutes";
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            lblCurrent.Text = "";
            lblEvaluate.Text = "";
            lblMeeting.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }    

    }
}
