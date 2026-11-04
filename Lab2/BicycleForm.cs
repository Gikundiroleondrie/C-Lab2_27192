using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string startText = txtStart.Text.Trim();
            string endText = txtEnd.Text.Trim();

            bool startOk = int.TryParse(startText, out int start);
            bool endOk = int.TryParse(endText, out int end);

            if (!startOk || !endOk)
            {
                txtTotal.Text = "";
                MessageBox.Show("Please enter whole numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (start < 0 || start > 23 || end < 1 || end > 24)
            {
                txtTotal.Text = "";
                MessageBox.Show("Start must be 0-23 and end must be 1-24.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (start >= end)
            {
                txtTotal.Text = "";
                MessageBox.Show("Start time must be less than end time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;

            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7)
                {
                    total += 500;
                }
                else if (hour < 14)
                {
                    total += 1000;
                }
                else if (hour < 19)
                {
                    total += 1500;
                }
                else if (hour < 21)
                {
                    total += 1000;
                }
                else
                {
                    total += 500;
                }
            }

            txtTotal.Text = total + " RWF";
            MessageBox.Show("Rental from " + start + "h to " + end + "h\nTotal to pay: " + total + " RWF", "Bicycle Rental", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm();
            chooseForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

