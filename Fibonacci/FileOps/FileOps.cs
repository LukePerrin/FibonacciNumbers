using System.IO;

namespace ReadFile.FileOps
{
    public sealed class FileReader
    {
        private static FileReader? _instance;

        public static FileReader Instance
        {
            get
            {                
                return _instance ??= new FileReader();
            }
        }

        private FileReader()
        {
            // cannot be created except within this class            
        }

        public string ReadFile(string filename)
        {
            using (var sr = new StreamReader($"{filename}.txt"))
            {
                var numbersAsString = sr.ReadToEnd();

                return numbersAsString;
            }
        }
    }
}
