namespace TipCalculator.Core.Services
{
	public class CalculationService : ICalculationsService
	{
		public double Tip(double subTotal, double generosity)
		{
			return (subTotal * generosity) / 100.0;
		}
	}
}
