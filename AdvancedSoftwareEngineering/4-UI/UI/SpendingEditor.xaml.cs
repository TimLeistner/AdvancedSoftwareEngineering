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
    /// Interaction logic for SpendingEditor.xaml
    /// </summary>
    public partial class SpendingEditor : Page
    {
        CategoryAdapter categoryAdapter;
        public SpendingEditor(CategoryAdapter categoryAdapter)
        {
            InitializeComponent();
            this.categoryAdapter = categoryAdapter;
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

        }

        public void CategorySelectionChanged(object sender, RoutedEventArgs e)
        {

        }

    }
}
