using Avalonia.Controls;
using Avalonia.Interactivity;
using 爱心攻击.Amusing;

namespace 爱心攻击.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        _ = new Love().GenerateHeart();
    }
}