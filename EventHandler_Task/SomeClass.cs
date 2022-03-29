using System;

namespace dot_net_1
{
    class SomeClass {
        public event EventHandler<char> OnKeyPressed;

        private char getChar(){
            Console.Write("Your symbol: ");
            char c;
            try
            {
                c = Console.ReadLine().ToCharArray()[0];
            }
            catch (System.IndexOutOfRangeException e)
            {
                c = getChar();
            }
            
            return c;
        }

        public void Run(){
            char c = getChar();
            while (c != 'c')
            {
                OnKeyPressed.Invoke(this, c);
                c = getChar();
            }
        }
    }
}