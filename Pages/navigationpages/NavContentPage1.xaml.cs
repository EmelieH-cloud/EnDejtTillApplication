namespace EnDejtTillApplication.Pages.navigationpages;

public partial class NavContentPage1 : ContentPage
{
    public NavContentPage1()
    {
        InitializeComponent();
    }


    private void NavcontentPage2_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}