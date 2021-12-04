using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class MathQuestionDto
    {
        [Required]
        public double? X { get; set; }
        [Required]
        public double? Y { get; set; }
        [Required]

        public char? MathOperator { get; set; }
    }
}