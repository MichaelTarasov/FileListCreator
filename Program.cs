using System;
using System.IO;

class Program
{
    static void Main()
    {
        string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string rootFolder = Path.GetDirectoryName(currentDirectory);

        string[] jpgFiles = Directory.GetFiles(rootFolder, "*.jpg", SearchOption.TopDirectoryOnly);

        string outputFile = Path.Combine(rootFolder, "Снято.txt");

        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            int i = 1;
            foreach (string jpgFile in jpgFiles)
            {
                string fileName = Path.GetFileName(jpgFile);
                fileName = i + ". " + fileName.Substring(0, fileName.Length - 4);
                writer.WriteLine(fileName);
                i++;
            }
        }

        Console.WriteLine("Список файлов с расширением .jpg сохранен в файле Снято.txt.");
    }
}

