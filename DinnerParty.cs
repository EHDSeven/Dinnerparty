namespace dinnerparty
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int NumberofPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations = false;

        public void SetNumberOfPeople(int peoples)
        {
            NumberofPeople = peoples;
        }


        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void SetFancyOption(bool isFancy)
        {
            fancyDecorations = isFancy;
        }

        private void CalculateCostOfDecorations()
        {
            if (fancyDecorations)
            {
                CostOfDecorations = (NumberofPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberofPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            CalculateCostOfDecorations();

            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberofPeople);

            if (healthyOption)
            {
                return totalCost * .95m;
            }
            else
            {
                return  totalCost;
            }
        }
        }


    }

