using Xamarin.Forms;

namespace XGravatar.SourceCode.Views
{
    public partial class TestPageView : ContentPage
    {
        public TestPageView()
        {
            InitializeComponent();
            BindingContext = new TestPageViewModel();
        }
    }
}
