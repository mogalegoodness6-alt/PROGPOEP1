using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace PROGPOEP2
{
    public class SentimentAnalyzer
    {
        public string CheckSentiment(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return string.Empty;

            input = input.ToLower();

            if (input.Contains("worried"))
            {
                return "Aww.It's understandable to feel worried about scams. Stay cautious and avoid suspicious links.";
            }

            if (input.Contains("frustrated"))
            {
                return "Eish.Cybersecurity can feel overwhelming, but learning small habits helps a lot.";
            }

            if (input.Contains("curious"))
            {
                return "Learning cybersecurity is a great way to stay safe online.";
            }

            return string.Empty;
        }
    }
}
