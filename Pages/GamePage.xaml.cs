using GameXO_MAUI.ViewModels;

namespace GameXO_MAUI.Pages;

public partial class GamePage : ContentPage
{
	public GamePage(GameViewModel gvm)
	{
		InitializeComponent();
		this.BindingContext = gvm;
	}
}