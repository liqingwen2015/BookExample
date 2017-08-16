#region

using System;

#endregion

namespace _06适配器
{
    internal class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayVlc()
        {
            Console.WriteLine("播放失败");
        }

        public void PlayMp4()
        {
            Console.WriteLine("Play: MP4");
        }
    }
}