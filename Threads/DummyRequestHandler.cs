namespace Threads
{
    /// <summary>
    /// Тестовый обработчик запросов.
    /// </summary>
    public class DummyRequestHandler : IRequestHandler
    {
        /// <inheritdoc />
        public string HandleRequest(string message, string[] arguments)
        {
            // Притворяемся, что делаем что то.
            Thread.Sleep(10_000);
            if (message.Contains("fall"))
            {
                return $"!!! The message {message} has been fallen down... as asked";
            }
            var id = Guid.NewGuid().ToString("D");
            return $"!!! The message {message} has been sent. Unique ID: " + id;
        }
    }
}