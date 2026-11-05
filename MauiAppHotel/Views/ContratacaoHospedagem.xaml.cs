namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Ação do botão Avançar será definida posteriormente.
    }

    private async void Button_Clicked1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new QuemSomos());
    }
}