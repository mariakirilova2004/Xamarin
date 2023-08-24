using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using VideoPlayerApp.CustomControls;
using VideoPlayerApp.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(VideoPlayer), typeof(VideoPlayerRenderer))]
namespace VideoPlayerApp.Droid.CustomRenderers
{
    public class VideoPlayerRenderer : ViewRenderer<VideoPlayer, Android.Widget.RelativeLayout>
    {
        public VideoPlayerRenderer(Context context) : base(context)
        {
                
        }

        VideoView videoView;

        protected override void OnElementChanged(ElementChangedEventArgs<VideoPlayer> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null) return;

            videoView = new VideoView(Context);
            Android.Widget.RelativeLayout relativeLayout = new Android.Widget.RelativeLayout(Context);
            relativeLayout.AddView(videoView);

            Android.Widget.RelativeLayout.LayoutParams layoutParams = new Android.Widget.RelativeLayout.LayoutParams(LayoutParams.MatchParent, LayoutParams.MatchParent);
            layoutParams.AddRule(LayoutRules.CenterInParent);
            videoView.LayoutParameters = layoutParams;

            SetNativeControl(relativeLayout);

            videoView.Prepared += VideoView_Prepared;
        }

        private void VideoView_Prepared(object sender, EventArgs e)
        {
            videoView.Start();
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == VideoPlayer.SourceProperty.PropertyName)
            {
                if (string.IsNullOrEmpty(Element.Source)) videoView.SetVideoPath(Element.Source);
            }
        }
    }
}