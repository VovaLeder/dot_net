using genericsTask;

namespace genericsTask
{
    class MainClass {         
        static void Main(string[] args)
        {
            File.WriteAllText("log.log", "");

            LocalFileLogger<int> lflInt = new LocalFileLogger<int>("log.log");

            lflInt.LogInfo("SomeInfo");
            lflInt.LogWarning("SomeWarning");
            lflInt.LogError("SomeError", new Exception());


            LocalFileLogger<string> lflString = new LocalFileLogger<string>("log.log");
            
            lflString.LogInfo("SomeInfoAboutString");
            lflString.LogWarning("SomeWarningAboutString");
            lflString.LogError("SomeErrorAboutString", new Exception());


        }
    }
}