//принимает на вход пятизначное число и проверяет, является ли оно полиндромом
Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

string Polindrom()
{
//int [] array = new int [num.Length];
// for
//  ( int i=0; i < num.Length; i++)
//     {
//       array [i] = int.Parse(num[i].ToString());
//     }
char [] array = num.ToCharArray();
if (array[0] == array[4] & array[1] == array[3])
{

return "Полиндром";
}
else {
return "Не полиндром";
}
}
Console.WriteLine(Polindrom());
