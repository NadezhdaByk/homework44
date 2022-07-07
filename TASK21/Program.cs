//принимает на вход координаты 2х точек и находит расстояние между ними в 3D
// пространстве
// Console. WriteLine("Введите координаты двух точек в 3хмерном пространстве (x1,y1,z1,x2,y2,z2)");
// int num = Console.Read();
// string number = num.ToString();

// string Distance()
// {
// int [] array = new int [number.Length];
// for ( int i=0; i < number.Length; i++)
//     {
//       array [i] = int.Parse(number[i].ToString());
//     }
// double dist = Math.Sqrt(Math.Pow(array[3]-array[0],2)+ Math.Pow(array[4]-array[1],2)+
// Math.Pow(array[5]-array[3],2));
// return $"Расстояние между вашими точками в пространстве равно {dist}";
// }
// Console.WriteLine(Distance());
Console.WriteLine("Введите координату Х первой точки");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х второй точки");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки");
int Z2 = Convert.ToInt32(Console.ReadLine());
string Distance()
{
double dist = Math.Sqrt(Math.Pow(X2-X1,2)+ Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
return $"Расстояние между вашими точками в пространстве равно {dist}";
}
Console.WriteLine(Distance());