using EnDejtTillApplication.Pages;

namespace EnDejtTillApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DemoContentPage();
        }
    }
}
