//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*double GetDistanse(double x1,double y1,double z1,double x2,double y2,double z2)
{
   
    double xLine = x2-x1;
    double yLine = y2-y1;
    double zLine = z2-z1;

    double distQuad = xLine*xLine + yLine*yLine + zLine*zLine ;
    double result = Math.Sqrt(distQuad);
    
    return result;
   Console.Write(result);
}
Console.Write("Imput x1: ");
int x1=Convert.ToInt32(Console.ReadLine());
Console.Write("Imput y1: ");
int y1=Convert.ToInt32(Console.ReadLine());
Console.Write("Imput z1: ");
int z1=Convert.ToInt32(Console.ReadLine());
Console.Write("Imput x2: ");
int x2=Convert.ToInt32(Console.ReadLine());
Console.Write("Imput y2: ");
int y2=Convert.ToInt32(Console.ReadLine());
Console.Write("Imput z2: ");
int z2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Answer is " + GetDistanse(x1,y1,z1,x2,y2,z2));*/


//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
  else Console.WriteLine($"Ваше число: {number} - не палиндром.");
}

if (number.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine("Введи правильное число");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


/*Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);*/
