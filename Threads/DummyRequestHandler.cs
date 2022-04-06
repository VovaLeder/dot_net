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
                throw new Exception("I fell down as you asked");
            }
            return Guid.NewGuid().ToString("D");
        }
    }
}