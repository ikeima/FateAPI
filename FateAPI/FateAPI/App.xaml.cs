using FateAPI.Services;
using FateAPI.ViewModels;
using FateAPI.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;  

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

            AppCenter.Start("android=eaa6fedc-d301-4df4-b7ba-94a59135b359;" +
                  "ios=7befcabc-fcb6-4403-8ebf-0bf20953d9b9",
                  typeof(Analytics), typeof(Crashes));

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
            containerRegistry.RegisterForNavigation<CraftEssencesPage, CraftEssencesPageViewModel>();
        }
    }
}
