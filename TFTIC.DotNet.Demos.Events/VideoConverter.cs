using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TFTIC.DotNet.Demos.Events
{
    public class VideoConvertEventArgs : EventArgs
    {
        public string message;
        public Video video;
    }

    public class VideoConverter
    {
        public event EventHandler<VideoConvertEventArgs> VideoConversionStarted;
        public event EventHandler<VideoConvertEventArgs> VideoConverted;

        public VideoConverter()
        {
            VideoConverted = null;
            VideoConversionStarted = null;
        }

        public void Convert(Video video)
        {
            OnVideoConversionStarted(video);
            Thread.Sleep(1000);
            OnVideoConverted(video);
        }

        protected void OnVideoConverted(Video video)
        {
            //if (VideoConverted != null) VideoConverted();
            VideoConverted?.Invoke(this, new VideoConvertEventArgs { message = "Video convertie", video = video  });
        }
        protected void OnVideoConversionStarted(Video video)
        {
            //if (VideoConverted != null) VideoConverted();
            VideoConversionStarted?.Invoke(this, new VideoConvertEventArgs { message = "Début de la conversion...", video = video});
        }
    }
}
