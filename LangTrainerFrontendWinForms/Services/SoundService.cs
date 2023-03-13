

using NAudio.Wave;

namespace LangTrainerFrontendWinForms.Services
{
    internal class SoundService
    {
        private static SoundService _instance;

        private SoundService() { }

        public static SoundService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SoundService();
            }
            return _instance;
        }

        public void Play(byte[] data)
        {
            var ms = new MemoryStream(data);
            var waveStream = new Mp3FileReader(ms);
            var waveOut = new WaveOut();
            waveOut.Init(waveStream);
            waveOut.Play();
        }

    }
}
