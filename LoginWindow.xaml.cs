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
/// Логика взаимодействия для LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    public LoginWindow()
    {
        InitializeComponent();
    }

    private void LogIn_Click(object sender, RoutedEventArgs e)
    {
        MainToDoWindow ToDoWindow = new MainToDoWindow()
        {
            WindowStartupLocation = WindowStartupLocation,
            WindowState = WindowState,
            Height = Height,
            Width = Width,
            Left = Left,
            Top = Top
        };
        ToDoWindow.Show();
        this.Close();
    }
}
