using FateAPI.Models;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using SupportLib.Extensions;
using SupportLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FateAPI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        Web web = new Web();
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Response();
        }

        private async Task Response()
        {
            var res = await web.HttpMethod(HttpMethod.Get)
                .Execute<ServantData>("https://api.atlasacademy.io/nice/NA/servant/2?lang=en", new System.Threading.CancellationToken());
        }
    }
}
