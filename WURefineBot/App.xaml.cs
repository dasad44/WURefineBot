using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WURefineBot.Core.Interfaces.Menagers;
using WURefineBot.Core.Interfaces.QueueCreators;
using WURefineBot.Core.Interfaces.Services;
using WURefineBot.Core.Menagers;
using WURefineBot.Core.QueueCreators;
using WURefineBot.Core.Services;
using WURefineBot.Infrastructure.AI;
using WURefineBot.Infrastructure.Imaging;
using WURefineBot.Infrastructure.Interfaces;

namespace WURefineBot
{

    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            serviceCollection.AddScoped<IScreenHandler, ScreenHandler>();
            serviceCollection.AddScoped<IResourcesManager, ResourceManager>();
            serviceCollection.AddScoped<IRefineQueue, RefineQueue>();
            serviceCollection.AddScoped<IRefineService, RefineService>();
            ServiceProvider = serviceCollection.BuildServiceProvider();
            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
        }
    }
}
