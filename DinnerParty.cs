namespace dinnerparty
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;

        // only thing that is specific to this class i.e booze
        public DinnerParty(int numberOfPeople, bool healthyOption, bool FancyDecorations)
            :base(numberOfPeople, FancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(FancyDecorations);
        }

        // constructor for dinner party yo
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                this.CostOfBeveragesPerPerson = 5.00M;
            else
                this.CostOfBeveragesPerPerson = 20.00M;
        }

        // this doesnt need touched it can stay
        public virtual decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = this.CostOfDecorations + (this.CostOfBeveragesPerPerson * this.NumberOfPeople);

            if (healthyOption)
                return totalCost * .95m;
            else
                return  totalCost;
        }
    }
}

