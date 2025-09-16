using Microsoft.Extensions.Logging;
using PeopleManager.App.ViewModels;
using PeopleManager.App.Views;
using PeopleManager.Core.Repositories;
using PeopleManager.Core.Services;
using PeopleManager.Core.Data;

namespace PeopleManager.App
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

            //builder.Services.AddSingleton<PeopleService>();

            builder.Services.AddSingleton<IPeopleRepository, PeopleInMemoryRepository>();
            builder.Services.AddTransient<PeopleView>().AddTransient<PeopleViewModel>().AddTransient<PeopleService>();

            return builder.Build();
        }
    }
}
