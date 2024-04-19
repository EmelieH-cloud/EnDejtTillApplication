namespace EnDejtTillApplication.Pages;
using Microsoft.Maui.Controls;

public partial class SelectDeckPage : ContentPage
{
    public SelectDeckPage()
    {
        InitializeComponent();
    }

    private async void GoBackBtn(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }


}