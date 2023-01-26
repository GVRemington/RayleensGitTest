using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RayleensGitTest
{
    internal class Calculator
    {
        private decimal a;
        private decimal b;

        public decimal Multiply(decimal A, decimal B)
        {
            a= A;
            b= B;
            return a * b;
        }

        



    }
}
