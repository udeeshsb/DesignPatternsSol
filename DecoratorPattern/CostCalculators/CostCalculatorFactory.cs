namespace DecoratorPattern.Decorators
{
    public class CostCalculatorFactory
    {
        //public ICostCalculator GetCostCalculator()
        //{
        //    var costCalculator = new CostCalculator();
        //    return costCalculator;
        //}
        public ICostCalculator GetCostCalculator(string countryCode, ICostCalculator costCalculator)
        {
            switch (countryCode)
            {
                case "IN":
                    costCalculator = new SalesTaxDecorator
                        (2.5, new CurrencyConversionDecorator(countryCode, costCalculator));
                    return costCalculator;
                default:
                    costCalculator = new CostCalculator();
                    return costCalculator;
            }
        }
    }
}

