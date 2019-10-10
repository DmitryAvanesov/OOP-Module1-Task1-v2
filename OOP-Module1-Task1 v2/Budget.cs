using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Budget
    {
        private int goldAmount;
        private int woodAmount;
        private Label goldLabel;
        private Label woodLabel;

        public Budget(Label newGoldLabel, Label newWoodLabel)
        {
            goldLabel = newGoldLabel;
            woodLabel = newWoodLabel;
        }

        public void IncreaseBudget(Gold goldIngot)
        {
            goldAmount += goldIngot.Amount;
            UpdateBudgetLabels();
        }

        public void IncreaseBudget(Wood woodPlank)
        {
            woodAmount += woodPlank.Amount;
            UpdateBudgetLabels();
        }

        public void DecreaseBudget(Gold goldIngot)
        {

        }

        public void DecreaseBudget(Wood woodPlank)
        {

        }

        private void UpdateBudgetLabels()
        {
            goldLabel.Text = string.Format("Gold: {0}",
                goldAmount.ToString());
            woodLabel.Text = string.Format("Wood: {0}",
               woodAmount.ToString());
        }
    }
}
