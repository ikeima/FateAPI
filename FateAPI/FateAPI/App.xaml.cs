using FateAPI.Services;
using FateAPI.ViewModels;
using FateAPI.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace FateAPI
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("MenuDetailPage/NavigationPage/ServantListPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.Register<IWebService, WebService>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<ServantPage, ServantPageViewModel>();
            containerRegistry.RegisterForNavigation<ServantListPage, ServantListPageViewModel>();
            containerRegistry.RegisterForNavigation<MenuDetailPage, MenuDetailPageViewModel>();
        }
    }
}
