using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _3_Adapters;
using _3_Adapters.Interfaces;
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

namespace _4_UI.UI
{
    /// <summary>
    /// Interaction logic for SpendingEditor.xaml
    /// </summary>
    public partial class SpendingEditor : Page
    {
        ICategoryAdapter categoryAdapter;
        public SpendingEditor(ICategoryAdapter categoryAdapter)
        {
            InitializeComponent();
            this.categoryAdapter = categoryAdapter;
            InstantiateEditingMask();
        }

        public void BackClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(Home.GetInstance());
        }

        public void ClickAddSpendingMode(object sender, RoutedEventArgs e)
        {
            
        }

        public void ClickAddSpending(object sedner, RoutedEventArgs e)
        {
            ICategory selectedCategory = (ICategory)categoryComboBox.SelectedItem;
            double amount = Convert.ToDouble(moneyTextBox.Text);
            DateTime date = (DateTime)spendingDatePicker.SelectedDate;
            string description = descriptionTextBox.Text;

            Money spendingAmount = new Money(amount, selectedCategory.GetLimit().GetCurrency());
            Spending newSpending = new Spending(spendingAmount, date, description);

            selectedCategory.AddSpending(newSpending);
            ClearInputFields();
        }

        public void ChangeSelectedCategory(object sender, RoutedEventArgs e)
        {
            currencyLabel.Content = ((ICategory)categoryComboBox.SelectedItem).GetLimit().GetCurrency().ToString();
        }

        private void InstantiateEditingMask()
        {
            categoryComboBox.ItemsSource = categoryAdapter.GetCategoryList();
        }

        private void ClearInputFields()
        {
            spendingDatePicker.SelectedDate = null;
            moneyTextBox.Text = "";
            descriptionTextBox.Text = "";
        }
    }
}
