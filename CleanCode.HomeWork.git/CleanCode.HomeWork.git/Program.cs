Console.WriteLine("Давай давай сыграем в игру ");
Console.WriteLine("Введи число 300 ( шутка про тракториста ) что-бы остановить игру");
int stopGame = 300;
Random random = new();
int secretNumber = random.Next(0, 99);
bool win = false;
do
{

    Console.WriteLine("Введите число от 1 до 99");
    try
    {
        int userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber <= 0 || userNumber >= 100)
            Console.WriteLine("Введи верное число");
        else if (userNumber > secretNumber)
            Console.WriteLine($"не угадал! {userNumber} больше чем нужно");
        else if (userNumber < secretNumber)
            Console.WriteLine($"не угадал! {userNumber} меньше чем нужно");



        if (userNumber == stopGame)
        {
            Console.WriteLine("Вы остановили игру");
            break;
        }


        if (userNumber == secretNumber)
        {
            win = true;
            Console.WriteLine("Ты выиграл");
        }
    }
    catch
    {
        Console.WriteLine("Введи число, епт");
    }
   
  
}
while (!win);
     

 
