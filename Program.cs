// // int age = 15;
// // if (age >= 21)
// // {
// //     Console.WriteLine("Доступ разрешен");
// // } else
// // {
// //     Console.WriteLine("Доступ запрещен");
// //     Console.WriteLine($"До совершеннолетия: {18 - age} года/лет");  
// // }
// // Console.WriteLine("Программа продолжает работу");

// int age = 11;
// if (age < 13)
// {
//     Console.WriteLine("Ребенок");
// }
// else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }
// else if (age < 60)
// {
//     Console.WriteLine("Взрослый");
// }
// else
// {
//     Console.WriteLine("Пенсионер");
// }

// int age = 22;
// double height = 2.05;
// bool withParents = false;
// if ((age > 14 && height > 1.5) || (height < 1.5 && withParents == true))
// {
//     Console.WriteLine("Можно кататься");
// }
// else
// {
//     Console.WriteLine("Пока нельзя");
// }

//Задание Б
// Console.WriteLine();
// Console.Write("Введите оценку(числом): ");

// bool trueOrFalse = int.TryParse(Console.ReadLine(), out int point);
// string convertedPoint = "";

// if (trueOrFalse == true)
// {
//     switch (point)
//     {
//         case 5:
//             convertedPoint = "Отлично";
//             break;
//         case 4:
//             convertedPoint = "Хорошо";
//             break;
//         case 3:
//             convertedPoint = "Удовлетворительно";
//             break;
//         case 2:
//             convertedPoint = "Неудовлетворительно";
//             break;
//     }
// }
// else
// {
//     convertedPoint = "Неверная оценка";
// }

// Console.WriteLine($"Ваша оценка: {convertedPoint}");

// Задача В
// Console.WriteLine();
// Console.WriteLine("Введите 3 любых числа: ");

// int numOne = int.Parse(Console.ReadLine());
// int numTwo = int.Parse(Console.ReadLine());
// int numThree = int.Parse(Console.ReadLine());

// if ((numOne <= numTwo) && (numTwo <= numThree) || (numTwo <= numOne) && (numOne <= numThree))
// {
//     Console.WriteLine($"Наибольшее число: {numThree}");
// }
// else if ((numOne <= numThree) && (numThree <= numTwo) || (numThree <= numOne) && (numOne <= numTwo))
// {
//     Console.WriteLine($"Наибольшее число: {numTwo}");
// }
// else
// {
//     Console.WriteLine($"Наибольшее число: {numOne}");
// }

//Вариант 3
// Console.WriteLine();
// Console.Write("Введите номер месяца: ");
// int span = int.Parse(Console.ReadLine());

// string summer = "Лето";
// string winter = "Зима";
// string autumn = "Осень";
// string spring = "Весна";

// switch (span)
// {
//     case 12:
//         Console.WriteLine($"Сезон: {winter}");
//         break;
//     case 1:
//         Console.WriteLine($"Сезон: {winter}");
//         break;
//     case 2:
//         Console.WriteLine($"Сезон: {winter}");
//         break;
//     case 3:
//         Console.WriteLine($"Сезон: {spring}");
//         break;
//     case 4:
//         Console.WriteLine($"Сезон: {spring}");
//         break;
//     case 5:
//         Console.WriteLine($"Сезон: {spring}");
//         break;
//     case 6:
//         Console.WriteLine($"Сезон: {summer}");
//         break;
//     case 7:
//         Console.WriteLine($"Сезон: {summer}");
//         break;
//     case 8:
//         Console.WriteLine($"Сезон: {summer}");
//         break;
//     case 9:
//         Console.WriteLine($"Сезон: {autumn}");
//         break;
//     case 10:
//         Console.WriteLine($"Сезон: {autumn}");
//         break;
//     case 11:
//         Console.WriteLine($"Сезон: {autumn}");
//         break;
//     default:
//         Console.WriteLine("Неверный месяц");
//         break;
// }

//Вариант 9
// Console.WriteLine();
// Console.Write("Введите год (целым числом): ");
// int year = int.Parse(Console.ReadLine());

// if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
// {
//     Console.WriteLine($"{year} год високосный, в феврале 29 дней");
// } else
// {
//     Console.WriteLine($"{year} год не високосный, в феврале 28 дней");
// }