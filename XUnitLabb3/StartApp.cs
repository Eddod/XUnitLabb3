using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitLabb3
{
    public class StartApp
    {
        List<Calculator> calculateList = new List<Calculator>();

        public void AddToHistory(Calculator cal)
        {
            calculateList.Add(cal);
        }

        public void showHistory()
        {
            foreach (var item in calculateList)
            {
                Console.WriteLine($"{item.X} {item.Action} {item.Y} = {item.Result}");
            }
        }

        public void Start()
        {
            bool active = true;
            while (active)
            {
                char operation;
                Console.WriteLine("Press + to add");
                Console.WriteLine("Press - to subtract");
                Console.WriteLine("Press * to multiply");
                Console.WriteLine("Press / to divide");
                Console.WriteLine("Press 5 to show history");

                try
                {
                    operation = Convert.ToChar(Console.ReadLine());
                }
                catch (Exception)
                {

                    throw new ArgumentException("Invalid input");
                }







                switch (operation)
                {
                    case '+':
                        Calculator plus = new Calculator();
                        plus.X = Convert.ToInt32(Console.ReadLine());
                        plus.Y = Convert.ToInt32(Console.ReadLine());
                        plus.Action = '+';
                        plus.Add();
                        Console.WriteLine($"{plus.X} {plus.Action} {plus.Y} = {plus.Result}");
                        AddToHistory(plus);

                        break;
                    case '-':
                        Calculator minus = new Calculator();
                        minus.X = Convert.ToInt32(Console.ReadLine());
                        minus.Y = Convert.ToInt32(Console.ReadLine());
                        minus.Action = '-';
                        minus.Subtract();
                        Console.WriteLine($"{minus.X} {minus.Action} {minus.Y} = {minus.Result}");
                        AddToHistory(minus);
                        break;

                    case '*':
                        Calculator multiply = new Calculator();
                        multiply.X = Convert.ToInt32(Console.ReadLine());
                        multiply.Y = Convert.ToInt32(Console.ReadLine());
                        multiply.Action = '*';
                        multiply.Multiply();
                        Console.WriteLine($"{multiply.X} {multiply.Action} {multiply.Y} = {multiply.Result}");
                        AddToHistory(multiply);
                        break;

                    case '/':
                        Calculator divide = new Calculator();
                        divide.X = Convert.ToInt32(Console.ReadLine());
                        divide.Y = Convert.ToInt32(Console.ReadLine());
                        divide.Action = '/';
                        divide.Divide();
                        if (divide.Y == 0)
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        else
                        {
                            Console.WriteLine($"{divide.X} {divide.Action} {divide.Y} = {divide.Result}");
                            AddToHistory(divide);
                        }
                        break;

                    case '5':
                        showHistory();
                        break;

                    default:
                        Console.WriteLine("Incorrect input, try again");
                        break;
                }
            }
        }
    }
}
