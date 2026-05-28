using PROGPOEP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGPOEP2
{
    public class Chatbot
    {
        private ResponseManager responseManager;
        private MemoryManager memoryManager;
        private SentimentAnalyzer sentimentAnalyzer;
        private VoiceManager voiceManager;

        private string lastResponse = "";

        public delegate string ResponseDelegate(string input);

        public Chatbot()
        {
            responseManager = new ResponseManager();
            memoryManager = new MemoryManager();
            sentimentAnalyzer = new SentimentAnalyzer();
            voiceManager = new VoiceManager();
        }

        public string GetResponse(string input)
        {
            input = input.ToLower();
            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
            ResponseDelegate responseDelegate =
                responseManager.GenerateResponse;

            string sentimentReply =
                sentimentAnalyzer.CheckSentiment(input);

            if (sentimentReply != "")
            {
                lastResponse = sentimentReply;
                return "[" + timeStamp + "] " + sentimentReply;
            }

            if (input.Contains("my name is"))
            {
                string name =
                    input.Replace("my name is", "").Trim();

                memoryManager.UserName = name;

                lastResponse =
                    "It's a bot's pleasure to meet you, " + name + "!";

                return "[" + timeStamp + "] " + lastResponse;
            }

            if (input.Contains("I am interested in"))
            {
                string topic =
                    input.Replace("I am interested in", "").Trim();

                memoryManager.FavouriteTopic = topic;

                lastResponse =
                    "Absolutely fascinating! I'll remember that you're interested in "
                    + topic;

                return lastResponse;
            }

            string response =
                responseDelegate(input);

            if (memoryManager.FavouriteTopic != "")
            {
                response +=
                    "\n\nSince you're interested in "
                    + memoryManager.FavouriteTopic +
                    ", REMEMBER to ALWAYS stay cautious online.";
            }

            lastResponse = response;

            return "[" + timeStamp + "] " + response;
        }

        public void SpeakLastResponse()
        {
            voiceManager.Speak(lastResponse);
        }
    }
}
