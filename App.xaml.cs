using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proect_9.Model;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Proect_9
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddDbContext<ProductDbContext>(p =>
            {
                p.UseSqlite("Data Source = Tesk7.db");
            });
            services.AddSingleton<MainWindow>();
            serviceProvider = services.BuildServiceProvider();
        }

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }

    }

}
