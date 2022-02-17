using Csrs.Interfaces.Dynamics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Csrs.Api.Filters
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {

            string response;

            if (context.Exception is InvalidIdException)
            {

                var ex = context.Exception as InvalidIdException;
                context.Exception = null;
                response = ex.Message;

                context.HttpContext.Response.StatusCode = 400;
            }
            else
            {
                context.HttpContext.Response.StatusCode = 500;
                response = context.Exception.Message;
            }

            context.Result = new JsonResult(response);

            base.OnException(context);

        }
    }
}
