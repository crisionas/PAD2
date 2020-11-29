using Client.Views;
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

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object content;

        public MainWindow()
        {
            InitializeComponent();
            content = this.Content;
        }
        public void GoBackToStartPage()
        {
            Content = content;

        }
            private void AccountView_Click(object sender, RoutedEventArgs e)
        {
            MainWindowPage.Content = new AccountView();
        }

        private void TransactionView_Click(object sender, RoutedEventArgs e)
        {
            MainWindowPage.Content = new TransactionView();
        }

        private void CurrencyView_Click(object sender, RoutedEventArgs e)
        {
            MainWindowPage.Content = new CurrencyView();
        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void MainWindowPage_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
