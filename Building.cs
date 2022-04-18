using System;

class Check
{
  public int Day;
  private string _daystring;
  private string _monthstring;
  private string _yearstring;
  public int Month;
  public int Year;
  private bool CheckTryParse(string _daystring, string _monthstring, string _yearstring)
  {
    if (int.TryParse(_daystring, out Day) 
      && int.TryParse(_monthstring, out Month)
      && int.TryParse(_yearstring, out Year))
      return true;
    else 
      return false; 
  }
  private bool CheckDay(int day)
  {
    if (day <= 31 && day >= 1)
      return true;
    else 
      return false;
  }

  private bool CheckMonthYear(int month, int year)
  {
    if (month <= 12 && month >= 1 && year >= 1)
      return true;
    else 
      return false;
  }

  public bool CheckDate(string date)
  {
    if (date.Length == 10 && date[2] == '.' && date[5] == '.')
    {
      string[] subs = date.Split('.', 3);
      _daystring = subs[0];
      _monthstring = subs[1];
      _yearstring = subs[2];
      if (!CheckTryParse(_daystring, _monthstring, _yearstring))
        return true;
      if (!CheckDay(Day) || !CheckMonthYear(Month, Year))
        return true;
      return false;
    }
    else 
      return true;
  }
}

class InputTextDate
{
  private int _ten;
  public string[] MonthText = {"Січня", "Лютого", "Березня", "Квітня", "Травня", "Червня", 
                                "Липня", "Серпня", "Вересня", "Жовтня", "Листопада", "Грудня"};                  
                                
  public string NumInTextDay(int day)
  {
    var DayText = new Dictionary<int, string>()
    {
      [1] = "Перше",
      [2] = "Друге",
      [3] = "Третє",
      [4] = "Четверте",
      [5] = "П'яте",
      [6] = "Шосте",
      [7] = "Сьоме",
      [8] = "Восьме",
      [9] = "Дев'яте",
      [10] = "Десяте",
      [11] = "Одинадцяте",
      [12] = "Дванадцяте",
      [13] = "Тринадцяте",
      [14] = "Чотирнадцяте",
      [15] = "П'ятнадцяте",
      [16] = "Шістнадцяте",
      [17] = "Сімнадцяте",
      [18] = "Вісімнадцяте",
      [19] = "Дев'ятнадцяте",
      [20] = "Двадцяте",
      [21] = "Двадцять",
      [30] = "Тридцяте",
      [31] = "Тридцять",
    };
    if (day < 20 || day % 10 == 0)
      return (" " + DayText[day]);
    else 
      return (" " + DayText[day / 10 * 10 + 1] + " " + DayText[day % 10]);
  }
  public string NumInTextMonth(int month)
  {
    return MonthText[month-1];
  }
  public string NumInTextYear(int year)
  {
    int thousand;
    int hundred;
    int ten;
    int unit;
    thousand = year / 1000;
    hundred = year / 100 % 10;
    ten = year / 10 % 10;
    unit = year % 10;
    return (NumInTextThousand(thousand) + 
            NumInTextHundred(hundred) + 
            NumInTextTen(ten) + 
            NumInTextUnit(unit));
  }
  private string NumInTextThousand(int thousand)
  {
    var YearText = new Dictionary<int, string>()
    {
      [1] = "Тисяча",
      [2] = "Дві",
      [3] = "Три",
      [4] = "Чотири",
      [5] = "П'ять",
      [6] = "Шість",
      [7] = "Сім",
      [8] = "Вісім",
      [9] = "Дев'ять",
      [10] = "Тисячі",
      [11] = "Тисяч",
    };
    if (thousand > 1 && thousand <= 5)
      return (YearText[thousand] + " " + YearText[10]);
    else if (thousand >= 6)
      return (YearText[thousand] + " " + YearText[11]);
    else if (thousand == 1)
      return YearText[thousand];
    else 
      return "";
  }
  private string NumInTextHundred(int hundred)
  {
    var HundredText = new Dictionary<int, string>()
    {
      [1] = "Сто",
      [2] = "Двісті",
      [3] = "Триста",
      [4] = "Чотириста",
      [5] = "П'ятьсот",
      [6] = "Шістьсот",
      [7] = "Сімсот",
      [8] = "Вісімсот",
      [9] = "Дев'ятсот",
    };
    if (hundred > 0)
      return (" " + HundredText[hundred]);
    else
      return "";
  }
  private string NumInTextTen(int ten)
  {
    var TenText = new Dictionary<int, string>()
    {
      [2] = "Двадцять",
      [3] = "Тридцять",
      [4] = "Сорок",
      [5] = "П'ятьдесят",
      [6] = "Шістьдесят",
      [7] = "Сімдесят",
      [8] = "Вісімдесят",
      [9] = "Дев'яносто",
    };
    if (ten >= 2)
      return (" " + TenText[ten]);
    else if (ten == 0)
      return "";
    else 
      {
        _ten = 1;
        return "";
      }
  }
  private string NumInTextUnit(int unit)
  {
    var UnitText = new Dictionary<int, string>()
    {
      [1] = "Першого",
      [2] = "Другого",
      [3] = "Третього",
      [4] = "Четвертого",
      [5] = "П'ятого",
      [6] = "Шостого",
      [7] = "Сьомого",
      [8] = "Восьмого",
      [9] = "Дев'ятого",
      [11] = "Одинадцятого",
      [12] = "Дванадцятого",
      [13] = "Тринадцятого",
      [14] = "Чотирнадцятого",
      [15] = "П'ятнадцятого",
      [16] = "Шістнадцятого",
      [17] = "Сімнадцятого",
      [18] = "Вісімнадцятого",
      [19] = "Дев'ятнадцятого",
    };
    if (_ten == 1)
      return (" " + UnitText[unit + 10] + " року");
    else if (unit == 0)
      return ("" + " року"); 
    else
      return (" " + UnitText[unit] + " року");
  }
}
class InputConclusion
{
  static void Main()
  {
    Check r1 = new Check();
    InputTextDate r2 = new InputTextDate();
    string date;
    do
    {
    Console.WriteLine("Введите дату формата dd.mm.yyyy: ");
    date = Console.ReadLine();
    } while(r1.CheckDate(date));
    Console.WriteLine("Введенная дата: " + date);
    Console.WriteLine("Введенная дата словами: " + r2.NumInTextDay(r1.Day) + 
                                             " " + r2.NumInTextMonth(r1.Month) +
                                             " " + r2.NumInTextYear(r1.Year));
  }
}