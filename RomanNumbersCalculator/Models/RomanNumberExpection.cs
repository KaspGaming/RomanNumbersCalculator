using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumberExpection : Exception
    {
        public RomanNumberExpection(string message) : base(message) { }
    }
}