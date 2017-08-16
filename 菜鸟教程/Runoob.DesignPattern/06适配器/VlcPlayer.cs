#region

using System;

#endregion

namespace _06适配器
{
    internal class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc()
        {
            Console.WriteLine("Play: VLC");
        }

        public void PlayMp4()
        {
            Console.WriteLine("播放失败");
        }
    }
}