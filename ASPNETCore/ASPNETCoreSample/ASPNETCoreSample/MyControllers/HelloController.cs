using ASPNETCoreSample.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace ASPNETCoreSample.MyControllers
{
    public class HelloController
    {
        private readonly IBooksService _sampleService;
        private readonly ILogger<HelloController> _logger;
        public HelloController(IBooksService sampleService, ILogger<HelloController> logger)
        {
            _sampleService = sampleService;
            _logger = logger;
        }

        public string Books() =>
            Log(nameof(Books), GetHtmlBooksList);

        private string GetHtmlBooksList() =>
            $"<ul>{GetBooksAsListItems()}</ul>";

        private string GetBooksAsListItems() =>
            string.Join("", _sampleService.GetBooks().Select(b => $"<li>{b.Title}</li>"));

        private string Log(string message, Func<string> action)
        {
            _logger.LogInformation($"{message} started");
            string result = action();
            _logger.LogInformation($"{message} completed");
            return result;
        }
    }
}
