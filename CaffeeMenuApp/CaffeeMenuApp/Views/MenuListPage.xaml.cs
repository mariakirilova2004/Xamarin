using CaffeeMenuApp.Data;
using CaffeeMenuApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CaffeeMenuApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuListPage : ContentPage
    {
        public MenuListPage()
        {
            InitializeComponent();

            //listViewMenu.BindingContext = MenuFactory.MenuList;
            listViewMenu.BindingContext = MenuFactory.MenuListGrouped;
        }

        private void listViewMenu_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetailPage((Food) e.Item));
            listViewMenu.SelectedItem = null;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            List<Food> foods = MenuFactory.MenuListGrouped.SelectMany(g => g).Where(f => f.Checked == true).ToList();
            if(foods.Count == 0)
            {
                DisplayAlert("", "You didn't select anything", "OK");
            }
            else
            {
                Navigation.PushAsync(new OrderListPage(foods));
            }
        }

        private void listViewMenu_Refreshing(object sender, EventArgs e)
        {
            List<Food> foods = MenuFactory.MenuListGrouped.SelectMany(g => g).Where(f => f.Checked == true).ToList();
            foreach (var food in foods)
            {
                food.Checked = false;
            }
            listViewMenu.EndRefresh();
        }
    }
}