using BMICalculator.MVVM.Views;
using BMICalculator.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace BMICalculator;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new BMIView());
	}
}