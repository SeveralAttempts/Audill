using System.Configuration;
using System.Data;
using System.Windows;
using Audill.Services;
using Audill.ViewModels;
using Audill.Views.Windows;
using Microsoft.Extensions.DependencyInjection;
using Audill.Services.Interfaces;
using Audill.ViewModels.Interfaces;

namespace Audill;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private IServiceProvider _serviceProvider;

    public App()
    {
        var services = new ServiceCollection();

        services.AddSingleton<IAuthService, AuthService>();
        services.AddSingleton<IAuthViewModel, AuthViewModel>();
        services.AddTransient<AuthWindow>();
        
        _serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);
        var initialWindow = _serviceProvider.GetRequiredService<AuthWindow>();
        initialWindow.DataContext = _serviceProvider.GetRequiredService<IAuthViewModel>();
        initialWindow.Show();
    }
}