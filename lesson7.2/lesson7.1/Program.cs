// Decompiled with JetBrains decompiler
// Type: lesson7._1.Program
// Assembly: lesson7.1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 7D91161B-341C-4059-9008-2557856C210E
// Assembly location: C:\Users\Locky\source\repos\lesson7\lesson7.1\bin\Debug\net5.0\lesson7.1.dll

using System;

namespace lesson7._1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Введите своё имя:");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine(" Привет, " + Console.ReadLine() + "! Для выхода из программы нажми любую клавишу!");
      Console.ReadLine();
    }
  }
}
