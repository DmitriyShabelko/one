// Разработать программу, используя возврат обьектов из метода. 
// 1. при запуске кода пользователь вводит половину ширины и длины прямоугольника
// 2. необходимо создать метод, который будет принимать половину ширины и длины и умножать на 2
// 3. вывести в консоль 
//   1) изначально введенные данные пользователем
//   2) ширину и длину прямоугольника
//   3) периметр прямоугольника
// 4. в главном методе не должно происходить вычислений

using System;

class Calc
{
  private int day;
  private int month;
  private int year;
  public bool Check(string date)
  {
        if ((date.Length != 10) && (date[2] != '.') && (date[5] != '.'))
      return true;
    else 
      return false;
  }
}

class InputConclusion
{
  static void Main()
  {
    Calc r1 = new Calc();
    string date;
    do
    {
    Console.WriteLine("Введите дату формата dd.mm.yyyy: ");
    date = Console.ReadLine();
    } while(r1.Check(date));
    Console.WriteLine("Введенная дата: " + date);
  }
}