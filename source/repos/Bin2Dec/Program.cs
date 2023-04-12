
//user enters up to 8 binary digits
//notify if anything entered is other than 0 or 1
//User views the results in a single output field containing the decimal (base 10)
//// ^equivalent of the binary number that was entered

using System.ComponentModel.Design;

bool continueCalculate = true;
string answer;
double answerint;
double x = 2;
double y;
double result = 0;
bool continue2 = true;

string meme = "10123";

    
while (continueCalculate)
{
    result = 0;
    answerint = 0;
    y = 0;
    answer = "";
    Console.WriteLine("Enter up to 8 binary digits (0 or 1):");
    answer = Console.ReadLine();
    answerint = Convert.ToDouble(answer);



    //to check if user inputed more than 8 chars
    if (answer.Length > 8)
    {
        Console.Write("If you want to end, type 'N'. Enter only up to 8 digits. Try again :");
      
    }
    //option for user to exit program
    if (answer == "N")
    {
        break;
    }


    if (continue2 = false)
    {
        Console.WriteLine("Press N to exit. If you want to continue, input only binary digits which are 0 & 1. Try Again: ");
    }


    //start of calculator

        for (int i = answer.Length - 1; i <= answer.Length; i--) //calculator  proper
    {
        answerint = Convert.ToInt32(answer[i]) - 48;
        result += (answerint * Math.Pow(2, y++));

        if (i == 0)
        {
            break;
        }

    }
    Console.WriteLine(result);
}

Console.WriteLine("Finish");


