

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using WpfAdressbok1._0.Views;

namespace WpfAdressbok1._0.ViewModels;

public partial class MainMenuModel : ObservableObject
{

    private readonly IServiceProvider _sp;

    public MainMenuModel(IServiceProvider sp)
    {
        _sp = sp;
    }




    [RelayCommand]

    private void NavigateToAddContact()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<AddContactModel>();
    }

    [RelayCommand]

    private void NavigateToShowAllContacts()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<ShowAllContactsModel>();
    }

    [RelayCommand]

    private void NavigateToSpecificContact()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<ShowSpecificContactModel>();
    }

    [RelayCommand]

    private void NavigateToUpdateContact()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<UpdateContactModel>();
    }

    [RelayCommand]

    private void NavigateToDeleteContact()
    {
        var mainViewModel = _sp.GetRequiredService<MainViewModel>();
        mainViewModel.CurrentViewModel = _sp.GetRequiredService<DeleteContactModel>();
    }

    [RelayCommand]

    private void ExitApplication()
    {
        Environment.Exit(0);
    }
}
