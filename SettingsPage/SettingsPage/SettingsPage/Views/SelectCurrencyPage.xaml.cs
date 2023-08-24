using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SettingsPage.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectCurrencyPage : ContentPage
	{
		SettingsPage SettingsPage;
		public SelectCurrencyPage ( SettingsPage sender)
		{
			InitializeComponent ();
			SettingsPage = sender;
		}

        private void TextCell_Tapped(object sender, EventArgs e)
        {
			var textCell = (TextCell)sender;
			SettingsPage.SetCurrency(textCell.Text);
        }
    }
}