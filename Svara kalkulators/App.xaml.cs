using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Svara_kalkulators.DbConnections;
using Svara_kalkulators.MVVM.ViewModel;
using System.Configuration;
using System.IO;
using System.Windows;

namespace Svara_kalkulators
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static IConfigurationRoot config;

        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MainWindow>();
        }
        private static void Initialize()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            config = builder.Build();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Initialize();

            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow?.Show();
        }
    }
}
