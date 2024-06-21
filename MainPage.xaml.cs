using System;
using Microsoft.Maui.Controls;

namespace coinFlip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int Coin = new Random().Next(2);

            CoinImage.Source = Coin == 0 ? "coroa.png" : "cara.png";

            string selectedSide = HeadTailsPicker.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSide))
            {
                ResultLabel.Text = "Por favor, selecione Cara ou Coroa.";
                return;
            }

            if ((Coin == 0 && selectedSide == "Coroa") || (Coin == 1 && selectedSide == "Cara"))
            {
                ResultLabel.Text = "Vitória!";
            }
            else
            {
                ResultLabel.Text = "Derrota!";
            }
        }
    }
}
