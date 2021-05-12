using _1_Domain_Code.Entities;
using _1_DomainCode.Entities.Interfaces;
using _2_ApplicationCode.SpendingTools;
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
    /// Interaction logic for SpendingOverview.xaml
    /// </summary>
    public partial class SpendingOverview : Page
    {
        private ICategoryAdapter categoryAdapter;
        public SpendingOverview(ICategoryAdapter categoryAdapter)
        {
            InitializeComponent();
            this.categoryAdapter = categoryAdapter;
            InitUserInterfaceComponents();
        }

        public void SpendingSelectionChanged(object sender, RoutedEventArgs e)
        {
            StackPanel contentPanel = new StackPanel();

            List<ISpending> spendingList = SelectedCategory()?.GetSpendings();
            if(spendingList == null)
            {
                return;
            }
            SpendingSorter.SortSpendingByDate(ref spendingList);

            if (!DatesValid()) { return; }

            spendingList.ForEach((spending) =>
            {
                if(!(spending.GetDate() >= StartDate() && spending.GetDate() <= EndDate()))
                {
                    return;
                }

                TextBlock textBlock = new TextBlock();
                textBlock.TextWrapping = TextWrapping.Wrap;
                textBlock.Margin = new Thickness(0, 0, 0, 20);
                textBlock.Text = spending.GetDate().ToString("dd/MM/yyyy") + " " + spending.GetSpendMoney().ToString() + "\n" + spending.GetDescription();
                contentPanel.Children.Add(textBlock);
            });

            spendingsScrollView.Content = contentPanel;
        }

        private void InitUserInterfaceComponents()
        {
            categoryComboBox.ItemsSource = new List<Category>();
            categoryComboBox.ItemsSource = categoryAdapter.GetCategoryList();
            DateTime currentDate = DateTime.Today;
            DateTime beginOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);
            startDatePicker.SelectedDate = beginOfMonth;
            endDatePicker.SelectedDate = currentDate;
        }

        public void BackClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Home());
        }

        private ICategory SelectedCategory()
        {
            return (ICategory)categoryComboBox.SelectedItem;
        }

        private DateTime? StartDate()
        {
            return startDatePicker.SelectedDate;
        }

        private DateTime? EndDate()
        {
            return endDatePicker.SelectedDate;
        }

        private bool DatesValid()
        {
            if (StartDate() > EndDate())
            {
                dateErrorLabel.Content = "The starting date has to be set before or equal to the ending date";
                return false;
            }
            else
            {
                dateErrorLabel.Content = "";
                return true;
            }
        }
    }
}
