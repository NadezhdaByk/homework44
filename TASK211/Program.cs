//принимает на вход координаты 2х точек и находит расстояние между ними в 3D пространстве
Console. WriteLine("Введите координаты двух точек в 3хмерном пространстве (x1,y1,z1,x2,y2,z2)");
string num = Console.ReadLine();
//string number = num.ToString();

string Distance()
{
//int [] array = new int [number.Length];
// for ( int i=0; i < number.Length; i++)
    //{
      //array [i] = int.Parse(number[i].ToString());
    //}

char [] array =   num.ToCharArray();
double dist = Math.Sqrt(Math.Pow(array[3]-array[0],2)+ Math.Pow(array[4]-array[1],2)+
Math.Pow(array[5]-array[3],2));
return $"Расстояние между вашими точками в пространстве равно {dist}";
}
Console.WriteLine(Distance());
