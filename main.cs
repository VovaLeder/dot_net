using dot_net_1;

namespace dot_net_1
{
    class Hello {         
        static void Main(string[] args)
        {
            
            SomeClass someClass = new SomeClass();
            someClass.OnKeyPressed += (sender, key) => System.Console.WriteLine("You wrote: " + key);

            someClass.Run();

        }
    }
}