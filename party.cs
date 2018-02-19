namespace dinnerparty
{
    class Party
    {
        const int CostOfFoodPerPerson = 25;
        private bool fancyDecorations;
        public decimal CostOfDecorations = 0;

        /// stripped out of the other classes, non personal


        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }
        // This is a contsructor that the dinner and birthday party did previosly and will inherit

        private int numberOfPeople;
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        // this needs to be VIRTUAL as BirthdayPARTY needs to overwrite, number of people changes cake size

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public virtual decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberofPeople);

            if (NumberofPeople == 12)
            {
                return TotalCost + 100m;
            }
            else
            {
                return TotalCost;
            }
        }
    }
}
