namespace MauiAppHotel.Views;

public partial class QuemSomos : ContentPage
{
    public QuemSomos()
    {
        InitializeComponent();
    }

    private async void Button_Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}