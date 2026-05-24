namespace HerokuTests.Utils
{
    public static class FileUtils
    {
        static string downloadDir = @"C:\Users\yulem\Downloads\";

        public static bool WaitForFile(string fileName, TimeSpan timeout)
        {
            string path = Path.Combine(downloadDir, fileName);
            var start = DateTime.Now;
            while (DateTime.Now - start < timeout)
            {
                if (File.Exists(path)) // вернёт true, если файл есть
                {
                    return true;
                }
                Thread.Sleep(500);
            }
            return false;
        }

        public static void DeleteFile(string fileName) 
        {
            string path = Path.Combine(downloadDir, fileName);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
