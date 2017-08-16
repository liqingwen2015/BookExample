namespace _06适配器
{
    internal class MediaAdapter : IMediaPlayer
    {
        private readonly IAdvancedMediaPlayer _advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType == "VLC")
                _advancedMediaPlayer = new VlcPlayer();
            else if (audioType == "MP4")
                _advancedMediaPlayer = new Mp4Player();
        }

        public void Play(string audioType)
        {
            if (audioType == "VLC")
                _advancedMediaPlayer.PlayVlc();
            else if (audioType == "MP4")
                _advancedMediaPlayer.PlayMp4();
        }
    }
}