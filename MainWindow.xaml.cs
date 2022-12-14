using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUI1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SignIn_Click(object sender, RoutedEventArgs e)
    {
        LoginWindow loginWindow = new LoginWindow()
        {
            WindowStartupLocation = WindowStartupLocation,
            WindowState = WindowState,
            Height = Height,
            Width = Width,
            Left = Left,
            Top = Top
        };
        loginWindow.Show();
        this.Close();

    }

    private void Register_Click(object sender, RoutedEventArgs e)
    {

        RegisterWindow registerWindow = new RegisterWindow()
        {
            WindowStartupLocation = WindowStartupLocation,
            WindowState = WindowState,
            Height = Height,
            Width = Width,
            Left = Left,
            Top = Top
        };
        
        registerWindow.Show();
        this.Close();
    }
}
