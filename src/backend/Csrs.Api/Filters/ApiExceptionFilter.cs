using Csrs.Api.Models;
using Csrs.Interfaces.Dynamics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Csrs.Api.Filters
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {

        private readonly ILogger<ApiExceptionFilter> _logger;

        public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
        {
            _logger = logger;
        }
        public override void OnException(ExceptionContext context)
        {

            ApiError response = new ApiError();

            if (context.Exception is InvalidIdException)
            {

                var ex = context.Exception as InvalidIdException;     
                response.Error = "Invalid Id";
                response.Message = ex.Message;

                context.Exception = null;
                context.HttpContext.Response.StatusCode = 400;

            }
            else
            {

                context.HttpContext.Response.StatusCode = 500;
                response.Error = context.Exception.GetType().Name;
                response.Message = context.Exception.Message;

            }

            context.Result = new JsonResult(response);

            base.OnException(context);

        }
    }
}
