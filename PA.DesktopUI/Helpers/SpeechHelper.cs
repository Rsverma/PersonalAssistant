using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech;
using System.Speech.Synthesis;
using System.Collections.ObjectModel;
using PADesktopUI.Properties;
using Engine.Core.Utilities;

namespace PADesktopUI.Helpers
{
    public class SpeechHelper
    {
        private readonly SpeechSynthesizer _speechSynthesizer = new();
        private static SpeechHelper _instance = null;
        private static readonly object _locker = new();

        public static SpeechHelper Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_locker)
                    {
                        if (_instance == null)
                            _instance = new();
                    }
                }
                return _instance;
            }
        }

        private SpeechHelper()
        {
            InitializeVoice();
        }
        private void InitializeVoice()
        {
            ReadOnlyCollection<InstalledVoice> voices = _speechSynthesizer.GetInstalledVoices();

            if (!string.IsNullOrWhiteSpace(Settings.Default.VoiceName) &&
               voices.Any(v => v.VoiceInfo.Name == Settings.Default.VoiceName))
            {
                _speechSynthesizer.SelectVoice(Settings.Default.VoiceName);
            }
            else
            {
                if (Settings.Default.VoiceGender.Equals("Male",
                                                       StringComparison.CurrentCultureIgnoreCase))
                {
                    _speechSynthesizer.SelectVoiceByHints(VoiceGender.Male);
                }
                else if (Settings.Default.VoiceGender.Equals("Female",
                                                            StringComparison.CurrentCultureIgnoreCase))
                {
                    _speechSynthesizer.SelectVoiceByHints(VoiceGender.Female);
                }
                else
                {
                    _speechSynthesizer.SelectVoiceByHints(VoiceGender.Neutral);
                }
            }

            _speechSynthesizer.Rate = Settings.Default.VoiceRate;
            _speechSynthesizer.Volume = Settings.Default.VoiceVolume;
        }

        public void SpeakGreeting()
        {
            Speak(GreetingBuilder.GetCurrentGreetingFor(Settings.Default.UserName));
        }

        private void Speak(string message)
        {
            _speechSynthesizer.SpeakAsync(message);
        }
    }
}
