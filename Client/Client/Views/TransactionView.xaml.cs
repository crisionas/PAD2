using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client.Views
{
    /// <summary>
    /// Interaction logic for TransactionView.xaml
    /// </summary>
    public partial class TransactionView : Page
    {
        IServices services;
        TransactionResponse transactionResponse = new TransactionResponse();
        public TransactionView()
        {
            InitializeComponent();
            var _bl = new BusinessManager();
            services = _bl.Services();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var transaction = new TransactionMessage
            {
                AccountReceiverId = ReceiverID.Text,
                AccountOwnerId = OwnerID.Text,
                Amount = Int64.Parse(Amount.Text),
                Currency=Currency.Text
            };

            var response = services.GetTransaction(transaction);
            transactionResponse = response.Result;
            MessageTrans.Text = transactionResponse.Message;
        }
    }
}
