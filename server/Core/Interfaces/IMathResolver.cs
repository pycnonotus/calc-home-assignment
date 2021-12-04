using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Core.Interfaces
{
    public interface IMathResolver
    {
        Task<MathResultDto> ResolveMathQuestionAsync(MathQuestionDto mathQuestion);
    }
}