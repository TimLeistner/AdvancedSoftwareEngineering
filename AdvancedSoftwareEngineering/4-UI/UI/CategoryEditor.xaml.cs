using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _3_Adapters;
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
    /// Interaction logic for CategoryEditor.xaml
    /// </summary>
    public partial class CategoryEditor : Page
    {
        private CategoryAdapter categoryAdapter;
        public CategoryEditor(CategoryAdapter categoryAdapter)
        {
            InitializeComponent();
            this.categoryAdapter = categoryAdapter;
            ClickCreationMode(null, null);
            InstantiateEditingMask();
        }

        public void BackClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(Home.GetInstance());
        }

        public void ClickCreationMode(object sender, RoutedEventArgs e)
        {
            if (myGrid.Children.Contains(categoryComboBox))
            {
                myGrid.Children.Remove(categoryComboBox);
            }
            if (myGrid.Children.Contains(categoryLabel))
            {
                myGrid.Children.Remove(categoryLabel);
            }
            if (!myGrid.Children.Contains(createCategoryButton))
            {
                myGrid.Children.Add(createCategoryButton);
            }

            
            nameTextBox.Text = "";
            limitTextBox.Text = "";
        }

        public void ClickEditMode(object sender, RoutedEventArgs e)
        {
            if (!myGrid.Children.Contains(categoryComboBox))
            {
                myGrid.Children.Add(categoryComboBox);
            }
            if (!myGrid.Children.Contains(categoryLabel))
            {
                myGrid.Children.Add(categoryLabel);
            }

            categoryComboBox.ItemsSource = categoryAdapter.GetCategoryList();
            SetEditingMaskForSelectedCategory();
        }

        public void CategorySelectionChanged(object sender, RoutedEventArgs e)
        {
            SetEditingMaskForSelectedCategory();
        }

        public void ClickCreateCategory(object sender, RoutedEventArgs e)
        {
            string categoryName = nameTextBox.Text;
            Colour categoryColour = (Colour)colourComboBox.SelectedItem;
            double categoryLimitValue =  Convert.ToDouble(limitTextBox.Text);
            Currency categoryCurrency = (Currency)currencyComboBox.SelectedItem;

            categoryAdapter.AddCategory(categoryName, categoryColour, categoryLimitValue, categoryCurrency);
        }

        private void InstantiateEditingMask()
        {
            colourComboBox.ItemsSource = Enum.GetValues(typeof(Colour));
            currencyComboBox.ItemsSource = Enum.GetValues(typeof(Currency));
        }

        private void SetEditingMaskForSelectedCategory()
        {
            Category selectedCategory = (Category)categoryComboBox.SelectedItem;
            if(selectedCategory == null)
            {
                selectedCategory = (Category)categoryComboBox.Items[0];
                categoryComboBox.SelectedItem = selectedCategory;
            }
            nameTextBox.Text = selectedCategory.GetCategoryName();
            colourComboBox.SelectedItem = selectedCategory.GetColour();
            limitTextBox.Text = selectedCategory.GetLimit().GetValue().ToString();
            currencyComboBox.SelectedItem = selectedCategory.GetLimit().GetCurrency();
        }
    }
}
