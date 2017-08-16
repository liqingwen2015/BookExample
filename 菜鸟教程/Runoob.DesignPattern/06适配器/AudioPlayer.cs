#region

using System;

#endregion

namespace _06适配器
{
    internal class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _mediaAdapter;

        public void Play(string audioType)
        {
            if (audioType == "MP3")
            {
                Console.WriteLine("Play: MP3");
            }
            else if (audioType == "VLC" || audioType == "MP4")
            {
                _mediaAdapter = new MediaAdapter(audioType);
                _mediaAdapter.Play(audioType);
            }
            else
            {
                Console.WriteLine("无效格式");
            }
        }
    }
}