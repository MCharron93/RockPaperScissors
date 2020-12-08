using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      // NOTE game options loaded into the list
      List<string> gameOptions = new List<string>();

      gameOptions.Add("rock");
      gameOptions.Add("paper");
      gameOptions.Add("scissors");

      // NOTE game is set to not running
      bool running = false;

      // NOTE Computer random choice generated
      Random randomizer = new Random();
      int computerNumber = randomizer.Next(0, 3);
      string computerChoice = gameOptions[computerNumber];

      // NOTE greeting for user and intakes their name for use later
      Console.WriteLine("Hello User, and welcome to Rock, Paper, Scissors. A game where you challenge the computer to the ultimate face-off battle! Please tell me your name. . . ");
      string userInput = Console.ReadLine();

      //   NOTE while the game is not running, the user is just greeted through print statement, game is then set to true here
      while (!running)
      {
        System.Console.WriteLine($"Hello {userInput}!");
        running = true;
      }

      // NOTE while game is set to true, the console takes in the users options. We will then use them to compare to the computers value
      System.Console.WriteLine("Now that we've established that you are , please choose your weapon! You may select rock, paper, or scissors: ");
      string userChoice = Console.ReadLine();
      while (running)
      {
        // NOTE switch statments for looking at the users choice of weapon
        switch (userChoice)
        {
          case "rock":
            Console.WriteLine($"You've picked a formidable weapon! The {userChoice} is sturdy and wielded by many with the desire to break enemies on first hit.");
            running = false;
            break;
          case "paper":
            Console.WriteLine($"Ah, yes, the {userChoice}! The {userChoice} is light yet fast! Any foe who dares to cross paths with you may not realize their quick ill fate...");
            running = false;
            break;
          case "scissors":
            Console.WriteLine($"The beautiful, but deadly {userChoice}, a classic choice for an experienced fighter! May your strike be swift and clean! ");
            running = false;
            break;
          default:
            System.Console.WriteLine("I'm not sure what weapong you're trying to use, but you must choose from our selection of fine weapons. ");
            break;
        }

      }
      //   NOTE prints results via a ternary and the outcome of computed values
      int userBattleWeapon = gameOptions.IndexOf(userChoice);
      int computerBattleWeapon = gameOptions.IndexOf(computerChoice);
      var result = userBattleWeapon > computerBattleWeapon ? "You have beaten your foe, revel in your glory!" : (userBattleWeapon < computerBattleWeapon ? "Your foe has struck you down! You die with the honor of fighting in battle" : "Looks like you both thought of the same thing... Guess you guys both die!");
      System.Console.WriteLine(result);
    }
  }
}
