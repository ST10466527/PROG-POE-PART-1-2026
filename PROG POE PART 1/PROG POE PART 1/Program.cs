using System;
using System.Media;
using System.Threading;

class CyberSecurityBot
{
    public void Launch()
    {
        ShowLogo();
        PlayGreeting();
        WelcomeUser();
        RunMenu();
    }

    private void ShowLogo()
    {
        Console.ForegroundColor = ConsoleColor.Magenta; // dusty pink
        Console.WriteLine("########################################");
        Console.WriteLine("#   CYBERSECURITY AWARENESS BOT        #");
        Console.WriteLine("########################################");
        Console.ResetColor();
    }

    private void PlayGreeting()
    {
        SoundPlayer player = new SoundPlayer("greeting.wav");
        player.PlaySync();
    }

    private void WelcomeUser()
    {
        TypeEffect("Welcome to the Cybersecurity Awareness Bot!");
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Magenta; // light pink
        Console.WriteLine("===========================================");
        Console.WriteLine($"Hello, {userName}! Stay safe and secure online.");
        Console.WriteLine("===========================================");
        Console.ResetColor();

        Console.WriteLine("Chatbot is ready!");
    }

    private void RunMenu()
    {
        string choice = "";
        while (choice != "exit")
        {
            Console.ForegroundColor = ConsoleColor.Cyan; // sky blue for questions
            Console.WriteLine("\nAsk me something:");
            Console.WriteLine("1. How are you?");
            Console.WriteLine("2. What's your purpose?");
            Console.WriteLine("3. What can I ask you about?");
            Console.WriteLine("Type 'exit' to quit.");
            Console.ResetColor();

            Console.Write("Choose an option (1-3): ");
            choice = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(choice))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                Console.ResetColor();
                continue;
            }

            Console.ForegroundColor = ConsoleColor.Magenta; // light pink answers
            switch (choice)
            {
                case "1":
                    Console.WriteLine("I’m secure and ready to help you stay safe online!");
                    break;
                case "2":
                    Console.WriteLine("My purpose is to raise cybersecurity awareness and help you protect yourself.");
                    break;
                case "3":
                    Console.WriteLine("You can ask me about password safety, phishing, and safe browsing tips.");
                    break;
                case "exit":
                    Console.WriteLine("Goodbye, stay safe!");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                    break;
            }
            Console.ResetColor();
        }
    }

    private void TypeEffect(string message)
    {
        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        CyberSecurityBot bot = new CyberSecurityBot();
        bot.Launch();
    }
}