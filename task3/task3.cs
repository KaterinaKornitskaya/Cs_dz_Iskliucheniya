namespace task3;

// Создайте класс «Заграничный паспорт». Вам необходимо
// хранить информацию о номере паспорта, ФИО владельца,
// дате выдачи и т.д.Предусмотреть механизмы для инициа
// лизации полей класса.Если значение для инициализации
// неверное, генерируйте исключение.
internal class Task3
{
    static void Main(string[] args)
    {
        Passport obj = new Passport();
        obj.SetNum();
        obj.SetFirstName();
        obj.SetSecondName();
        obj.SetDate();
        obj.Show();
    }
    struct Date  // структура Дата
    {
        int day;
        int month;
        int year;

        public void SetDate()  // сеттер для даты
        {
            try
            {
                Console.WriteLine("Введите день: ");
                int s = Convert.ToInt32(Console.ReadLine());  // ввод с консоли значения Месяц
                if (s<1 || s>31)  // если день меньше 1 или больше 31
                {
                    throw new Exception("Номер дня доступен от 1 до 31");
                }
                day = s;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
            }

            try
            {
                Console.WriteLine("Введите месяц: ");
                int s = Convert.ToInt32(Console.ReadLine());  // ввод с консоли значения Месяц
                if (s<1 || s>12)  // если месяц меньше 1 или больше 12
                {
                    throw new Exception("Номер месяца доступен от 1 до 12");
                }
                month = s;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
            }

            try
            {
                Console.WriteLine("Введите год: ");
                string s = Console.ReadLine();  // ввод с консоли значения Номер

                if (s.Length!=4)  // если год НЕ содержит 4 цифры:
                {
                    throw new Exception("Год должен содержать 4 цифры");
                }
                year = Convert.ToInt32(s);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
            }
        }
        public void ShowDate()
        {
            Console.WriteLine($"Date:\t\t {day}/{month}/{year}");
        }
    }
    internal class Passport  // класс Паспорт
    {
        private uint number;         // номер
        private string first_name;   // имя
        private string second_name;  // фамилия
        Date date;                   // дата
        public Passport() { }

        public void SetNum()  // метод Сеттер для номера
        {
            try
            {
                Console.WriteLine("Введите номер паспорта: ");
                string s = Console.ReadLine();  // ввод с консоли значения Номер

                if (s.Length!=4)  // если номер НЕ содержит 4 цифры:
                {
                    throw new Exception("Номер должен содержать 4 цифры");
                }
                number = Convert.ToUInt32(s);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
            }
        }

        public void SetFirstName()  // метод Сеттер для имени
        {
            try
            {
                Console.WriteLine("Введите Ваше имя: ");
                string s = Console.ReadLine();

                for (int i = 0; i < s.Length; i++)   // цикл по строке
                {
                    if (s[i]<65 || s[i]>122 ||  // проверка, что строка содержит
                        s[i]>90 && s[i]<97)     // только буквы A...Z, a...z                           
                    {
                        throw new Exception("Имя должно содержать только латинские буквы.");
                    }
                    else if (s.Length <= 1)  // проверка, если кол-во символов < 2                   
                        throw new Exception("Имя должно содержать не менее двух букв.");
                }
                first_name = s;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
            }
        }

        public void SetSecondName()  // метод Сеттер для фамилии
        {
            try
            {
                Console.WriteLine("Введите Ваше имя: ");
                string s = Console.ReadLine();

                for (int i = 0; i < s.Length; i++)   // цикл по строке
                {
                    if (s[i]<65 || s[i]>122 ||  // проверка, что строка содержит
                        s[i]>90 && s[i]<97)     // только буквы A...Z, a...z                           
                    {
                        throw new Exception("Имя должно содержать только латинские буквы.");
                    }
                    else if (s.Length <= 1)  // проверка, если кол-во символов < 2                   
                        throw new Exception("Имя должно содержать не менее двух букв.");
                }
                second_name = s;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor= ConsoleColor.White;
            }
        }

        public void SetDate()   // сеттер для даты
        {
            date.SetDate();
        }

        public void Show()  // вывод в консоль 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("**********Passport**********");
            Console.WriteLine($"Number:\t\t {number}");
            Console.WriteLine($"First Name:\t {first_name}");
            Console.WriteLine($"Second Name:\t {second_name}");
            date.ShowDate();
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}