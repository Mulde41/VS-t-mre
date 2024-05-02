﻿using System;
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
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Viewmodel;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.View
{
    /// <summary>
    /// Interaction logic for ProjectsView.xaml
    /// </summary>
    public partial class ProjectsView : UserControl
    {
        private MainViewModel mvm = new MainViewModel();

        public ProjectsView()
        {
            DataContext = mvm;
            InitializeComponent();
            LoadLists();
        }
        private void LoadLists()
        {

            ProjectsListBox.ItemsSource = mvm.GetAll();

        }
        private void ProjectsListBoxFocus(object sender, RoutedEventArgs e)
        {
        }

        private void btnCreateProject_Click(object sender, RoutedEventArgs e)
        {
            ProjectMakerView mainContent = new ProjectMakerView();
            MainContent.Content = mainContent;
        }
        
    }
}
