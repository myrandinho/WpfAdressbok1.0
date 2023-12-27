
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WpfAdressbok1._0.ViewModels;
using WpfAdressbok1._0.Views;

namespace WpfAdressbok1._0;


public partial class App : Application
{
    private IHost? _host;

    public App()
    {
        _host = Host.CreateDefaultBuilder()
            .ConfigureServices(services =>
            {
                services.AddSingleton<MainWindow>();
                services.AddSingleton<MainViewModel>();
                services.AddTransient<MainMenuModel>();
                services.AddTransient<MainMenuView>();
                services.AddTransient<AddContactModel>();
                services.AddTransient<AddContactView>();
                services.AddTransient<ShowAllContactsModel>();
                services.AddTransient<ShowAllContactsView>();
                services.AddTransient<ShowSpecificContactModel>();
                services.AddTransient<ShowSpecificContactView>();
                services.AddTransient<UpdateContactModel>();
                services.AddTransient<UpdateContactView>();
                services.AddTransient<DeleteContactModel>();
                services.AddTransient<DeleteContactView>();
                
                

            })
            .Build();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        _host!.Start();

        var mainWindow = _host!.Services.GetRequiredService<MainWindow>();
        mainWindow.Show();
    }
}
