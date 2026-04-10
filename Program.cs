using System.Text;

// Задание 1: Конкатенация двух строк
static string ConcatenateStrings(string str1, string str2)
{
    return str1 + "" + str2;
}

// Задание 2: Приветствие пользователя с именем и возрастом
static string GreetUser(string name, int age)
{
    return $"Hello, {name}!\n You are {age} years old.";
}

// Задание 3: Анализ строки (количество символов, верхний и нижний регистр)
static string AnalyzeString(string input)
{
    int length = input.Length;
    string upperCase = input.ToUpper();
    string lowerCase = input.ToLower();

    return $"Количество символов: {length}\n" +
           $"В верхнем регистре: {upperCase}\n" +
           $"В нижнем регистре: {lowerCase}\n";
}

// Задание 4: Получение первых 5 символов строки
static string GetFirstFiveChars(string input)
{

    return input.Substring(0, 5);
}

// Задание 5: Объединение массива строк в одно предложение через пробел
static StringBuilder JoinStringsToSentence(string[] words)
{
    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < words.Length; i++)
    {
        sb.Append(words[i]);
        if (i < words.Length - 1)
        {
            sb = sb.Append(" ");
        }
    }
    return sb;
}

// Задание 6: Замена одного слова на другое
static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
{
    return inputString.Replace(wordToReplace, replacementWord);
}

//Проверки

string result1 = ConcatenateStrings("Hello", "World!");
Console.WriteLine($"Результат 1 задачи: {result1}");

string result2 = GreetUser("Вова", 34);
Console.WriteLine($"Результат 2 задачи: {result2}");

string result3 = AnalyzeString("Hello World");
Console.WriteLine($"Результат 3 задачи: {result3}");

string result4 = GetFirstFiveChars("Hello World");
Console.WriteLine($"Результат 4 задачи: {result4}");

string[] words = { "Как", "же", "мне", "нравится", "делать", "дз" };
StringBuilder result5 = JoinStringsToSentence(words);
Console.WriteLine($"Результат 5 задачи: {result5}");

string result6 = ReplaceWords("В свободное время я люблю спать", "спать", "учиться");
Console.WriteLine($"Результат 6 задачи: {result6}");
// Почемуто не работает =)  Assert.AreEqual("В свободное время я люблю учиться",result6);

