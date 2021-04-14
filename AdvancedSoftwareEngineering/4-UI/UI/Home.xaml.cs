using _1_Domain_Code.Entities;
using _1_DomainCode.Entities.Interfaces;
using _3_Adapters;
using _3_Adapters.Interfaces;
using _4_UI.UI;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace _4_UI
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private static Home instance;
        private AdapterManager adapterManager;
        public Home()
        {
            InitializeComponent();
            adapterManager = new AdapterManager();
            instance = this;
        }

        private void EditCategoryClick(object sender, RoutedEventArgs e)
        {
            CategoryEditor categoryEditor = new CategoryEditor(adapterManager.GetCategoryAdapter());
            this.NavigationService.Navigate(categoryEditor);
        }

        private void EditSpendingClick(object sender, RoutedEventArgs e)
        {
            SpendingEditor spendingEditor = new SpendingEditor(adapterManager.GetCategoryAdapter());
            this.NavigationService.Navigate(spendingEditor);
        }

        private void SpendingOverviewClick(object sender, RoutedEventArgs e)
        {
            SpendingOverview spendingOverview = new SpendingOverview(adapterManager.GetCategoryAdapter());
            this.NavigationService.Navigate(spendingOverview);
        }

        public static Home GetInstance()
        {
            return instance;
        }
    }
}
