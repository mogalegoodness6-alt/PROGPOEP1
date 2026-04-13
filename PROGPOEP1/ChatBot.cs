using PROGPOEP1;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ChatBot
{
    private User user;

    public ChatBot(User user)
    {
        this.user = user;
    }

    public void StartChat()
    {
        while (true)
        {
            UIHelper.Divider();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("You: ");
            Console.ResetColor();

            string input = Console.ReadLine()?.ToLower().Trim();

            // Input validation
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Bot: Please enter something.");
                continue;
            }

            if (input == "exit")
            {
                Console.WriteLine("Bot: Goodbye " + user.Name + "! Stay safe online 👋");
                break;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Bot: ");

        if (input.Contains("how are you"))
        {
            Console.WriteLine($"I'm just a 'bot. I cannot feel. {user.Name}!Ready to keep you safe online ?😄");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("My purpose is to educate you about cybersecurity.");
        }
        else if (input.Contains("what can i ask"))
        {
            Console.WriteLine("You can ask about passwords, phishing, and safe browsing.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("Use strong passwords with letters, numbers, and symbols.");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Avoid clicking suspicious links and verify emails.");
        }
        else if (input.Contains("browsing"))
        {
            Console.WriteLine("Always use secure websites (https) and avoid unsafe downloads.");
        }
        else
        {
            Console.WriteLine("I didn't quite understand that. Could you rephrase?");
        }

        Console.ResetColor();
    }
}

namespace PROGPOEP1
{
    internal class ChatBot
    {
    }
}
