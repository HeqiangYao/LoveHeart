using CommunityToolkit.Mvvm.ComponentModel;

namespace 爱心攻击.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty] private string _greeting = "Welcome to Avalonia!";
}