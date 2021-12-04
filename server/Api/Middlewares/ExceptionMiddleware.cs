// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
//
// namespace Api.Middlewares
// {
//     public class ExceptionMiddleware
//     {
//         private readonly RequestDelegate next;
//         public async Task InvokeAsync(HttpContext context)
//         {
//             try{
//                 await next(context);
//             }catch(Exception e){
//                 
//             }
//         }
//     }
//
//
// }