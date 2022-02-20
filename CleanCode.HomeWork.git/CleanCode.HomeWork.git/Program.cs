Console.WriteLine("Давай давай сыграем в игру ");
Console.WriteLine("Введи число 300 ( шутка про тракториста ) что-бы остановить игру");
bool win = false;
do
{
    int stopGame = 300;
    int secretrNumber = 10;
    Console.WriteLine("Введите число от 1 до 99");   
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber <= 0 && userNumber >= 100)
        Console.WriteLine("Введи верное число");
    else if(userNumber > secretrNumber  )
        Console.WriteLine($"не угадал! {userNumber} больше чем нужно");
    else if (userNumber < secretrNumber)
        Console.WriteLine($"не угадал! {userNumber} меньше чем нужно");

    
    if (userNumber == stopGame)
    {
        Console.WriteLine("Вы остановили игру");
        break;
    }

    if (userNumber == secretrNumber)
    {
        win = true;
        Console.WriteLine("Ты выиграл");
    }
  
}
while (!win);
     

 
