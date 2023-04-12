// See https://aka.ms/new-console-template for more information

using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

string player;
bool playAgain = true;
bool continuePlay = true;
int answer;
int playerAnswer;
int scoreW;
int scoreL;


///FUNCTIONS
static int RandomX()    //RANDOMIZER
{
    Random rand = new Random();
    int x = rand.Next(1, 100);
    return x;
}
static int RandomY()    //RANDOMIZER
{
    Random rand = new Random();
    int y = rand.Next(1, 100);
    return y;
}

//PLAYER INTEGER GUARD
static string PlayerInput ()        //Function for user input
{
    string player = Console.ReadLine();
    player = player.ToUpper();
    return player;
}
static int PlayerAnswer(string player)      //Function to return user input to INT
{
    int.TryParse(player, out int playerAnswer);
    return playerAnswer;
}

static bool PlayerAnswerToQuestion (string player) //Function that checks if user input is INT
{
    if (double.TryParse(player, out double answer))
    {
        return false;
    }
    else
    {
        return true;
    }
}

static bool PlayerChoice(int playerAnswer)          //Function that checks if user selection to MENU is valid
{
    if (playerAnswer <= 4 && playerAnswer >= 1)
    {
        return false;
    }
    Console.WriteLine("Enter valid answer [1-4]: ");
    return true;
}

static bool PlayerQuit(string player)       //Function for user to EXIT game
{
    if (player == "Q")
    {
        Console.WriteLine("Thank you for playing!");
        return false;
    }
    else
    {
        return true;
    }
}

static int PlayerWin(int answer, int playerAnswer)
{
    if (answer == playerAnswer)
    {
        Console.WriteLine("You are CORRECT");
        return + 1;
    }
    return 0;
}

static int PlayerLose(int answer, int playerAnswer)
{
    if (answer != playerAnswer)
    {
        Console.WriteLine("You are WRONG");
        return +1;
    }
    return 0;
}

static void HelloWorld()
{
    Console.WriteLine("Choose between the following games: ");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("Enter the number of your choice!");
}





//GAME ANSWERS
static int Addition()
{
    int x = RandomX();
    int y = RandomY(); 
    Console.WriteLine($"{x} +  {y} ? :");
    return x + y;
}
static int Subtration()
{
    int x = RandomX();
    int y = RandomY();
    if (x - y <  0)
    {
        Console.WriteLine($"{y} -  {x} ? :");
        return y - x;
    }
    else
    {
        Console.WriteLine($"{x} -  {y} ? :");
        return x - y;
    }
}

static int Multiplication()
{
    Random rand = new Random();
    int x = rand.Next(2,50);
    int y = rand.Next(2,5);
    Console.WriteLine($"{x} *  {y} ? :");
    return x * y;
}


static int Division()
{
    int x = 0;
    int y = 0;
    Random rand2 = new Random();
    int answer;
    int answer2;

    do
    {
        x = RandomX();
        y = rand2.Next(2,51);
        answer = x % y;
        answer2 = x / y;
    }
    while (answer != 0 || answer2 == 1);
    Console.WriteLine($"{x} /  {y} ? :");
    return x / y;
}





//////  PROGRAM START   //////

Console.WriteLine("Welcome to the Math Game!");
while (playAgain)
{
    answer = 0;
    playerAnswer=0;
    scoreW = 0;
    scoreL = 0;
    //int x = 0; int y = 0;

    HelloWorld();



    while (continuePlay)
    {

        player = PlayerInput();
        if (PlayerQuit(player) == false)
        {
            break;
        }

        playerAnswer = PlayerAnswer(player);

        continuePlay = PlayerChoice(playerAnswer);

    }


///////////////////// 1 ADDITION

    if (playerAnswer == 1)
    {
        answer = 0;

        continuePlay = true;

        while (continuePlay)
        {
            answer = Addition();
            
            player = PlayerInput();

            if (PlayerQuit(player) == false)
            {
                break;
            }

            playerAnswer = PlayerAnswer(player);

            if (PlayerAnswerToQuestion(player) == true)
            {
                Console.WriteLine("Enter valid answer");
            }

            if (PlayerAnswerToQuestion(player) == false)
            {
                scoreL += PlayerLose(answer, playerAnswer);

                scoreW += PlayerWin(answer, playerAnswer);
            }
            Console.WriteLine($"Your score is W {scoreW} - L {scoreL}");
        }
    }

////////////////////////// 2 SUBTRACTION
    if (playerAnswer == 2)
    {
        answer = 0;

        continuePlay = true;

        while (continuePlay)
        {
            answer = Subtration();

            player = PlayerInput();

            if (PlayerQuit(player) == false)
            {
                break;
            }

            playerAnswer = PlayerAnswer(player);

            if (PlayerAnswerToQuestion(player) == true)
            {
                Console.WriteLine("Enter valid answer");
            }

            if (PlayerAnswerToQuestion(player) == false)
            {
                scoreL += PlayerLose(answer, playerAnswer);

                scoreW += PlayerWin(answer, playerAnswer);
            }
            Console.WriteLine($"Your score is W {scoreW} - L {scoreL}");
        }
    }

    ///////////////////MULTIPLICATION

    if (playerAnswer == 3)
    {
        answer = 0;

        continuePlay = true;

        while (continuePlay)
        {
            answer = Multiplication();

            player = PlayerInput();

            if (PlayerQuit(player) == false)
            {
                break;
            }

            playerAnswer = PlayerAnswer(player);

            if (PlayerAnswerToQuestion(player) == true)
            {
                Console.WriteLine("Enter valid answer");
            }

            if (PlayerAnswerToQuestion(player) == false)
            {
                scoreL += PlayerLose(answer, playerAnswer);

                scoreW += PlayerWin(answer, playerAnswer);
            }
            Console.WriteLine($"Your score is W {scoreW} - L {scoreL}");
        }
    }



    ////////////////////////// 4 DIVISION
    if (playerAnswer == 4)
    {
        answer = 0;

        continuePlay = true;

        while (continuePlay)
        {
            answer = Division();

            player = PlayerInput();

            if (PlayerQuit(player) == false)
            {
                break;
            }

            playerAnswer = PlayerAnswer(player);

            if (PlayerAnswerToQuestion(player) == true)
            {
                Console.WriteLine("Enter valid answer");
            }

            if (PlayerAnswerToQuestion(player) == false)
            {
                scoreL += PlayerLose(answer, playerAnswer);

                scoreW += PlayerWin(answer, playerAnswer);
            }
            Console.WriteLine($"Your score is W {scoreW} - L {scoreL}");
        }
    }




    Console.WriteLine($"Your final score is W {scoreW} - L {scoreL}");
    Console.WriteLine("Goodbye!");
    break;
}

