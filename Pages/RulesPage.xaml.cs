namespace EnDejtTillApplication.Pages;

public partial class RulesPage : ContentPage
{
    public RulesPage()
    {
        InitializeComponent();
    }

    private async void GoBackBtn(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}