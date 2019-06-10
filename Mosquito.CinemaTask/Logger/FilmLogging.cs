using System.IO;

namespace Mosquito.CinemaTask.Logger
{
    public class FilmLogging : ILogger
    {
        string path = "~/Logger/log.txt";
        public FilmLogging()
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

        }

        public void WriteLine(string log)
        {
            using (StreamWriter logFile = new StreamWriter(path))
            {
                logFile.Write(log);
            }
        }
    }
}