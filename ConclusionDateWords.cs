using System;

class Validation
{
  public int Day;
  public int Month;
  public int Year;
  private string _daystring;
  private string _monthstring;
  private string _yearstring;
  private bool CheckTryParse(string _daystring, string _monthstring, string _yearstring)
  {
    return !int.TryParse(_daystring, out Day)
      || !int.TryParse(_monthstring, out Month)
      || !int.TryParse(_yearstring, out Year);
  }
  private bool CheckDay(int day)
  {
    return !(day <= 31) || !(day >= 1);
  }

  private bool CheckMonthYear(int month, int year)
  {
    return !(month <= 12) || (month >= 1) || (year >= 1);
  }

  public bool CheckDate(string date)
  {
    if (!(date.Length == 10) || !(date[2] == '.') || !(date[5] == '.'))
      return false;
    else
    {
      string[] subs = date.Split('.', 3);
      _daystring = subs[0];
      _monthstring = subs[1];
      _yearstring = subs[2];
      return CheckTryParse(_daystring, _monthstring, _yearstring) || !CheckDay(Day) || !CheckMonthYear(Month, Year);
    }     
  }
}

class InputTextDate
{
  Validation _validationField;
  public InputTextDate(Validation validation)
  {
    _validationField = validation;
  }
  private int _ten;
  private string[] _monthText = {"Січня", "Лютого", "Березня", "Квітня", "Травня", "Червня", 
                                "Липня", "Серпня", "Вересня", "Жовтня", "Листопада", "Грудня"};                  
  private Dictionary<int, string> _dayText = new Dictionary<int, string>()
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
  private Dictionary<int, string> _yearText = new Dictionary<int, string>()
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
  private Dictionary<int, string> _hundredText = new Dictionary<int, string>()
  {
    [1] = "Сто",
    [2] = "Двухсот",
    [3] = "Триста",
    [4] = "Чотириста",
    [5] = "П'ятьсот",
    [6] = "Шістьсот",
    [7] = "Сімсот",
    [8] = "Вісімсот",
    [9] = "Дев'ятсот",
  };   
  private Dictionary<int, string> _tenText = new Dictionary<int, string>()
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
  private Dictionary<int, string> _unitText = new Dictionary<int, string>()
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
  public string NumInTextDay(int day)
  {    
    if (day < 20 || day % 10 == 0)
      return String.Format(" {0}", _dayText[day]);
    else 
      return String.Format(" {0} {1}", _dayText[day / 10 * 10 + 1], _dayText[day % 10]);
  }
  public string NumInTextMonth(int month)
  {
    return _monthText[month-1];
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
    if (thousand > 1 && thousand <= 5)
      return String.Format("{0} {1}", _yearText[thousand], _yearText[10]);
    else if (thousand >= 6)
      return String.Format("{0} {1}",_yearText[thousand], _yearText[11]);
    else if (thousand == 1)
      return _yearText[thousand];
    else 
      return "";
  }
  private string NumInTextHundred(int hundred)
  {
    return (hundred > 0) ? String.Format(" {0}", _hundredText[hundred]) : "";
  }
  private string NumInTextTen(int ten)
  {    
    if (ten >= 2)
      return (" " + _tenText[ten]);
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
    if (_ten == 1)
      return String.Format(" {0} року", _unitText[unit + 10]);
    else if (unit == 0)
      return (" року"); 
    else
      return String.Format(" {0} року",_unitText[unit]);
  }
  public string Сonclusion()
  {
    return String.Format("{0} {1} {2}", 
                          NumInTextDay(_validationField.Day), 
                          NumInTextMonth(_validationField.Month), 
                          NumInTextYear(_validationField.Year));
  }
}
class InputConclusion
{
  static void Main()
  {
    Validation _validationField = new Validation();
    InputTextDate inputTextDate = new InputTextDate(_validationField);
    String date;
    do
    {
    Console.WriteLine("Введите дату формата dd.mm.yyyy: ");
    date = Console.ReadLine();
    // date = "24.10.2312";
    } while(!_validationField.CheckDate(date));
    Console.WriteLine("Введенная дата: " + date);
    // Console.WriteLine(String.Format("{0} {1} {2}", r2.NumInTextDay(r1.Day), r2.NumInTextMonth(r1.Month), r2.NumInTextYear(r1.Year)));
      // "Введенная дата словами: " + r2.Сonclusion());
    Console.WriteLine("Введенная дата словами: " + inputTextDate.Сonclusion());
  }
}