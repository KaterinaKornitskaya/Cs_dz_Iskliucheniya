namespace task2_variant1;

// Пользователь вводит словами цифру от 0 до 9.
// Приложение должно перевести слово в цифру.
// Например, если пользователь ввёл five, приложение должно
// вывести на экран 5.
internal class Task2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter by words a number (zero ... nine)");
        string user = Console.ReadLine();  // считываем ввод пользователя
        MyFunc(user);  // вызов метода
    }

    static void MyFunc(string user)  // метод Перевод слова в цифру
    {
        // строка с цифрами в виде слов
        string s = "zero one two three four five six seven eight nine";
        // создаем массив отдельных слов путем разбиения строки
        string[] str = s.Split(' ');
        int res = -1;  // переменная для результата

        for (int i = 0; i < str.Length; i++)  // цикл по массиву строк
        {
            if (str[i] == user)  // если элемент масссива равен вводу пользователя
            {
                res = i;  // результат равен индексу элемента массива
            }
        }
        Console.WriteLine($"Result: {res}");

        if (res == -1)  // если результат равен -1 (начальное значение)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}