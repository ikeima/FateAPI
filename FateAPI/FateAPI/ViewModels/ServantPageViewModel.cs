using FateAPI.Models;
using Prism.Navigation;
using SupportLib.Extensions;
using SupportLib.Services;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.ObjectModel;
using FateAPI.Models.ExtraAssetsFolder.CharaGraphFolder;
using System.Collections.Generic;
using FateAPI.Models.SkillsFolder;
using System.Linq;

namespace FateAPI.ViewModels
{
    public class ServantPageViewModel : ViewModelBase
    {
        Web web = new Web();
        private string id;
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

        private ObservableCollection<string> _sprites = new ObservableCollection<string>();
        public ObservableCollection<string> Sprites
        {
            get { return _sprites; }
            set { SetProperty(ref _sprites, value); }
        }


        public ServantPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }

        private async void GetServant()
        {
            await GetServantAsync();
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            id = parameters.GetValue<int>("int").ToString();
            GetServant();   


        }

        private async Task GetServantAsync()
        {   
            var res = await web.HttpMethod(HttpMethod.Get)
                .Execute<ServantData>($"https://api.atlasacademy.io/nice/NA/servant/{id}?lang=en", new CancellationToken());
            Servant = res.Result;
            //Servant.extraAssets.charaGraph.ascension.ForEach(s => Sprites.Add(s.Value));
        }
    }
}
