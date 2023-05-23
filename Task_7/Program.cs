namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task_7
            // 1
            //try
            //{
                string dekstopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //    string dirName = "Task_7";

            //    if (!Directory.Exists(Path.Combine(dekstopPath, dirName)))
            //        Directory.CreateDirectory(Path.Combine(dekstopPath, dirName));

            //    string firstFileName = "data.txt";
            //    string firstFilePath = Path.Combine(dekstopPath, firstFileName);

            //    if (!File.Exists(firstFilePath))
            //        File.Create(firstFilePath).Close();

            //    File.WriteAllText(firstFilePath, "Hello World from first File!");

            //    string secondFileName = "rez.txt";
            //    string secondFilePath = Path.Combine(dekstopPath, secondFileName);

            //    if (!File.Exists(secondFilePath))
            //        File.Create(secondFilePath).Close();

            //    string content = File.ReadAllText(firstFilePath);
            //    File.WriteAllText(secondFilePath, content);

            //    var text = File.ReadAllText(secondFilePath);
            //    Console.WriteLine($"Second File = {text}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            // 2

            string directoryName = "DirectoryC.txt";
            string directoryPath = Path.Combine(dekstopPath, directoryName);


        }
    }
}