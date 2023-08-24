using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopUps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title Alert", "Message Alert", "OK");
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Title Question Alert", "Message Question Alert", "Yes", "No");
            lblButton.Text = result.ToString();
        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Titile Action Alert", "Cancel", null, "20", "25", "30", "35");
            if(String.IsNullOrEmpty(result)!= true && result.ToString() != "Cancel") lblButton.FontSize = Convert.ToInt32(result);
        }
    }
}
