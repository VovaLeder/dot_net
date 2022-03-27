using System.IO;
using genericsTask;

namespace genericsTask 
{ 
    class LocalFileLogger<T>: ILogger
    {
        public void LogInfo(string message){
            File.AppendAllText("log.log", $"[Info]: [{typeof(T).FullName}] : {message}\n");
        }
        public void LogWarning(string message){
            File.AppendAllText("log.log", $"[Warning] : [{typeof(T).FullName}] : {message}\n");
        }
        public void LogError(string message, Exception ex){
            File.AppendAllText("log.log", $"[Error] : [{typeof(T).FullName}] : {message}. {ex.Message}\n");
        }
    }
}