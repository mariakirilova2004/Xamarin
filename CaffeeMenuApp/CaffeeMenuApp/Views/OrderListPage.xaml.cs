using CaffeeMenuApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CaffeeMenuApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class OrderListPage : ContentPage
	{
		public OrderListPage (List<Food> foods)
		{
			InitializeComponent ();

            //listViewOrder.BindingContext = foods;
            listViewOrder.BindingContext = new ObservableCollection<Food>(foods);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
			DisplayAlert("Successfull", "Your order has been placed", "OK");
			listViewOrder.SelectedItem = null;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
			Food food = (Food)(sender as MenuItem).CommandParameter;
			(listViewOrder.BindingContext as ObservableCollection<Food>).Remove(food);
        }
    }
}