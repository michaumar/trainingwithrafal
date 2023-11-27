using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class CurrentOperation
    {
        private string operation;
        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        private double a;
        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;
        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public CurrentOperation(double a, string operation, double b)
        {
            A = a;
            B = b;
            Operation = operation;
        }

    }
}
