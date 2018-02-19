namespace dinnerparty
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        // only thing that is specific to this class i.e booze


        public DinnerParty(int numberOfPeople, bool healthyOption, bool Fancydecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(Fancydecorations);
        }

        // constructor for dinner party yo

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

        // this doesnt need touched it can stay

        public virtual decimal CalculateCost(bool healthyOption)
        {
            DinnerParty dinner = new DinnerParty(5, true, true);
            decimal cost1 = dinner.CalculateCost(true);
            decimal cost2 = dinner.CalculateCost();

            decimal totalCost = CostOfDecorations + (CostOfBeveragesPerPerson * NumberofPeople);

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

