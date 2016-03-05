using Xamarin.Forms;
using XMessagingCenter.SourceCode.Views;

namespace XMessagingCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new TestPageView();
        }
    }
}
