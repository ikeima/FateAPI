
using FateAPI.ViewModels;

namespace FateAPI.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            DevExpress.XamarinForms.Navigation.Initializer.Init();
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
    }
}
