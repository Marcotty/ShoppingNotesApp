using Microsoft.Extensions.Logging;
using StockManager.Pages;
using StockManager.Services;

namespace ShoppingNotesApp
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IStockService, StockService>();
            builder.Services.AddSingleton<App>();

            Routing.RegisterRoute("ShoppingPage", typeof(ShoppingPage));
            builder.Services.AddTransient<ShoppingPage>();
            return builder.Build();
        }
    }
}
