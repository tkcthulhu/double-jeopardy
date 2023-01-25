using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below

      string[] questions = {
        "The human body has four lungs.",
        "Human skin regenerates every week.",
        "The average human sneeze can be clocked at 100 miles an hour.",
        "Humans lose an average of 75 strands of hair a month.",
        "Infants have more bones than adults.",
        "The heart is the largest internal organ in the body.",
        "Most of the human brain is made of muscle.",
        "Taste buds can only be found on the tongue.",
        "The human eye can distinguish 10 million different colors.",
        "Humans lose more than 80% of heat from their feet.",
        "The human body is about 60% water.",
        "The most common blood type is 0- negative."
        };

      bool[] answers = {
        false,
        false,
        true,
        false,
        true,
        false,
        false,
        false,
        true,
        false,
        true,
        true
      };

      bool[] responses = new bool[answers.Length];

      string [] funFacts = {
        "it has two. Those lungs aid the average person in breathing 11,000 liters of air every day.",
        "it regenerates every 28 days with an average of 0.001 – 0.003 ounces of skin flakes every hour).",
        "and be sure to cover your nose, a sneeze can create upwards of 100,000 droplets.",
        "humans can lose up to 75 strands in ONE DAY.",
        "infants are born with approximately 300 bones but have 206 by the time they reach adulthood.",
        "the largest internal organ in the body is the liver (the skin is the largest overall).",
        "60% is made up of fat, making it the fattiest organ.",
        "while most taste buds are on your tongue, there are also taste cells in the back of your throat, on your epiglottis, your nose and sinuses, throat and upper part of the esophagus.",
        "the average human eye contains three cones sensitive to red, green, and blue wavelengths of light. ",
        "80% of heat is lost through the head.",
        "water is essential for every cell to function.",
        "and AB- negative is the rarest. "
      };

      int score = 0;
      int possibleScore = answers.Length;

      for (int i = 0; i < answers.Length; i++)
      {
        string question = questions[i];

        Console.WriteLine(question);
        string stringResponse = Console.ReadLine().ToLower();
        bool response;
        bool isBool = Boolean.TryParse(stringResponse, out response);
        responses[i] = response;
        if (!isBool) {
          Console.WriteLine("Please enter a valid response (true or false)");
          i--;
          continue;
        }
        if (responses[i] == answers[i]) {
          Console.WriteLine($"Correct! {funFacts[i]}");
          score++;
        } else {
          Console.WriteLine($"Incorrect, the answer was {answers[i]}, {funFacts[i]}");
        }
      }

      Console.WriteLine($"All done! You got {score} out of {possibleScore} questions correct!");
      
    }
  }
}
