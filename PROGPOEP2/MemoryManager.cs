using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOEP2
{
    public class MemoryManager
    {
        // Stores user's name
        public string UserName { get; set; } = string.Empty;

        // Stores user's favourite topic
        public string FavouriteTopic { get; set; } = string.Empty;

        // Save name safely
        public void SetUserName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                UserName = name.Trim();
            }
        }

        // Save topic safely
        public void SetFavouriteTopic(string topic)
        {
            if (!string.IsNullOrWhiteSpace(topic))
            {
                FavouriteTopic = topic.Trim();
            }
        }

        // Greeting using memory
        public string GetGreeting()
        {
            if (!string.IsNullOrEmpty(UserName))
            {
                return $"Hello {UserName}, welcome back!";
            }

            return "Hello! Nice to meet you.";
        }

        // Summary of stored memory
        public string GetMemorySummary()
        {
            return $"Name: {UserName}\nFavourite Topic: {FavouriteTopic}";
        }
    }
}
