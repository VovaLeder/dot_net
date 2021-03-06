namespace Threads
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("> --- App is running");

            Console.Write("> --- Input text for your request. To exit print /exit\n> ");
            string com = Console.ReadLine();
            while (com == null || com == "" || com == "/end")
            {
                Console.Write("> --- Please don't enter empty string or command /end.\n> ");
                com = Console.ReadLine();
            }
            string req_com = com;
            
            bool first_arg = true;
            List<string> req_args = new List<string>();

            while (com != "/exit")
            {
                if (com == "/end")
                {
                    ThreadPool.QueueUserWorkItem(callback => HandleRequest(com, req_args.ToArray()));

                    Console.Write("> --- Input text for your request. To exit print /exit\n> ");

                    first_arg = true;
                    req_args = new List<string>();

                    com = Console.ReadLine();
                    while (com == null || com == "" || com == "/end")
                    {
                        Console.Write("> --- Please don't enter empty string or command /end.\n> ");
                        com = Console.ReadLine();
                    }
                    req_com = com;
                }
                else
                {
                    if (first_arg) {
                        Console.Write("> --- Input argument for your request. If no need in arguments, print /end\n> ");

                        first_arg = false;
                    }
                    else Console.Write("> --- Input one more argument for your request. If no need in arguments, print /end\n> ");

                    com = Console.ReadLine();

                    while (com == null || com == "") Console.Write("> --- Please don't enter empty string.\n> ");

                    if (com != "/end") req_args.Add(com);
                }
            }    
            Console.WriteLine("> --- App is shutting down.");        
        }

        public static void HandleRequest(String com, string[] args)
        {
            DummyRequestHandler drh = new DummyRequestHandler();
            var id = Guid.NewGuid().ToString("D");
            Console.WriteLine($"-!- The message {com} has been sent. Unique id: {id}.");
            Console.Write("> ");

            try
            {
                var ans_id = drh.HandleRequest(com, args);
                Console.WriteLine($"-!- The message with id={id} received an answer with unique id: {ans_id}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"!!! The message with id={id} fell down with an exception: {e.Message}");
            }
            
            Console.Write("> ");
        }

    }
}
