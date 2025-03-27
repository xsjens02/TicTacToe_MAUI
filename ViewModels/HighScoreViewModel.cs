using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GameXO_MAUI.ViewModels
{
    [QueryProperty(nameof(BestPlayer), "bestPlayer")]
    public partial class HighScoreViewModel : ObservableObject
    {
        [ObservableProperty]
        private string bestPlayer;

        public HighScoreViewModel()
        {
            BestPlayer = "";
        }

        [RelayCommand]
        private async Task GoBack() => await Shell.Current.GoToAsync("//MainPage");
    }
}
