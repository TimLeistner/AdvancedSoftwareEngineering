using _1_DomainCode.Entities.Interfaces;
using _2_ApplicationCode.SpendingTools;
using _3_Adapters;
using _3_Adapters.Interfaces;
using _4_UI.UI;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace _4_UI
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        private ICategoryAdapter categoryAdapter;
        public Home()
        {
            InitializeComponent();
            AdapterManager adapterManager = new AdapterManager();
            categoryAdapter = adapterManager.GetCategoryAdapter();
            InitUserInterface();
        }

        private void InitUserInterface()
        {
            datepickerLabel.Content = "        Pick date with\nwanted month and year";
            homeDatePicker.SelectedDate = DateTime.Now;
            List<ICategory> categoryList = categoryAdapter.GetCategoryList();
            if(categoryList.Count > 0)
            {
                categoryComboBox.ItemsSource = categoryList;
                categoryComboBox.SelectedItem = categoryList[0];
            }          
        }

        private void ChangeSelectedCategory(object sender, RoutedEventArgs e)
        {
            if(categoryComboBox.SelectedItem != null)
            {
                DateTime selectedDate = (DateTime)homeDatePicker.SelectedDate;
                ICategory category = (ICategory)categoryComboBox.SelectedItem;
                double limit = category.GetLimit().GetValue();
                List<ISpending> spendingList = category.GetSpendings();
                List<ISpending> monthlySpending = SpendingSorter.GetSpendingForMonth(spendingList, selectedDate);
                double sumOfSpending = SpendingCalculator.GetSumOfSpending(monthlySpending);
                double balance = limit - sumOfSpending;

                limitLable.Content = limit;
                spendingLabel.Content = sumOfSpending;
                balanceLabel.Content = balance;

                if(balance >= 0)
                {
                    balanceLabel.Foreground = Brushes.Green;
                }
                else
                {
                    balanceLabel.Foreground = Brushes.Red;
                }
            }
        }

        private void EditCategoryClick(object sender, RoutedEventArgs e)
        {
            CategoryEditor categoryEditor = new CategoryEditor(categoryAdapter);
            this.NavigationService.Navigate(categoryEditor);
        }

        private void EditSpendingClick(object sender, RoutedEventArgs e)
        {
            SpendingEditor spendingEditor = new SpendingEditor(categoryAdapter);
            this.NavigationService.Navigate(spendingEditor);
        }

        private void SpendingOverviewClick(object sender, RoutedEventArgs e)
        {
            SpendingOverview spendingOverview = new SpendingOverview(categoryAdapter);
            this.NavigationService.Navigate(spendingOverview);
        }
    }
}
