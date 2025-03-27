using GameXO_MAUI.ViewModels;

namespace GameXO_MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel mvm)
        {
            InitializeComponent();
            this.BindingContext = mvm;
        }
    }
}