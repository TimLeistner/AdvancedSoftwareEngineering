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
            if (myGrid.Children.Contains(categoryListBox))
            {
                myGrid.Children.Remove(categoryListBox);
            }
            if (myGrid.Children.Contains(categoryLabel))
            {
                myGrid.Children.Remove(categoryLabel);
            }
            if (!myGrid.Children.Contains(createCategoryButton))
            {
                myGrid.Children.Add(createCategoryButton);
            }

            categoryListBox.ItemsSource = categoryAdapter.GetCategoryList();
            nameTextBox.Text = "";
            limitTextBox.Text = "";
        }

        public void ClickEditMode(object sender, RoutedEventArgs e)
        {
            if (!myGrid.Children.Contains(categoryListBox))
            {
                myGrid.Children.Add(categoryListBox);
            }
            if (!myGrid.Children.Contains(categoryLabel))
            {
                myGrid.Children.Add(categoryLabel);
            }

            SetEditingMaskForSelectedCategory();
        }

        public void CategorySelectionChanged(object sender, RoutedEventArgs e)
        {
            SetEditingMaskForSelectedCategory();
        }

        public void ClickCreateCategory(object sender, RoutedEventArgs e)
        {
            string categoryName = nameTextBox.Text;
            Colour categoryColour = (Colour)colourListBox.SelectedItem;
            double categoryLimitValue =  Convert.ToDouble(limitTextBox.Text);
            Currency categoryCurrency = (Currency)currencyListBox.SelectedItem;

            categoryAdapter.AddCategory(categoryName, categoryColour, categoryLimitValue, categoryCurrency);
        }

        private void InstantiateEditingMask()
        {
            colourListBox.ItemsSource = Enum.GetValues(typeof(Colour));
            currencyListBox.ItemsSource = Enum.GetValues(typeof(Currency));
        }

        private void SetEditingMaskForSelectedCategory()
        {
            Category selectedCategory = (Category)categoryListBox.Items[0];

            nameTextBox.Text = selectedCategory.GetCategoryName();
            colourListBox.SelectedItem = selectedCategory.GetColour();
            limitTextBox.Text = selectedCategory.GetLimit().GetValue().ToString();
            currencyListBox.SelectedItem = selectedCategory.GetLimit().GetCurrency();
        }
    }
}
