using GameXO_MAUI.ViewModels;

namespace GameXO_MAUI.Pages;

public partial class HighScorePage : ContentPage
{
	public HighScorePage(HighScoreViewModel hsvm)
	{
		InitializeComponent();
		this.BindingContext = hsvm;
	}
}