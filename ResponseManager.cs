using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PROGPOEP2
{
    public class ResponseManager
    {
        private readonly Dictionary<string, List<string>> responses;
        private readonly Random random;
        private string userName = "";
        private bool askedName = false;

        public ResponseManager()
        {
            random = new Random();

            responses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
            {
                {
                    "password", new List<string>
                    {
                        "Use strong and unique passwords.",
                        "Avoid personal details in passwords.",
                        "Enable two-factor authentication."
                    }
                },
                {
                    "privacy", new List<string>
                    {
                        "Review privacy settings regularly.",
                        "Avoid oversharing online."
                    }
                },
                {
                    "scam", new List<string>
                    {
                        "Never click suspicious links.",
                        "Scammers often pretend to be trusted companies."
                    }
                },
                {
                    "phishing", new List<string>
                    {
                        "Avoid suspicious emails.",
                        "Verify email senders carefully."
                    }
                }
            };
        }

        public string GenerateResponse(string input)
        {
            

            // Ask for name first
            if (!askedName)
            {
                askedName = true;
                return "Hello there! What is your name?";
            }

            // Save user's name
            if (string.IsNullOrEmpty(userName))
            {
                userName = input;
                return $"Its an absolute pleasure to meet you, {userName}! How can I help you with cybersecurity today?";
            }

            // Greetings
            if (input.Contains("hi") || input.Contains("hello") || input.Contains("hey"))
            {
                return $"Hello again, {userName} !!!!";
            }

            // Keyword responses
            foreach (var keyword in responses.Keys)
            {
                if (input.Contains(keyword))
                {
                    var options = responses[keyword];
                    return options[random.Next(options.Count)];
                }
            }

            // More information
            if (input.Contains("tell me more"))
            {
                return "Cybersecurity awareness protects your information online.";
            }

            return "I'm not sure I understand. Please rephrase.";
        }
    }
}