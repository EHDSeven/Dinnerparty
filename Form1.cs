using System;
using System.Windows.Forms;

namespace dinnerparty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetNumberOfPeople(5);
            dinnerParty.SetHealthyOption(healthyOption.Checked);
            DisplayDinnerPartyCost();
        }

    
        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyOption.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetNumberOfPeople((int)numericUpDown1.Value);
            DisplayDinnerPartyCost();
        }

        private void fancyDec_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetFancyOption(CheckboxFancyDec.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyOption_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyOption.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
