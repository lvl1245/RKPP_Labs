using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKPP_Labs.Lab2
{
    class WorkshopNegativValueExeption : ArgumentException
    {
        public int Value { get; }
        public WorkshopNegativValueExeption(string message, int val)
        : base(message)
        {
            Value = val;
            Console.WriteLine(message +$": {Value}" );
        }
    }
}
