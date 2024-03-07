﻿namespace AulaBasica
{
    public partial class MainPage : ContentPage
    {
        string nome;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BTNOla_Clicked(object sender, EventArgs e)
        {
            nome = await DisplayPromptAsync("Nome", "Digite seu nome:", "OK");

            await DisplayAlert("Aviso!",$"Olá! {nome}","OK");
        }
    }

}
