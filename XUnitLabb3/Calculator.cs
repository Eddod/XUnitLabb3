using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitLabb3
{
    public class Calculator
    {
        public decimal Result { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public char Action { get; set; }

        public Calculator()
        {

        }

        public decimal Add()
        {
            Result = X + Y;

            return Result;
        }

        public decimal Subtract()
        {
            Result = X - Y;

            return Result;
        }

        public decimal Multiply()
        {
            Result = X * Y;

            return Result;
        }
        public decimal Divide()
        {
            try
            {
               Result = X / Y;
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            return Result;

        }
    }
}
