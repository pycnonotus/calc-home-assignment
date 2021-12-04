using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class MathResultDto
    {
        public MathResultDto() { }

        public MathResultDto(double value)
        {
            Value = value;
        }

        public double Value { get; set; }
    }
}