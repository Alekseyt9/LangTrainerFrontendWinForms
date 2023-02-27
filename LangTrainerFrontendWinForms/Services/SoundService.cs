

using NAudio.Wave;

namespace LangTrainerFrontendWinForms.Services
{
    internal class SoundService
    {
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
