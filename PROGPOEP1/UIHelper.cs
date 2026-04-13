using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

public class UIHelper
{
    public static void ShowHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine("===========================================");
        Console.WriteLine("  TLHATSI CYBERSECURITY AWARENESS BOT");
        Console.WriteLine("===========================================");

        Console.WriteLine(@"
[ LOCKED SYSTEM ]
_________
| _____ |
| | | |
| | 🔒 | |
| |_____| |
|_________|
");

        Console.ResetColor();
    }

    public static void TypeText(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(20); // typing effect
        }
        Console.WriteLine();
    }

    public static void Divider()
    {
        // Divider
        Console.WriteLine("-------------------------------------------");
    }
}


namespace PROGPOEP1
{
    internal class UIHelper
    {
    }
}
