using CommunityToolkit.Mvvm.ComponentModel;

namespace Audill.ViewModels;

public class ManageViewModel : ObservableObject
{
    public ObservableObject CurrentViewModel { get; set; }
}