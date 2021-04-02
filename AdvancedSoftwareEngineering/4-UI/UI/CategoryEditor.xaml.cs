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
        }

        public void BackClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(Home.GetInstance());
        }

        public void StartCreateCategory(object sender, RoutedEventArgs e)
        {
            if (myGrid.Children.Contains(categoryList))
            {
                myGrid.Children.Remove(categoryList);
            }
            if (myGrid.Children.Contains(categoryLabel))
            {
                myGrid.Children.Remove(categoryLabel);
            }
        }

        public void StartEditCategory(object sender, RoutedEventArgs e)
        {
            if (!myGrid.Children.Contains(categoryList))
            {
                myGrid.Children.Add(categoryList);
            }
            if (!myGrid.Children.Contains(categoryLabel))
            {
                myGrid.Children.Add(categoryLabel);
            }
        }

        private void SetEditingMask(ListBox categoryListBox = null)
        {
            
            string nameContent = "";
            string valueContent = "";

            ListBox availableColours = new ListBox();
            availableColours.ItemsSource = new List<Colour>() { Colour.BLUE, Colour.GREEN, Colour.RED, Colour.YELLOW };
            ListBox availableCurrencies = new ListBox();
            availableCurrencies.ItemsSource = new List<Currency>() { Currency.EURO };

            if(categoryListBox != null)
            {
                Category selectedCategory = (Category)categoryListBox.SelectedItem;
                nameContent = selectedCategory.GetCategoryName();
                availableColours.SelectedItem = selectedCategory.GetColour();
                valueContent = selectedCategory.GetLimit().GetValue().ToString();
                availableCurrencies.SelectedItem = selectedCategory.GetLimit().GetCurrency();
            }
        }
    }
}
