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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Diagnostics;

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
    public ObservableCollection<Category> Categories
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
        Categories = new ObservableCollection<Category>
        {
            new Category {Project = "Test1", CategoryName = "Cat1", Visible="Visible"},
            new Category {Project = "Test1", CategoryName = "Cat2", Visible="Visible"},
            new Category {Project = "Test2", CategoryName = "Cat3", Visible="Visible"},
            new Category {Project = "Test3", CategoryName = "Cat4", Visible="Visible"},
            new Category {Project = "Test4", CategoryName = "Batman", Visible="Visible"},
            new Category {Project = "Test4", CategoryName = "Spider", Visible="Visible"},
            new Category {Project = "Test4", CategoryName = "Lakers", Visible="Visible"},
            new Category {Project = "Test4", CategoryName = "Lebron", Visible="Visible"}
        };
        //projects = new ObservableCollection<string> { "Today", "Favorite", "Test" };
        //projectsList.ItemsSource = projects;
        projectsList.ItemsSource = Projects;
        categoriesList.ItemsSource = Categories;
    }
    private void projectsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Project p = (Project)projectsList.SelectedItem;
        foreach (var item in Categories)
        {
            item.Select = "false";
            if(p.ProjectName != item.Project)
            {
                item.Visible = "Collapsed";
            }
            else
            {
                item.Visible = "Visible";
            }
        }
    }
    private void categoriesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Category p = (Category)categoriesList.SelectedItem;
        System.Windows.MessageBox.Show(p.CategoryName);
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
public class Category : INotifyPropertyChanged
{
    private string? visible = "Visible";
    private string? select = "false";
    public string? Project
    {
        get; set;
    }

    public string? CategoryName
    {
        get; set;
    }
    public string? Visible
    {
        get
        {
            return visible;
        }
        set
        {
            visible = value;
            OnPropertyChanged("Visible");
        }
    }
    public string? Select
    {
        get
        {
            return select;
        }
        set
        {
            select = value;
            OnPropertyChanged("Select");
        }
    }
    public event PropertyChangedEventHandler PropertyChanged;
    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }
}