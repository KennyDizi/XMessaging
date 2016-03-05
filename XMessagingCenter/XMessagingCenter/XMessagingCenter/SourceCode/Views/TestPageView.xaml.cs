using XMessagingCenter.SourceCode.Views.BaseView;

namespace XMessagingCenter.SourceCode.Views
{
    public partial class TestPageView : XBaseView
    {
        public TestPageView()
        {
            InitializeComponent();
            BindingContext = new TestPageViewModel();
        }
    }
}
