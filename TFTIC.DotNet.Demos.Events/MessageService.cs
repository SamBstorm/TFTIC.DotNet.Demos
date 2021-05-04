using System;
using System.Collections.Generic;
using System.Text;

namespace TFTIC.DotNet.Demos.Events
{
    public class MessageService
    {
        public void Alert(string message)
        {
            Console.WriteLine(message);
        }

        public void SoundEmission()
        {
            Console.Beep(10000, 500);
        }

        public void OnVideoConverted(object sender, VideoConvertEventArgs e)
        {
            Alert($"{e.message} : {e.video.Title}");
            SoundEmission();
        }

        public void OnVideoConversionStarted(object sender, VideoConvertEventArgs e)
        {
            Alert($"{e.message} : {e.video.Title}");
        }
    }
}
