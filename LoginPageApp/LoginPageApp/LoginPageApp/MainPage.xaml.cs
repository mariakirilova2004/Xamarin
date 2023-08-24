using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPageApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentPage_SizeChanged(object sender, EventArgs e)
        {
            if (Width * Height < 0) return;

            if (Width > Height)
            {
                gridMain.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
                gridMain.RowDefinitions[1].Height = 0;
                Grid.SetColumn(stackLayout2, 1);
                Grid.SetRow(stackLayout2, 0);
            }
            else
            {
                gridMain.ColumnDefinitions[1].Width = 0;
                gridMain.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
                Grid.SetColumn(stackLayout2, 0);
                Grid.SetRow(stackLayout2, 1);
            }
        }
    }
}
