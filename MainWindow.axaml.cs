using Avalonia.Controls;

namespace CapthaApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void LoginButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) 
    { 
        var tuple = Captcha.CreateImage(300, 100, 5);
            var CaptchaImage = this.FindControl<Image>("CaptchaImage");
            CaptchaImage.Source = tuple.image;
            var captcha = tuple.captcha;
    }
}