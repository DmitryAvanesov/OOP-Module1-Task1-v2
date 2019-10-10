using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Budget
    {
        public int goldAmount = 70;
        public int woodAmount = 130;
        private Label goldLabel;
        private Label woodLabel;

        public Budget(Label newGoldLabel, Label newWoodLabel)
        {
            goldLabel = newGoldLabel;
            woodLabel = newWoodLabel;
            UpdateBudgetLabels();
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

        public void DecreaseBudget(int gold, int wood)
        {
            goldAmount -= gold;
            woodAmount -= wood;
            UpdateBudgetLabels();
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
