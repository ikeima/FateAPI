using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace FateAPI.Views
{
    public partial class ServantPage : ContentPage
    {
        public ServantPage()
        {
            DevExpress.XamarinForms.Charts.Initializer.Init();
            InitializeComponent();
        }

        private void Expander_Tapped(object sender, System.EventArgs e)
        {
            //var expander = sender as Xamarin.CommunityToolkit.UI.Views.Expander;
            //expander.ForceUpdateSize();
            
          
        }
    }
}
