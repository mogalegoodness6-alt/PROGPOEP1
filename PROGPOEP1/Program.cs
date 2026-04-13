using PROGPOEP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PROGPOEP1
{ 

    }
class Program
{
    static void Main()
    {



        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("      ██████ ██    ██ ██████  ███████ ██████  ███████ ███████  ██████ ██    ██ ██████  ██ ████████ ██    ██     ██████   ██████  ████████ \r\n    ██       ██  ██  ██   ██ ██      ██   ██ ██      ██      ██      ██    ██ ██   ██ ██    ██     ██  ██      ██   ██ ██    ██    ██    \r\n    ██        ████   ██████  █████   ██████  ███████ █████   ██      ██    ██ ██████  ██    ██      ████       ██████  ██    ██    ██    \r\n    ██         ██    ██   ██ ██      ██   ██      ██ ██      ██      ██    ██ ██   ██ ██    ██       ██        ██   ██ ██    ██    ██    \r\n     ██████    ██    ██████  ███████ ██   ██ ███████ ███████  ██████  ██████  ██   ██ ██    ██       ██        ██████   ██████     ██    \r\n                                                                                                                                         \r\n                                                                                                                                         ");
        Console.Title = " Tlhatsi Cybersecurity Awareness Bot";

        // Play voice greeting
        CyberSecurityBot.AudioPlayer.PlayGreeting();
        

        // Show ASCII UI
        UIHelper.ShowHeader();

        // Ask user name
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.ResetColor();

        while (string.IsNullOrEmpty(name))
        {
            Console.Write("Name  field cannot be empty. Kindly enter your Name");
               
            name = Console.ReadLine();
        }

        User user = new User { Name = name };

        UIHelper.TypeText($"Hello {user.Name}! Welcome to the Cybersecurity Awareness Bot.");

        // Start chatbot
        ChatBot bot = new ChatBot(user);
        bot.StartChat();
    }
}


