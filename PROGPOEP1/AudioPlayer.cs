using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

public class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            string path = "greeting.wav";

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.PlaySync();
            }
            else
            {
                Console.WriteLine("Audio file not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error playing audio: " + ex.Message);
        }
    }
}


namespace PROGPOEP1
{
    internal class AudioPlayer
    {
    }
}
