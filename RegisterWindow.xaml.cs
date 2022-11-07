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
using System.Windows.Shapes;

namespace WpfUI1;
/// <summary>
/// Логика взаимодействия для RegisterWindow.xaml
/// </summary>
public partial class RegisterWindow : Window
{
    public RegisterWindow()
    {
        InitializeComponent();
    }

    private void Register_Click(object sender, RoutedEventArgs e)
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
}
