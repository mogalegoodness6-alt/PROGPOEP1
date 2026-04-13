using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

// for playing audio
   namespace CyberSecurityBot
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                
               SoundPlayer player = new SoundPlayer();
                player.PlaySync();
            }
            catch
            {
                Console.WriteLine(" Voice playback unavailable.");
            }
        }
    }
}