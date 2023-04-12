int number = new Random().Next(100, 999); 
 Console.WriteLine("Случайное число: " + number);
 int first = number / 10; // 45 / 10 == 4
 int second = first % 10; // 45 % 10 == 5
 Console.WriteLine("Число по середине: " + second);
