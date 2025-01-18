using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ContactAppLogic;
using System.Xml;

namespace ContactAppLogic
{
    public class ManagerProject
    {
        // Константа с путем к файлу
        private const string FilePath = @"C:\Users\sboyarskiy\source\repos\ContactsApp\ContactsAppUI\My Documents\ContactsApp.notes";

        // Метод для сохранения объекта Project в файл
        public static void SaveProject(Project project)
        {
            if (project == null)
            {
                throw new ArgumentNullException(nameof(project), "Project cannot be null.");
            }

            try
            {
                // Сериализация объекта в JSON строку
                string json = JsonConvert.SerializeObject(project, Formatting.Indented);

                // Запись JSON строки в файл
                File.WriteAllText(FilePath, json);
                Console.WriteLine("Project successfully saved.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving project: {ex.Message}");
            }
        }

        // Метод для загрузки объекта Project из файла
        public static Project LoadProject()
        {
            try
            {
                // Проверяем, существует ли файл
                if (!File.Exists(FilePath))
                {
                    Console.WriteLine("Project file does not exist.");
                    return null;
                }

                // Чтение содержимого файла
                string json = File.ReadAllText(FilePath);

                // Десериализация JSON строки в объект Project
                Project project = JsonConvert.DeserializeObject<Project>(json);

                Console.WriteLine("Project successfully loaded.");
                return project;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading project: {ex.Message}");
                return null;
            }
        }
    }
}