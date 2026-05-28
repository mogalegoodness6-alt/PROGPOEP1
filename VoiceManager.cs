using System;
using System.Speech.Synthesis;

namespace PROGPOEP2
{
    public class VoiceManager : IDisposable
    {
        private readonly SpeechSynthesizer speaker;

        public VoiceManager()
        {
            speaker = new SpeechSynthesizer();

            // Optional: improve natural output
            speaker.Volume = 100;
            speaker.Rate = 0;
        }

        public void Speak(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return;

            speaker.SpeakAsync(text);
        }

        public void Stop()
        {
            speaker.SpeakAsyncCancelAll();
        }

        public void Dispose()
        {
            speaker?.Dispose();
        }
    }
}