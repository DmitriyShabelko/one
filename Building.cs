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