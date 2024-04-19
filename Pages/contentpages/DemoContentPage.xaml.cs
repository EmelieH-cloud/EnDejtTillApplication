namespace EnDejtTillApplication.Pages;

public partial class DemoContentPage : ContentPage
{
    public DemoContentPage()
    {
        InitializeComponent();
    }

    private async void contentPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new DemoContentPage2());
    }
}