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
                Console.WriteLine("Bot: Field cannot be empty. Please ask me something ");
                continue;
            }

            if (input == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bot: Goodbye " + user.Name + "! REMEMBER TO PRIORITIZE YOUR SAFETY ONLINE!");
                break;
            }

            Respond(input);
        }
    }

    private void Respond(string input)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Bot: ");

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        if (input.Contains("how are you"))
            
        {
            Console.WriteLine($"I'm just a 'bot. I cannot feel.  But i am ready to help you stay safe online{user.Name}! ");
        }
        else if (input.Contains("purpose"))
        {
            Console.WriteLine("My purpose is to enlighten you more on cybersecurity.");
        }
        else if (input.Contains("what can i ask"))
        {
            Console.WriteLine("You can ask about passwords, phishing, and safe browsing.");
        }
        else if (input.Contains("password"))
        {
            Console.WriteLine("A password is a secret word or string of characters that you use to gain access to an account or system and prove your identity. Passwords prevent people from accessing your personal information and data without your permission. ");
        }
        else if (input.Contains("phishing"))
        {
            Console.WriteLine("Phishing is a type of cyberattack that involves sending fraudulent communications, usually emails, that appear to come from legitimate organizations like your bank or a well-known company to steal information. It also frequently occurs via fictitious email messages, SMS, or websites urging consumers to surrender passwords, money, or personal information. ");
        }
        else if (input.Contains("safe browsing"))
        {
            Console.WriteLine("Safe browsing is the art of surfing the web without having your personal information or devices at risk from threats like malware, scams, and hackers. It’s as simple as not clicking on suspicious links, visiting secure websites and keeping your software and security applications up to date.");
        }
        else
        {
            Console.WriteLine("I am sorry,I didn't quite get that. Could you  please rephrase?");
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
