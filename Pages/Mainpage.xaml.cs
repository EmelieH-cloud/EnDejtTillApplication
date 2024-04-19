namespace EnDejtTillApplication.Pages;

public partial class Mainpage : ContentPage
{
    public Mainpage()
    {
        InitializeComponent();
    }

    private async void ReadRulesBtn(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new RulesPage());
    }

    private async void StartGameBtn(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SelectDeckPage());
    }
}