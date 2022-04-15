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

  // public bool CheckDot(char dot)
  // {
  //   if (dot == '.')
  //     return false;
  //   else 
  //     return true;
  // }
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
    
    // Check(date);
    Console.WriteLine("Введенная дата: " + date);
    // Console.WriteLine(TypeOf.date);
  }
}



// class Rect
// {
//   int width;
//   int height;

//   public Rect (int w, int h)
//   {
//     width = w;
//     height = h;
//   }

//   public int Area()
//   {
//     return width * height;
//   }

//   public void Show()
//   {
//     Console.WriteLine(width + " " + height);
//   }

//   public Rect Enlarge(int factor)
//   {
//     return new Rect(width * factor, height * factor);
//   }
// }

// class RetObj
// {
//   static void Main()
//   {
//     Rect r1 = new Rect(4, 5);

//     Console.Write("Размеры прямоугольника r1: ");
//     r1.Show();
//     Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
//     Console.WriteLine();
//     // Создать прямоугольник в два раза больший прямоугольника rl.
//     Rect r2 = r1.Enlarge(2);
//     Console.Write("Размеры прямоугольника r2: ");
//     r2.Show();
//     Console.WriteLine("Площадь прямоугольника r2: " + r2.Area());

//   }
// }


// using System;
// class MyClass 
// {
//     int alpha, beta;
//     public MyClass(int i, int j) 
//     {
//         alpha = i;
//         beta = j;
//     }
//     // Возвратить значение true, если параметр ob
//     // имеет те же значения, что и вызывающий объект.
//     public bool SameAs(MyClass ob) 
//     {
//         if((ob.alpha == alpha) & (ob.beta == beta))
//         return true;
//         else return false;
//     }
//         // Сделать копию объекта ob.
//     public void Copy(MyClass ob) 
//     {
//         alpha = ob.alpha;
//         beta = ob.beta;
//     }
//     public void Show() 
//     {
//         Console.WriteLine("alpha: {0}, beta: {1}",
//         alpha, beta);
//     }
// }
// class PassOb 
// {
//     static void Main() 
//     {
//         MyClass ob1 = new MyClass(4, 5);
//         MyClass ob2 = new MyClass(6, 7);
//         Console.Write("ob1: ");
//         ob1.Show();
//         Console.Write("ob2: ");
//         ob2.Show();
//         if(ob1.SameAs(ob2))
//         Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
//         else
//         Console.WriteLine("ob1 и ob2 имеют разные значения.");
//         Console.WriteLine();
//         // // А теперь сделать объект ob1 копией объекта ob2.
//         ob1.Copy(ob2);
//         Console.Write("оЫ после копирования: ");
//         ob1.Show();
//         if(ob1.SameAs(ob2))
//         Console.WriteLine("ob1 и ob2 имеют одинаковые значения.");
//         else
//         Console.WriteLine("ob1 и ob2 имеют разные значения.");
//     }
// }
