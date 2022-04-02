using System.IO;
using genericsTask;

namespace genericsTask 
{ 
    class LocalFileLogger<T>: ILogger
    {
        private string Path {get; }
        public LocalFileLogger(string path)
        {
            Path = path;
        }
        public void LogInfo(string message){
            File.AppendAllText(Path, $"[Info]: [{typeof(T).FullName}] : {message}\n");
        }
        public void LogWarning(string message){
            File.AppendAllText(Path, $"[Warning] : [{typeof(T).FullName}] : {message}\n");
        }
        public void LogError(string message, Exception ex){
            File.AppendAllText(Path, $"[Error] : [{typeof(T).FullName}] : {message}. {ex.Message}\n");
        }
    }
}