//принимает на вход пятизначное число и проверяет, является ли оно полиндромом
Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();

string Polindrom()
{
//int [] array = new int [num.Length];
char [] array = num.ToCharArray();
// for (int i=0; i < num.Length; i++)
//     {
//       array [i] = int.Parse(num[i].ToString());
//     }

if (array[0] == array[4] & array[1] == array[3])
{

return "Полиндром";
}
else {
return "Не полиндром";
}
}
Console.WriteLine(Polindrom());

//принимает на вход число и проверяет, является ли оно полиндромом
// Console. WriteLine("Введите число");
// string number = Console.ReadLine();

// string Polindrom (string num)
// {
// int [] array = new int [num.Length];
// int num1 = int.Parse(num);

// char[] array1 = num.ToCharArray();
// char[] array2 = array1;
// int length = array1.Length;
// for (int i=0; i<=length; i++)
// {
// array2[i] = array1[length-i];
// }
// if (array1 == array2)
// {
// return "Полиндром";

// }
// else {
// return"Не полиндром";
// }
// }
// Console. WriteLine(Polindrom(number));