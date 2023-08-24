﻿using CustomRendersApp.UWP.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly:ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace CustomRendersApp.UWP.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control == null) { return; }

            Control.BorderBrush = Color.Red.ToBrush();
            Control.BorderThickness = new Windows.UI.Xaml.Thickness(10); 
        }
    }
}
