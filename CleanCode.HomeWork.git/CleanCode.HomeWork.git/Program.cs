Console.WriteLine("Давай давай сыграем в игру /" +
                  "Введите число от 1 до 99");

int secretrNumber = 10;

    int userNumber;
    userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber <= 0 | userNumber >= 100) 

        Console.WriteLine("Введи верное число");
    else
        Console.WriteLine("не угадал!");

    if (userNumber == secretrNumber)

        Console.WriteLine("Ты выиграл");

 
