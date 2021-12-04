using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public ApiResponse(int statusCode = 500, string? message = null)
        {
            StatusCode = statusCode;
            Message = message ?? "An error has occurred";
        }
    }
}
