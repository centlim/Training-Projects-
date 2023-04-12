
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

Random random = new Random();
bool playAgain = true;
string player;
string computer;
string answer;
int win = 0;
int lose = 0;
int draw = 0;
//int winTally = 0;
//int loseTally = 0;
//int drawTally = 0;



while (playAgain)
{
    player = "";
    computer = "";
    //win = 0;
    //lose = 0;
    //draw = 0;


    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") 
    {
        Console.WriteLine("Enter ROCK, PAPER, SCISSORS :");
        player = Console.ReadLine();
        player = player.ToUpper();
       
    }
    switch (random.Next(1,4))
    {
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }
    Console.WriteLine($"Computer: {computer}");
    Console.WriteLine($"Player: {player}");

    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("It's a draw!");
                draw += 1;
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You lose!");
                lose += 1;
            }
            else
            {
                Console.WriteLine("You WIN!");
                win += 1;
            }

            break;
        case "PAPER":
            {
                if (computer == "ROCK")
                {
                    Console.WriteLine("You WIN!");
                    win += 1;

                }
                else if (computer == "PAPER")
                {
                    Console.WriteLine("It's a draw.");
                    draw += 1;

                }
                else
                {
                    Console.WriteLine("You lose!");
                    lose += 1;

                }

            }
            break;
        case "SCISSORS":
            {
                if (computer == "ROCK")
                {
                    Console.WriteLine("You lose.");
                    lose += 1;

                }
                else if (computer == "PAPER")
                {
                    Console.WriteLine("You WIN!");
                    win += 1;

                }
                else
                {
                    Console.WriteLine("It's a draw!");
                    draw += 1;

                }

            }
            break;
    }


    //winTally += win;
    //loseTally += lose;
    //drawTally += draw; 



    Console.WriteLine($"Your score is: W {win} - L {lose} - D {draw}");
    Console.WriteLine();
    Console.WriteLine("Do you want to play again? Y/N :");

    

    answer = Console.ReadLine();
    answer = answer.ToUpper();
    if (answer == "Y") 
    {
        playAgain = true; 
    }
    else
    { 
        playAgain = false; 
    }




}
Console.WriteLine("Thank you for playing!");