
using LangTrainerClientModel.Services;

namespace LangTrainerFrontendWinForms.Services.Controls
{
    internal class WordSoundsManager
    {
        private readonly SoundDto[] _sounds;
        private int _soundIndex;

        public WordSoundsManager(SoundDto[] sounds)
        {
            _sounds = sounds;
        }

        public void PlayNext()
        {
            var sound = _sounds[_soundIndex];
            _soundIndex = (_soundIndex + 1) % _sounds.Length;
            SoundService.GetInstance().Play(Convert.FromBase64String(sound.Data));
        }

    }
}
