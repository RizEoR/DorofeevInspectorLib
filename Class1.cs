using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private static string carInspectionName = "Автоинспекция г. Чита";
        private static string mainInspector = "Васильев Василий Иванович";
        private static string[] workers = { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
        private static Random random = new Random();

        // Метод возвращает ФИО главного инспектора
        public string GetInspector()
        {
            return mainInspector;
        }

        // Метод возвращает название автоинспекции
        public string GetCarInspection()
        {
            return carInspectionName;
        }

        // Метод изменяет ФИО главного инспектора, если указанное ФИО есть в списке сотрудников
        public bool SetInspector()
        {
            Console.WriteLine("Выберите нового главного инспектора из списка сотрудников:");
            for (int i = 0; i < workers.Length; i++) //Цикл для отображения списка сотрудников
            {
                Console.WriteLine($"{i + 1}. {workers[i]}");
            }
            int selection;
            // Если преобразование успешно и число находится в пределах от 1 до длины массива,условие выполняется.
            // out selection:  Если преобразование успешно, преобразованное число записывается в переменную selection.
            if (int.TryParse(Console.ReadLine(), out selection) && selection > 0 && selection <= workers.Length)
            {
                mainInspector = workers[selection - 1];
                Console.WriteLine($"Главный инспектор изменён на: {mainInspector}");
                return true;
            }
            else
            {
                // не число или число вне допустимого диапазона
                Console.WriteLine("Неверный выбор.");
                return false;
            }
        }

        // Метод формирует и возвращает госномер в формате SYMBOLnumber_CODE
        public string GenerateNumber()
        {
            
                char symbol = (char)random.Next('A', 'Z' + 1); 
            int number = random.Next(1000, 10000); // случайное число от 1000 до 9999
                int code = 75; // фиксированный код региона
                return $"{symbol}{number}_{code}";
            }

        // Метод возвращает список сотрудников
        public string[] GetWorker()
        {
            return workers;
        }

        // Метод добавляет нового сотрудника в список сотрудников
        public void AddWorker(string fullname)
        {                           //новый размер массива
            Array.Resize(ref workers, workers.Length + 1); // увеличения размера массива;  ref указывает на то, что передаётся ссылка на массив workers
            workers[workers.Length - 1] = fullname; // обращение к последнему элементу
        }
    }
}
