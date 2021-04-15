using _1_Domain_Code.Entities;
using _1_Domain_Code.ValueObjects;
using _1_DomainCode.Entities.Interfaces;
using _3_Adapters.Interfaces;
using System;
using System.Windows;
using System.Windows.Controls;

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
            this.NavigationService.Navigate(new Home());
        }

        public void ClickAddSpendingMode(object sender, RoutedEventArgs e)
        {            
        }

        public void ClickAddSpending(object sedner, RoutedEventArgs e)
        {
            try
            {
                ICategory selectedCategory = (ICategory)categoryComboBox.SelectedItem;
                double amount = Convert.ToDouble(moneyTextBox.Text);
                DateTime date = (DateTime)spendingDatePicker.SelectedDate;
                string description = descriptionTextBox.Text;

                Money spendingAmount = new Money(amount, selectedCategory.GetLimit().GetCurrency());
                Spending newSpending = new Spending(spendingAmount, date, description);

                selectedCategory.AddSpending(newSpending);
                ClearInputFields();
            }catch(Exception exception)
            {
                errorLabel.Content = " One of the inputs is invalid.\n" +
                    " You are only allowed to input numbers for the spending amount.";
            }
            
        }

        public void ChangeSelectedCategory(object sender, RoutedEventArgs e)
        {
            currencyLabel.Content = ((ICategory)categoryComboBox.SelectedItem).GetLimit().GetCurrency().ToString();
        }

        private void InstantiateEditingMask()
        {
            categoryComboBox.ItemsSource = categoryAdapter.GetCategoryList();
            spendingDatePicker.SelectedDate = DateTime.Now;
        }

        private void ClearInputFields()
        {
            moneyTextBox.Text = "";
            descriptionTextBox.Text = "";
            errorLabel.Content = "";
        }
    }
}
