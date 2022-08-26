//dotnet run - Для старта
//dotnet new console - сщздать новый проект
//Console.WriteLine("текст"); - Для ввода текста в ковычках
//Console.Write("текст"); - Для ввода текста в одну строку
//string для текста string username = Console.ReadLine(); то что ввели
//int.Parse(Console.ReadLine()); Для ввода в терминале
//git config user.email "t12345556@gmail.com"
//git config user.name "Anatoly
Console.WriteLine("первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("второе");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("третье");
int c = int.Parse(Console.ReadLine());
int max = c;
if (a > max) max = a;
if (b > max) max = b;
Console.WriteLine($"максимальное {max}");