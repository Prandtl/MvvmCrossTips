namespace TipCalculator.Core.Services
{
	public interface ICalculationsService
	{
		double Tip(double subTotal, double generosity);
	}
}
