using _1_Domain_Code.Entities;
using _1_Domain_Code.Enums;
using _1_DomainCode.Entities.Interfaces;
using _3_Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace _4_UI.UI
{
    /// <summary>
    /// Interaction logic for CategoryEditor.xaml
    /// </summary>
    public partial class CategoryEditor : Page
    {
        private ICategoryAdapter categoryAdapter;
        public CategoryEditor(ICategoryAdapter categoryAdapter)
        {
            InitializeComponent();
            this.categoryAdapter = categoryAdapter;
            ClickCreationMode(null, null);
            InstantiateEditingMask();
        }

        public void BackClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Home());
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
            if (myGrid.Children.Contains(saveChangesButton))
            {
                myGrid.Children.Remove(saveChangesButton);
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
            if (myGrid.Children.Contains(createCategoryButton))
            {
                myGrid.Children.Remove(createCategoryButton);
            }
            if (!myGrid.Children.Contains(saveChangesButton))
            {
                myGrid.Children.Add(saveChangesButton);
            }

            ReloadCategoryCombobox();
            SetEditingMaskForSelectedCategory();
        }

        public void CategorySelectionChanged(object sender, RoutedEventArgs e)
        {
            SetEditingMaskForSelectedCategory();
        }

        public void ClickCreateCategory(object sender, RoutedEventArgs e)
        {            
            try
            {
                string categoryName = nameTextBox.Text;
                if (categoryName.Equals(""))
                {
                    throw new Exception();
                }
                Colour categoryColour = (Colour)colourComboBox.SelectedItem;
                double categoryLimitValue = Convert.ToDouble(limitTextBox.Text);
                Currency categoryCurrency = (Currency)currencyComboBox.SelectedItem;
                categoryAdapter.AddCategory(categoryName, categoryColour, categoryLimitValue, categoryCurrency);
                ClearEditingMask();
            }
            catch(Exception exception)
            {
                errorLabel.Content = " One of the inputs is invalid.\n Please select a colour and a currency.\n" +
                    " You are also only allowed to input numbers as the limit.\n The name of the category has to be atleast one character long.";
            }            
        }

        public void ClickSaveChanges(object sender, RoutedEventArgs e)
        {
            try
            {
                string categoryName = nameTextBox.Text;
                if (categoryName.Equals(""))
                {
                    throw new Exception();
                }
                Colour categoryColour = (Colour)colourComboBox.SelectedItem;
                double categoryLimitValue = Convert.ToDouble(limitTextBox.Text);
                Currency categoryCurrency = (Currency)currencyComboBox.SelectedItem;
                ICategory selectedCategory = (ICategory)categoryComboBox.SelectedItem;

                categoryAdapter.ChangeCategory(selectedCategory, categoryName, categoryColour, categoryLimitValue, categoryCurrency);
                ReloadCategoryCombobox();
                categoryComboBox.SelectedItem = categoryComboBox.Items[0];
            }
            catch (Exception exception)
            {
                if((ICategory)categoryComboBox.SelectedItem == null)
                {
                    errorLabel.Content = "You have to select a category!";
                }
                else
                {
                    errorLabel.Content = " One of the inputs is invalid.\n Please select a colour and a currency.\n" +
                        " You are also only allowed to input numbers as the limit.\n The name of the category has to be atleast one character long.";
                }
            }

        }

        private void InstantiateEditingMask()
        {
            colourComboBox.ItemsSource = Enum.GetValues(typeof(Colour));
            currencyComboBox.ItemsSource = Enum.GetValues(typeof(Currency));
        }
        
        private void ClearEditingMask()
        {
            nameTextBox.Text = "";
            limitTextBox.Text = "";
            errorLabel.Content = "";
        }

        private void SetEditingMaskForSelectedCategory()
        {
            Category selectedCategory = (Category)categoryComboBox.SelectedItem;
            if(selectedCategory == null)
            {
                try
                {
                    selectedCategory = (Category)categoryComboBox.Items[0];
                    categoryComboBox.SelectedItem = selectedCategory;
                }
                catch
                {
                    return;
                }
            }
            nameTextBox.Text = selectedCategory.GetCategoryName();
            colourComboBox.SelectedItem = selectedCategory.GetColour();
            limitTextBox.Text = selectedCategory.GetLimit().GetValue().ToString();
            currencyComboBox.SelectedItem = selectedCategory.GetLimit().GetCurrency();
        }

        private void ReloadCategoryCombobox()
        {
            List<ICategory> categoryList = categoryAdapter.GetCategoryList();
            categoryComboBox.ItemsSource = new List<Category>();
            categoryComboBox.ItemsSource = categoryList;
        }
    }
}
