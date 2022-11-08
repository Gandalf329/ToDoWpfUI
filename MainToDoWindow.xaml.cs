﻿using System;
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
    public MainToDoWindow()
    {

        taskName.Add("Today");
        taskName.Add("Favorite");
        taskName.Add("Projects");
        InitializeComponent();
    }
    List<string> taskName = new List<string>();


}
