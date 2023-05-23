namespace HomeWork_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HomeWork 7

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // 1
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePhones = "phones.txt";
            string filePath = Path.Combine(desktopPath, filePhones);

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                File.WriteAllText(filePath, 
                    "80974468233 - Anton\r\n" +
                    "80974468234 - Antin\r\n" +
                    "80974468235 - Antonio\r\n" +
                    "80974468236 - Aton\r\n" +
                    "80974468237 - Atello\r\n" +
                    "80974468238 - Atlant\r\n" +
                    "80974468239 - Antek\r\n" +
                    "80974468240 - Apollo\r\n" +
                    "80974468241 - Artur");
            }

            string[] contacts = File.ReadAllLines(filePath);

            foreach (string contact in contacts)
            {
                string[] splitContact = contact.Split('-');
                phoneBook[splitContact[0].Trim()] = splitContact[1].Trim();
            }

            string filePhoneNumbers = "phones2.txt";
            string filePhoneNumbersPath = Path.Combine(desktopPath, filePhoneNumbers);

            if (!File.Exists(filePhoneNumbersPath))
                File.Create(filePhoneNumbersPath).Close();

            using (StreamWriter write = File.CreateText(filePhoneNumbersPath))
            {
                foreach (var number in phoneBook.Keys)
                    write.WriteLine(number);
            }

            // 2

            Console.WriteLine("Enter contact name:");
            string name = Console.ReadLine();

            foreach (var phone in phoneBook)
            {
                if (phone.Value == name)
                {
                    Console.WriteLine($"His number is = {phone.Key}");
                    break;
                }
            }

            // 3
            string resultFileName = "New.txt";
            string resultFilePath = Path.Combine(desktopPath, resultFileName);

            if (!File.Exists(resultFilePath))
                File.Create(resultFilePath).Close();

            using (StreamWriter writer = File.CreateText(resultFilePath))
            {
                foreach (var phone in phoneBook)
                {
                    if (phone.Key.StartsWith("80"))
                        writer.WriteLine($"+380{phone.Key.Substring(2)}, {phone.Value}"); 
                }
            }
        }
    }
}