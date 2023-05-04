using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;



using System;
using System.IO;
using Internal;

namespace FileReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Чтение файла
            string path = @"C:\file.txt";
            string content;

            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
                {
                    content = reader.ReadToEnd();
                }
                Console.WriteLine("Содержимое файла:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }

            // Запись в файл
            string newContent = "Новое содержимое файла.";
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                writer.Write(newContent);
            }
            Console.WriteLine("Содержимое файла успешно изменено.");

            Console.ReadKey();
        }
    }
}
