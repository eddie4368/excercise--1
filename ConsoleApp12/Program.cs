using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static Dictionary<string, int> votes = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            while (true)// creates an infinite loop ensures the program still runs until user chooses to exit.
            {
                Console.WriteLine("1. Cast Vote");// These lines display the menu options to the user.
                Console.WriteLine("2. Display Results");
                Console.WriteLine("3. Reset Votes");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());// this line reads the user's input and stores in the "choice" varible.

                switch (choice) // used to execute different code blocks based on the user's choice.
                {
                    case 1:
                        CastVote();// calls CastVote the method
                        break;
                    case 2:
                        DisplayResults(); // calls DisplayResults the method
                        break;
                    case 3:
                        ResetVotes();// calls ResetVotes the method
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void CastVote()// this declares a static method CastVote();
        {
            Console.Write("Enter candidate name: ");// prompts user to enter a canidate name 
            string candidateName = Console.ReadLine();// reads the user's input and stores it in candidateName varible

            if (votes.ContainsKey(candidateName)) //line checks if the votes dictionary contains a key with same name as the entered canidate.
            {
                votes[candidateName]++;// if canidates exists in the dictionary this line increments the corresponding vote.
            }
            else// if candidate doesnt exist in the dictionary, this block of code would be executed
            {
                votes[candidateName] = 1;
            }

            Console.WriteLine("Vote cast successfully."); // displays when user inputs vote. 
        }

        static void DisplayResults()// provides a way to view the current voting results.
        {
            Console.WriteLine("Voting Results:");//displays the voting results
            foreach (var kvp in votes)// this loop iterates over each key-value pair in the votes dictionary.
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} votes");// this line prints the candidate name and corresponding vote count in a formatted string
            }
        }

        static void ResetVotes()// alloes user to start over with a new election.
        {
            votes.Clear();//This line clears the votes dictionary effectively resetting all vote counts to zero
            Console.WriteLine("Votes reset.");// prints message indicating that the votes have been reset.
        }
    }
}

           
        
    

