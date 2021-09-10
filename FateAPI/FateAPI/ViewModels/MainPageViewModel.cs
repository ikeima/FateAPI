using FateAPI.Models;
using Prism.Navigation;
using SupportLib.Extensions;
using SupportLib.Services;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;

namespace FateAPI.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        Web web = new Web();
        private ServantData _servant;
        public ServantData Servant
        {
            get { return _servant; }
            set { SetProperty(ref _servant, value); }
        }

        private ObservableCollection<ServantData> _servants = new ObservableCollection<ServantData>();
        public ObservableCollection<ServantData> Servants
        {
            get { return _servants; }
            set { SetProperty(ref _servants, value); }
        }
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Response();
        }

        private async Task Response()
        {
            for (int i = 1; i < 100; i++)
            {
                var res = await web.HttpMethod(HttpMethod.Get)
                    .Execute<ServantData>($"https://api.atlasacademy.io/nice/NA/servant/{i}?lang=en", new System.Threading.CancellationToken());

                Servant = res.Result;
                Servants.Add(Servant);
            }
        }
    }
}
