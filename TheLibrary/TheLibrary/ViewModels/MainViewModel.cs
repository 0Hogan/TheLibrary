namespace TheLibrary.ViewModels;

public class MainViewModel : ViewModelBase
{
#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia!";
    public string HelloWorld => "Hello, world!";
#pragma warning restore CA1822 // Mark members as static
}