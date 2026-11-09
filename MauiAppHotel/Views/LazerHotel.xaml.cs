namespace MauiAppHotel.Views;

public partial class LazerHotel : ContentPage
{
    public LazerHotel()
    {
        InitializeComponent();
    }

    private async void Button_Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}