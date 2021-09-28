using FateAPI.Models.MenuModelFolder;
using Prism.Navigation;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace FateAPI.ViewModels
{
    public class MenuDetailPageViewModel : ViewModelBase
    {
        private List<MenuModel> _menuItems = new List<MenuModel>();
        public List<MenuModel> MenuItems
        {
            get { return _menuItems; }
            set { _menuItems = value; RaisePropertyChanged(); }
        }

        private ContentPage _contentPage;

        public ContentPage ContentPage
        {
            get { return _contentPage; }
            set { _contentPage = value; RaisePropertyChanged(); }
        }
        public ICommand TapMenuItemCommand { get; }
        public MenuDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            FillMenu();
            TapMenuItemCommand = new Command(OpenPage);

        }
        private async void OpenPage()
        {

        }
        private void FillMenu()
        {
            MenuItems.Add(new MenuModel()
            {
                Id = 0,
                Title = "SERVANTS",
                Icon = "class3_1002"
            });
            MenuItems.Add(new MenuModel()
            {
                Id = 1,
                Title = "CRAFT ESSENCES",
                Icon = "craft"
            });

        }
    }
}
