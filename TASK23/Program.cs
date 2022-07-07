//принимает на вход число N и выдает таблицу кубов чисел от 1 до N
Console. WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());
string Cube()
{
for (int i=1; i<=number; i++)
{
int cub = i*i*i;
Console.WriteLine($"{i}*{i}*{i}={cub}");
}
return "  ";
}
Console.WriteLine(Cube());
