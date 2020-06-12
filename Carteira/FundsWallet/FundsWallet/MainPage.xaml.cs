using FundsWallet.Model;
using FundsWallet.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace FundsWallet
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Fundo> fundos = new ObservableCollection<Fundo>();
        public MainPage()
        {
            InitializeComponent();
        }

        protected async void SaveFund(object sender, EventArgs e)
        {
            Fundo.Text = "";
            Valor.Text = "";
            Qtd.Text = "";
            fundos.Add(new Fundo { Nome = Fundo.Text, Valor = Valor.Text, Qtd = Qtd.Text });
        }

        private async void GoToFundDetails(object sender, ItemTappedEventArgs e)
        {
            var content = e.Item as Fundo;
            await Navigation.PushAsync(new DetalhesDeFundo(content));
        }

    }
}
