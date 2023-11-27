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

        private double variableA;
        public double VariableA
        {
            get { return variableA; }
            set { variableA = value; }
        }

        private double variableB;
        public double VariableB
        {
            get { return variableB; }
            set { variableB = value; }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public CurrentOperation(double variableA, string operation, double variableB)
        {
            VariableA = variableA;
            VariableA = variableB;
            Operation = operation;
        }

    }
}
