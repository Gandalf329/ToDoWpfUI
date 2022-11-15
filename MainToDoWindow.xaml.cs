using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Wpf.Ui.Common;
using Wpf.Ui.Controls.Interfaces;
using Wpf.Ui.Controls;

namespace WpfUI1;
/// <summary>
/// Логика взаимодействия для MainToDoWindow.xaml
/// </summary>

public partial class MainToDoWindow : Window
{
    ObservableCollection<string> projects;
    public MainToDoWindow()
    {

       

        InitializeComponent();
        projects = new ObservableCollection<string> { "Today", "Favorite", "Test" };
        projectsList.ItemsSource = projects;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if(projectTextBox.Text.Length > 0)
        {
            string phone = projectTextBox.Text;
            // добавление нового объекта
            projects.Add(phone);
            projectTextBox.Text = "";
        }
        
    }
}
public class Task
{
    public string? Project
    {
        get; set;
    }
    public string? Category
    {
        get; set;
    }
    public string? TaskName
    {
        get; set;
    }
}