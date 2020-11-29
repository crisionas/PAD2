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
    /// Interaction logic for CurrencyView.xaml
    /// </summary>
    public partial class CurrencyView : Page
    {
        IServices services;
        public CurrencyView()
        {
            InitializeComponent();

            var _bl = new BusinessManager();
            services = _bl.Services();

            var response = services.GetCurrency();
            CurrencyResponse curresponse = new CurrencyResponse();
            curresponse = response.Result;
            Time.Text = curresponse.Time.ToString();
            if(curresponse.BuyCurrency!=null)
            { 
            //SELL
            Eursell.Text = curresponse.SellCurrency.Eur.ToString();
            USDSell.Text = curresponse.SellCurrency.Usd.ToString();
            RUBSELL.Text = curresponse.SellCurrency.Rub.ToString();
            RONBUY.Text = curresponse.SellCurrency.Ron.ToString();
            UAHSELL.Text = curresponse.SellCurrency.Uah.ToString();

            //BUY
            EURBUY.Text = curresponse.BuyCurrency.Eur.ToString();
            USDBUY.Text = curresponse.BuyCurrency.Usd.ToString();
            RUBBUY.Text = curresponse.BuyCurrency.Rub.ToString();
            RONBUY.Text = curresponse.BuyCurrency.Ron.ToString();
            UAHBUY.Text = curresponse.BuyCurrency.Uah.ToString();
            Message.Text = curresponse.Message;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(null);
        }
    }
}
