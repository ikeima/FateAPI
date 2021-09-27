using FateAPI.Models;
using MvvmHelpers.Commands;
using Prism.Navigation;
using SupportLib.Extensions;
using SupportLib.Services;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FateAPI.ViewModels
{
    public class ServantListPageViewModel : ViewModelBase
    {
        Web web = new Web();
        private ServantBaseData _servant;
        public ServantBaseData Servant
        {
            get { return _servant; }
            set { SetProperty(ref _servant, value); }
        }
        private ServantBaseData _selectedServant;
        public ServantBaseData SelectedServant
        {
            get { return _selectedServant; }
            set { SetProperty(ref _selectedServant, value); }
        }

        private ObservableCollection<ServantBaseData> _servants = new ObservableCollection<ServantBaseData>();
        public ObservableCollection<ServantBaseData> Servants
        {
            get { return _servants; }
            set { SetProperty(ref _servants, value); }
        }
        public ICommand SelectServantCommand { get; }
        public ServantListPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            Response();
            SelectServantCommand = new AsyncCommand(Navigate);
        }
        private async Task Navigate()
        {
            var navigationParams = new NavigationParameters()
            {
                { "int", SelectedServant.collectionNo }
            };
            await NavigationService.NavigateAsync("ServantPage", navigationParams);
        }

        private async void Response()
        {
            await GetServants();
        }
        private async Task GetServants()
        {
            for (int i = 1; i < 100; i++)
            {
                var res = await web.HttpMethod(HttpMethod.Get)
                    .Execute<ServantBaseData>($"https://api.atlasacademy.io/basic/NA/servant/{i}?lang=en", new System.Threading.CancellationToken());

                res.Result.face = Rename(res.Result.face);
                Servant = res.Result;
                Servants.Add(Servant);
            }
        }

        private string Rename(string face)
        {
            int ind = face.IndexOf('_');
            face = face.Insert(ind + 8, "_bordered");
            return face;
        }
    }
}
