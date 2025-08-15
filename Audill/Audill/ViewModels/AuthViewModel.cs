using Audill.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Audill.ViewModels;

public partial class AuthViewModel : ObservableObject
{
    private readonly IAuthService _userService;

    public AuthViewModel(IAuthService userService)
    {
        _userService = userService;
    }

    [RelayCommand]
    private void LoadUsers()
    {
        _userService.GetUsers();
    }
}