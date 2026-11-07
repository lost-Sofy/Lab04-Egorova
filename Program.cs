// int age = 15;
// if (age >= 21)
// {
//     Console.WriteLine("Доступ разрешен");
// } else
// {
//     Console.WriteLine("Доступ запрещен");
//     Console.WriteLine($"До совершеннолетия: {18 - age} года/лет");  
// }
// Console.WriteLine("Программа продолжает работу");

int age = 11;
if (age < 13)
{
    Console.WriteLine("Ребенок");
}
else if (age < 18)
{
    Console.WriteLine("Подросток");
}
else if (age < 60)
{
    Console.WriteLine("Взрослый");
}
else
{
    Console.WriteLine("Пенсионер");
}

int age = 22;
double height = 2.05;
bool withParents = false;
if ((age > 14 && height > 1.5) || (height < 1.5 && withParents == true))
{
    Console.WriteLine("Можно кататься");
}
else
{
    Console.WriteLine("Пока нельзя");
}
