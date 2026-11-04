using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            BicycleForm bicycleForm = new BicycleForm();
            bicycleForm.Show();
            this.Hide();
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            MushroomForm mushroomForm = new MushroomForm();
            mushroomForm.Show();
            this.Hide();
        }
    }
}

