using BusinessLayer;
using BusinessLayer.Interfaces;
using BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
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
    /// Interaction logic for AccountView.xaml
    /// </summary>
    public partial class AccountView : Page
    {
        IServices services;
        AccountResponse accountResponse= new AccountResponse();

        public AccountView()
        {
            InitializeComponent();
            var _bl = new BusinessManager();
            services = _bl.Services();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }

        private void SendAccount_Click(object sender, RoutedEventArgs e)
        {
            var account = new AccountMessage();
            account.AccountId = Accountid.Text;
                account.FirstName = firstName.Text;
                account.LastName = Lastname.Text;

                account.Phone = phone.Text;
           

            var response = services.GetAccount(account);
            accountResponse = response.Result;
            AccountIDResp.Text = accountResponse.Account.AccountId.ToString();
            FirstNameResp.Text=accountResponse.Account.FirstName.ToString();
            LastNameResp.Text=accountResponse.Account.LastName.ToString();
            Balance.Text=accountResponse.Account.Balance.ToString();
            date.Text=accountResponse.Account.DateRegistered.ToString();
            Phoneresp.Text=accountResponse.Account.Phone;
            credits.Text=accountResponse.Account.Credits;
            MessageResp.Text = accountResponse.Message;
        }
    }
}
