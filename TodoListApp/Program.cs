using System;

// Шаг 7: Вывод информации об исполнителях работы
Console.WriteLine("Работу выполнили: Мироненко Даня и напарник");
Console.WriteLine("--------------------------------------------");

// Шаг 8: Запрос данных у пользователя
Console.Write("Введите имя: ");
string firstName = Console.ReadLine();

Console.Write("Введите фамилию: ");
string lastName = Console.ReadLine();

Console.Write("Введите год рождения: ");
string birthYearInput = Console.ReadLine();

// Перевод года рождения в целое число и расчет возраста
int birthYear = int.Parse(birthYearInput);
int currentYear = DateTime.Now.Year; // Автоматически подставит текущий 2026 год
int age = currentYear - birthYear;

// Вывод сообщения строго по шаблону из задания
Console.WriteLine($"\nДобавлен пользователь {firstName} {lastName}, возраст - {age}");

