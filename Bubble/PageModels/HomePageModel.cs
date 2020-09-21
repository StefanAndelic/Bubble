using System;
using System.Collections.ObjectModel;
using Bubble.Models;
using FreshMvvm;

using Xamarin.Forms;

namespace Bubble.PageModels
{
    public class HomePageModel : FreshBasePageModel
    {

        public Command AddVideo { get; set; }

        public HomePageModel()
        {
            AddVideo = new Command(PlayVideo);



        }

        private void PlayVideo()
        {
            CoreMethods.PushPageModel<VideoPlayerPageModel>();
        }
    }
}
