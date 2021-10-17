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
using System.Windows.Input;
using MvvmHelpers.Commands;
using FateAPI.Models.GrowthFolder;
using FateAPI.Models.CustoModels;

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

        private ObservableCollection<AtkGrowth> _attackGrowthData = new ObservableCollection<AtkGrowth>();
        public ObservableCollection<AtkGrowth> AttackGrowthData
        {
            get { return _attackGrowthData; }
            set { SetProperty(ref _attackGrowthData, value); }
        }

        private ObservableCollection<HpGrowth> _hpGrowthData = new ObservableCollection<HpGrowth>();
        public ObservableCollection<HpGrowth> HpGrowthData
        {
            get { return _hpGrowthData; }
            set { SetProperty(ref _hpGrowthData, value); }
        }

        private ObservableCollection<CardsFaces> _faces = new ObservableCollection<CardsFaces>();
        public ObservableCollection<CardsFaces> Faces
        {
            get { return _faces; }
            set { SetProperty(ref _faces, value); }
        }

        public ICommand UpdateSizeCommand { get; set; }
        
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
            Servant.atkGrowth.ForEach(a => AttackGrowthData.Add(new AtkGrowth(a, Servant.atkGrowth.IndexOf(a))));
            Servant.hpGrowth.ForEach(h => HpGrowthData.Add(new HpGrowth(h, Servant.hpGrowth.IndexOf(h))));

            FacesFill();
        }

        private void FacesFill()
        {
            string face = Servant.extraAssets.commands.ascension.Select(a => a.Value).FirstOrDefault();

            for (int i = 0; i < 5; i++)
            {
                Faces.Add(new CardsFaces()
                {
                    Card = Servant.cards[i],
                    Face = face
                });
            }
        }

    }
}
