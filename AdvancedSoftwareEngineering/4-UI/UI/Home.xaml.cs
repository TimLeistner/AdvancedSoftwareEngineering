using _3_Adapters;
using _4_UI.UI;
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

        public static Home GetInstance()
        {
            return instance;
        }
    }
}
