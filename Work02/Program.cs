int number = new Random().Next(10, 9999); 
 Console.WriteLine("Случайное число: " + number);
 int a = number % 10;
 int first = number / 10; // 45 / 10 == 4
 int second = first % 10; // 45 % 10 == 5

if (number > 1000)
 {
     Console.WriteLine("Третья цифра: " + second);
 }else if (number > 100)
 {
     Console.WriteLine("Третья цифра: " + a );
 } else if (number < 100)
 {
    Console.WriteLine("Третьей цифры нет" );
 }

