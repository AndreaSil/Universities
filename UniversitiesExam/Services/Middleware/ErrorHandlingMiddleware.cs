using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using UniversitiesExam.Services.Exceptions;

namespace UniversitiesExam.Services.Middleware
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        public static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var code = HttpStatusCode.InternalServerError; // error 500
            if (ex is RepositoryException) code = HttpStatusCode.NotAcceptable;
            else if (ex is SplitException) code = HttpStatusCode.BadRequest;
            else if (ex is ServiceException) code = HttpStatusCode.NoContent;

            var result = JsonConvert.SerializeObject(new { error = ex.Message });
            context.Response.ContentType = "aplication/json";
            context.Response.StatusCode = (int)code;
            return context.Response.WriteAsync(result);



        }
    }
}
