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
            set { SetProperty(ref _menuItems, value); }
        }
        private MenuModel _item;
        public MenuModel Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }
        public ICommand TapMenuItemCommand { get; }
        public MenuDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            FillMenu();
            TapMenuItemCommand = new Command(OpenPage);

        }
        private async void OpenPage()
        {
            switch (Item.Id)
            {
                case 0:
                    await NavigationService.NavigateAsync("NavigationPage/ServantListPage");
                    break;
                case 1:
                    await NavigationService.NavigateAsync("NavigationPage/CraftEssencesPage");
                    break;
                default:
                    break;
            }
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
