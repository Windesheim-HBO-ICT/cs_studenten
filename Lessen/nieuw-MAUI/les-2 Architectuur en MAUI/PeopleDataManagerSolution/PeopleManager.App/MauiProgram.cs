using Microsoft.Extensions.Logging;
using PeopleManager.App.ViewModels;
using PeopleManager.App.Views;
using PeopleManager.Core.Repositories;
using PeopleManager.Core.Services;
using PeopleManager.Data.Sqlite;
using Microsoft.Maui.Storage;
using System.Linq.Expressions;

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

            //Next code will result into a path like:
            //"C:\Users\xxxx\AppData\Local\User Name\com.companyname.peoplemanager.app\Data\people.db3"

            string dbPath = Path.Combine(FileSystem.Current.AppDataDirectory, "people.db3");
            string connectionString = $"Data Source={dbPath}";

            builder.Services.AddSingleton<IPeopleRepository, PeopleSqliteRepository>(s => ActivatorUtilities.CreateInstance<PeopleSqliteRepository>(s, connectionString));

            builder.Services.AddTransient<PeopleView>().AddTransient<PeopleViewModel>().AddTransient<PeopleService>();

            return builder.Build();
        }
    }
}
