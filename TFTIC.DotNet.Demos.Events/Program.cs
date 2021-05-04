using System;

namespace TFTIC.DotNet.Demos.Events
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageService ms = new MessageService();

            VideoConverter vc = new VideoConverter();

            vc.VideoConverted += ms.OnVideoConverted;
            vc.VideoConversionStarted += ms.OnVideoConversionStarted;
            Video v = new Video() { Title = "Star Wars" };
            vc.Convert(v);
        
        }
    }
}
