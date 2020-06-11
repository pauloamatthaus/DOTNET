using FundsWallet.Model;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FundsWallet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalhesDeFundo : ContentPage
    {
        List<Fundo> fundos = new List<Fundo>();
        public DetalhesDeFundo(Fundo fundo)
        {
            InitializeComponent();
            FundoNome.Text = fundo.Nome;
            fundos.Add(new Fundo { Nome = "Fundo 1", Valor = "1.5", Qtd = "1"});
            fundos.Add(new Fundo { Nome = "Fundo 2", Valor = "2.45", Qtd = "1" });
            double total = 0;
            fundos.ForEach(item =>
            {
                total += Convert.ToDouble(item.Valor);
            });
            FundoTotal.Text = "R$ " + System.Math.Round(total, 2).ToString();
            FundosView.ItemsSource = fundos;
        }

    }
}