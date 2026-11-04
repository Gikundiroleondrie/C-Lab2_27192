using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MushroomForm : Form
    {
        public MushroomForm()
        {
            InitializeComponent();
        }

        private bool TryParseYesNo(string input, out bool result)
        {
            string reply = input.Trim().ToLower();
            if (reply == "yes" || reply == "y")
            {
                result = true;
                return true;
            }
            if (reply == "no" || reply == "n")
            {
                result = false;
                return true;
            }
            result = false;
            return false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string playerName = txtName.Text.Trim();
            if (playerName == "")
            {
                MessageBox.Show("Please enter your name.", "Missing Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!TryParseYesNo(txtRing.Text, out bool hasRing))
            {
                MessageBox.Show("Please answer yes or no for Question 1 (Does your mushroom have a ring?).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRing.Focus();
                return;
            }

            if (!TryParseYesNo(txtConvexCup.Text, out bool hasConvexCup))
            {
                MessageBox.Show("Please answer yes or no for Question 2 (Does your mushroom have a convex cup?).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConvexCup.Focus();
                return;
            }

            if (!TryParseYesNo(txtForest.Text, out bool growsInForest))
            {
                MessageBox.Show("Please answer yes or no for Question 3 (Does your mushroom grow in a forest?).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtForest.Focus();
                return;
            }

            if (!TryParseYesNo(txtGills.Text, out bool hasGills))
            {
                MessageBox.Show("Please answer yes or no for Question 4 (Does your mushroom have gills?).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGills.Focus();
                return;
            }

            if (!TryParseYesNo(txtRedCap.Text, out bool hasRedCap))
            {
                MessageBox.Show("Please answer yes or no for Question 5 (Does your mushroom have a bright/red cap?).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRedCap.Focus();
                return;
            }

            if (!TryParseYesNo(txtEdible.Text, out bool isEdible))
            {
                MessageBox.Show("Please answer yes or no for Question 6 (Is your mushroom edible?).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEdible.Focus();
                return;
            }

            string answer;

            if (hasRing && hasConvexCup)
            {
                if (growsInForest)
                {
                    if (hasRedCap && !isEdible)
                    {
                        answer = "Amanite tue-mouche";
                    }
                    else
                    {
                        answer = "Amanite des Cesars";
                    }
                }
                else
                {
                    answer = "Agaric Jaunissant";
                }
            }
            else if (hasRing && !hasConvexCup)
            {
                if (isEdible)
                {
                    answer = "Coprin chevelu";
                }
                else
                {
                    answer = "Lepiota";
                }
            }
            else if (!hasRing && hasConvexCup)
            {
                if (growsInForest)
                {
                    answer = "Pied bleu";
                }
                else
                {
                    answer = "Russule";
                }
            }
            else
            {
                if (hasGills)
                {
                    answer = "Girolle";
                }
                else if (growsInForest)
                {
                    answer = "Cepe de bordeau";
                }
                else
                {
                    answer = "Morille";
                }
            }

            txtResult.Text = answer;
            MessageBox.Show("Got it, " + playerName + "! You were thinking of: " + answer, "Mushroom Detective", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtRing.Text = "";
            txtConvexCup.Text = "";
            txtForest.Text = "";
            txtGills.Text = "";
            txtRedCap.Text = "";
            txtEdible.Text = "";
            txtResult.Text = "";
            txtName.Focus();
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
