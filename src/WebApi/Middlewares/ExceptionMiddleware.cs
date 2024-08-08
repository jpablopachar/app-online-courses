using Application.Core;
using Newtonsoft.Json;

namespace WebApi.Middlewares
{
    public class ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger, IHostEnvironment env)
    {
        private readonly RequestDelegate _next = next;
        private readonly ILogger<ExceptionMiddleware> _logger = logger;
        private readonly IHostEnvironment _env = env;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, exception.Message);

                var response = exception switch
                {
                    ValidationException validationException => new AppException(StatusCodes.Status400BadRequest, "Error de validación", string.Join(",", validationException.Errors!.Select(error => error.ErrorMessage))),
                    _ => new AppException(context.Response.StatusCode, exception.Message, exception.StackTrace?.ToString())
                };

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = response.StatusCode;

                var json = JsonConvert.SerializeObject(response);

                await context.Response.WriteAsync(json);
            }
        }
    }
}