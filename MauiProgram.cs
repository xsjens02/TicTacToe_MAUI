using GameXO_MAUI.Pages;
using GameXO_MAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace GameXO_MAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		// Register ViewModels 
		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<GameViewModel>();
		builder.Services.AddTransient<HighScoreViewModel>();

        // Register Pages 
        builder.Services.AddTransient<MainPage>(); 
        builder.Services.AddTransient<GamePage>();  
        builder.Services.AddTransient<HighScorePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
