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
    //ObservableCollection<string> projects;
    public ObservableCollection<Project> Projects
    {
        get; set;
    }
    public MainToDoWindow()
    {

       

        InitializeComponent();
        Projects = new ObservableCollection<Project>
        {
            new Project {ProjectName = "Test1", Color = "#00955C"},
            new Project {ProjectName = "Test2", Color = "#FF9523"},
            new Project {ProjectName = "Test3", Color = "#E01515"},
            new Project {ProjectName = "Test4", Color = "#FB4E71"}
        };
        //projects = new ObservableCollection<string> { "Today", "Favorite", "Test" };
        //projectsList.ItemsSource = projects;
        projectsList.ItemsSource = Projects;
    }
    private void projectsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Project p = (Project)projectsList.SelectedItem;
        System.Windows.MessageBox.Show(p.ProjectName);
    }
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if (projectTextBox.Text.Length > 0)
        {
            string proj = projectTextBox.Text;
            // добавление нового объекта
            Projects.Add(new Project { ProjectName = proj, Color = "#00955c" });
            projectTextBox.Text = "";
        }

    }
}
public class Project
{
    public string? ProjectName
    {
        get; set;
    }
    public string? Color
    {
        get; set;
    }

}