Console.WriteLine("Пн (1) ");
Console.WriteLine("Вт (2) ");
Console.WriteLine("Ср (3) ");
Console.WriteLine("Чт (4) ");
Console.WriteLine("Пт (5) ");
Console.WriteLine("Сб (6) ");
Console.WriteLine("Вс (7) ");

Console.Write("Напишите цифру дня недели которое вы хотите увидеть: ");

string text = Console.ReadLine();
int number = Convert.ToInt32(text);

if (number == 1)
{
  Console.Write("Это Пн, не выходной");
}else
if (number == 2)
{
  Console.Write("Это Вт, не выходной");
}else
if (number == 3)
{
  Console.Write("Это Ср, не выходной");
}else
if (number == 4)
{
  Console.Write("Это Чт, не выходной");
}else
if (number == 5)
{
  Console.Write("Это Пт, не выходной");
}else
if (number == 6)
{
  Console.Write("Это Сб, выходной");
}else
if (number == 7)
{
  Console.Write("Это Вс, выходной");
}
else
{
    Console.Write("Этого дня нету");
}
