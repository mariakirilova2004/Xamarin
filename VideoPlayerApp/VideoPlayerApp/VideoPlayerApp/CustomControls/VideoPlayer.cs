using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VideoPlayerApp.CustomControls
{
    public class VideoPlayer : View
    {
        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string), typeof(VideoPlayer));

        public string Source { get => (string)GetValue(SourceProperty); set => SetValue(SourceProperty, value); }
    }
}
