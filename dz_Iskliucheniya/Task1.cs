namespace dz_Iskliucheniya;

// Создайте приложение калькулятор для перевода числа из одной системы
// исчисления в другую. Пользователь с помощью меню выбирает направление
// перевода. Например из десятичной в двоичную. После выбора направления,
// пользователь вводит число в исходной системе исчисления.
// Приложение должно перевести число в требуемую систему.
// Предусмотреть случай выхода за границы диапазона,
// определяемого типом int, неправильный ввод.
internal class Task1
{
    static void ToBinary()  // метод перевода числа из десятеричного в бинарное
    {
        Console.WriteLine("\nEnter positive decimal number: ");
        try                                                 // блок, где генерируется исключение
        {
            uint num_dec = UInt32.Parse(Console.ReadLine());
            string num_bin = Convert.ToString(num_dec, 2);  // стандартная ф-ия пеервода числа в бинарную систему
            Console.WriteLine($"Result: {num_bin}");
            Console.WriteLine("To continue - press any key");
            Console.ReadKey();
        }
        catch (OverflowException ex)                         // обработка исключения (выход за перделы uint)
        {
            Console.ForegroundColor = ConsoleColor.Red;     // красный шрифт в консоли для исключения
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;   // возврат к белому шрифту
            Console.WriteLine("To continue - press any key");
            Console.ReadKey();
        }
        catch (Exception ex)                                 // обработка исключения (другие, в т.ч. неверный формат ввода)
        {
            Console.ForegroundColor = ConsoleColor.Red;     // красный шрифт в консоли для исключения
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;   // возврат к белому шрифтуConsole.WriteLine(ex.Message);
            Console.WriteLine("To continue - press any key");
            Console.ReadKey();
        }
    }

    static void ToDecimal()  // метод перевода числа из бинарного в десятеричное
    {
        Console.WriteLine("\nEnter binary number: ");
        try                                                // блок, где генерируется исключение
        {
            string num = Console.ReadLine();
            num = Convert.ToInt32(num, 2).ToString();      // стандартная ф-ия перевода из бинарной в 10ричную систему
            Console.WriteLine($"Result: {num}");
            Console.WriteLine("To continue - press any key");
            Console.ReadKey();
        }
        catch (OverflowException ex)                       // обработка исключения (выход за пределы uint)
        {
            Console.ForegroundColor = ConsoleColor.Red;    // красный шрифт в консоли для исключения
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;  // возврат к белому шрифту
            Console.WriteLine("To continue - press any key");
            Console.ReadKey();
        }
        catch (Exception ex)                               // обработка исключения (другие, в т.ч. неверный формат ввода)
        {
            Console.ForegroundColor = ConsoleColor.Red;    // красный шрифт в консоли для исключения
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;  // возврат к белому шрифту
            Console.WriteLine("To continue - press any key");
            Console.ReadKey();
        }
    }
    static void Main(string[] args)
    {

        bool contin = true;  // булевая переменная для продолжения
        while (contin)       // продолжать, пока true
        {
            Console.Clear();
            Console.WriteLine("***Decimal<->Binary Convertor***\n");
            Console.WriteLine("Convert from decimal to binary - press 1");
            Console.WriteLine("Convert from binary to decimal - press 2");
            Console.WriteLine("To exit - press Escape");

            ConsoleKeyInfo choice;       // для выбора пользователя
            choice = Console.ReadKey();  // считываем нажатую клавишу
            switch (choice.Key)          // в зависимости от нажатой клавиши
            {
                case ConsoleKey.D1:      // если нажата клавиша 1
                    ToBinary();          // вызываем метод ToBinary()
                    break;
                case ConsoleKey.D2:      // если нажата клавиша 2
                    ToDecimal();         // вызываем метод ToDecimal()
                    break;
                case ConsoleKey.Escape:  // есди нажата клавиша Escape
                default:                 // если нажата любая другая, кроме 1,2,Escape
                    contin = false;        // прерываем цикл
                    break;
            }
        }
    }
}
