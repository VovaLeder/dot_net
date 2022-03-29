using genericsTask;

namespace genericsTask
{
    class MainClass {         
        static void Main(string[] args)
        {
            File.WriteAllText("log.log", "");

            LocalFileLogger<int> lflInt = new LocalFileLogger<int>();

            lflInt.LogInfo("SomeInfo");
            lflInt.LogWarning("SomeWarning");
            lflInt.LogError("SomeError", new Exception());


            LocalFileLogger<string> lflString = new LocalFileLogger<string>();
            
            lflString.LogInfo("SomeInfo");
            lflString.LogWarning("SomeWarning");
            lflString.LogError("SomeError", new Exception());


        }
    }
}