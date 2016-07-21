using MvvmCross.Core.ViewModels;
using TipCalculator.Core.Services;

namespace TipCalculator.Core.ViewModels
{
	public class FirstViewModel
		: MvxViewModel
	{
		private readonly ICalculationsService _calculationsService;

		public FirstViewModel(ICalculationsService calculationsService)
		{
			_calculationsService = calculationsService;
			_generosity = 20;
			_subTotal = 100;
			Recalc();
		}

		private double _subTotal;
		public double SubTotal
		{
			get { return _subTotal; }
			set { SetProperty(ref _subTotal, value); RaisePropertyChanged((() => SubTotal)); Recalc();}
		}

		private double _generosity;
		public double Generosity
		{
			get { return _generosity; }
			set { SetProperty(ref _generosity, value); RaisePropertyChanged((() => Generosity)); Recalc();}
		}

		private double _tip;
		public double Tip
		{
			get { return _tip; }
			set { SetProperty(ref _tip, value); RaisePropertyChanged((() => Tip)); }
		}

		private double _total;
		public double Total
		{
			get { return _total; }
			set { SetProperty(ref _total, value); RaisePropertyChanged((() => Total)); }
		}

		private void Recalc()
		{
			Tip = _calculationsService.Tip(SubTotal, Generosity);
			Total = SubTotal + Tip;
		}
	}
}
