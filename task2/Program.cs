// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string anyNumText = Convert.ToString(anyNum);
if (anyNumText.Length > 2){
  Console.WriteLine("третья цифра -" + anyNumText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}