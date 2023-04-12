namespace task2_variant2;

internal class Task2_variant2
{
    static void Main(string[] args)
    {
        MyFunc();
    }

    static void MyFunc()
    {
        Dictionary<string, int> numbers = new Dictionary<string, int>();  // создание словаря
        // строка с цифрами в виде слов
        string s = "zero one two three four five six seven eight nine";
        // создаем массив отдельных слов путем разбиения строки
        string[] str = s.Split(' ');
        for (int i = 0; i < str.Length; i++)  // цикл по массиву строк
        {
            numbers[str[i]] = i;  // пара слово-цифра для словаря
        }

        //foreach (KeyValuePair<string, int> keyValue in numbers)  // вывод словаря в консоль
        //{
        //    Console.WriteLine(keyValue.Key + " = " + keyValue.Value);
        //}

        try  // блок для генерации исключения
        {
            Console.WriteLine("Введите словами цифру от 0 до 9");
            string num = Console.ReadLine();  // ввод слова
            Console.WriteLine(numbers[num]);  // вывод соответствующей цифры-пары из словаря
        }
        catch (Exception ex)  // обработка исключения
        {
            Console.WriteLine(ex.Message);
        }
    }
}
