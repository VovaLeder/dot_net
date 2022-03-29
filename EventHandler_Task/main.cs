using dot_net_1;

namespace dot_net_1
{

    // Это было сделано даже не через dotnet run, а через 
        // -> csc main.cs    создав exe файл
        // -> main    и так запустив его

    class Hello {         
        static void Main(string[] args)
        {
            
            SomeClass someClass = new SomeClass();
            someClass.OnKeyPressed += (sender, key) => System.Console.WriteLine("You wrote: " + key);

            someClass.Run();

        }
    }
}