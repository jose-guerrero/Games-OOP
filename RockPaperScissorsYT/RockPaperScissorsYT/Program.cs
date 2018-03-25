using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace RockPaperScissorsYT
{

    class Program
    {


        static void Main(string[] args)
        {
            var player = new RPSGame();
            char response;

            Console.WriteLine("Would you line to play a game of rock, paper, scissors (y or n)");
            response = Convert.ToChar(Console.ReadLine());

            while (player.ValidateResponse(response) == false)
            {
                Console.WriteLine("Invalid Input. Please re-enter your selection");
                response = Convert.ToChar(Console.ReadLine());
            }

            if (response == 'Y' || response == 'y')
            {
                Console.Clear();
                player.PlayGame();
            }
            Console.WriteLine("Good bye");
            Console.ReadLine();

        }
    }
}
