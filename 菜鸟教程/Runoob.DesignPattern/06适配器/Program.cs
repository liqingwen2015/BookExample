#region

using System;

#endregion

namespace _06适配器
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IMediaPlayer mediaPlay = new AudioPlayer();

            mediaPlay.Play("MP3");
            mediaPlay.Play("MP4");
            mediaPlay.Play("VLC");
            mediaPlay.Play("AVI");

            Console.Read();
        }
    }
}