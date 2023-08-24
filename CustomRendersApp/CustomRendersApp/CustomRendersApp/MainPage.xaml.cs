using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomRendersApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<MyModel> list = new List<MyModel>();

            list.Add(new MyModel { PlaceHolder = "MyEntry1", BorderColor = Color.Red, BorderWidth = 10 });
            list.Add(new MyModel { PlaceHolder = "MyEntry2", BorderColor = Color.Blue, BorderWidth = 15 });
            list.Add(new MyModel { PlaceHolder = "MyEntry3", BorderColor = Color.Green, BorderWidth = 20 });
            list.Add(new MyModel { PlaceHolder = "MyEntry4", BorderColor = Color.Yellow, BorderWidth = 21 });
            list.Add(new MyModel { PlaceHolder = "MyEntry6", BorderColor = Color.Orange, BorderWidth = 25 });

            BindingContext = list;
        }
    }
}
