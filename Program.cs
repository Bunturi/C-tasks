////task 1.1

//using System.Diagnostics.CodeAnalysis;
//using System.Numerics;

//Console.WriteLine("sheiyvane pirveli gverdis sigrdze: ");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("sheiyvane meore gverdis sigrdze: ");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("sheiyvane mesame gverdis sigrdze: ");
//int num3 = int.Parse(Console.ReadLine());

//int parameter = num1 + num2 + num3;
//Console.WriteLine($"samkutxedis parametria {parameter}");

////task 1.2

//Console.WriteLine("1.2 sheiyvane pirveli gverdis sigrdze: ");
//int num4 = int.Parse(Console.ReadLine());
//Console.WriteLine("sheiyvane meore gverdis sigrdze: ");
//int num5 = int.Parse(Console.ReadLine());

//int para = num4 + num5;
//Console.WriteLine($"martkutxedis parametria {para}");

////task 1.3

//Console.WriteLine("1.3 sheiyvane pirveli gverdis sigrdze: ");
//int num6 = int.Parse(Console.ReadLine());
//Console.WriteLine("sheiyvane meore gverdis sigrdze: ");
//int num7 = int.Parse(Console.ReadLine());

//int area = num6 * num7;
//Console.WriteLine($"martkutxedis fatobia {area}");

//// task 1.4

//Console.WriteLine("1.4 first number: ");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("second number: ");
//int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("third number: ");
//int number3 = int.Parse(Console.ReadLine());

//int multy = number1 * number2 * number3;

//Console.WriteLine($"{number1} * {number2} * {number3} = {multy}");

// task 1.5

//Console.WriteLine("1.5 insert number: ");
//int number4 = int.Parse(Console.ReadLine());

//if (number4 > 0)
//{
//    Console.WriteLine(true);
//}
//else if (number4 < 0)
//{ Console.WriteLine(false); }
//else
//{ Console.WriteLine("it's zero^^"); }





////task 1.6

//Console.WriteLine("1.6 insert first number: ");
//int numb1 = int.Parse(Console.ReadLine());
//Console.WriteLine("insert second number: ");
//int numb2 = int.Parse(Console.ReadLine());

//if (numb1 != numb2)
//{ Console.WriteLine(numb1 + numb2); }
//else
//{ Console.WriteLine((numb1 + numb2) * 3); }


////task 1.7

//Console.WriteLine("1.7 insert first number: ");
//int numb3 = int.Parse(Console.ReadLine());
//Console.WriteLine("insert second number: ");
//int numb4 = int.Parse(Console.ReadLine());

//if (numb3 == 30 || numb4 == 30 || (numb3 + numb4 == 30))
//{ Console.WriteLine(true); }
//else
//{ Console.WriteLine(false); }



////task 1.8

//Console.WriteLine("1.8 insert age: ");
//int age = int.Parse(Console.ReadLine());


//if (age < 13)
//{ Console.WriteLine("Child"); }
//else if (age > 19)
//{ Console.WriteLine("Adult"); }
//else
//{ Console.WriteLine("Teenager"); }





////task 1.9

//Console.WriteLine("1.9 insert number : ");
//int yourNumber = int.Parse(Console.ReadLine());


//if (yourNumber % 3 == 0)
//{ Console.WriteLine(true); }
//else
//{ Console.WriteLine(false); }


////task 1.10

//Console.WriteLine("1.10 insert number : ");
//int yourNumber1 = int.Parse(Console.ReadLine());


//if (yourNumber1 % 3 == 0 || yourNumber1 % 7 == 0)
//{ Console.WriteLine(true); }
//else
//{ Console.WriteLine(false); }



//task 1.11

using System.ComponentModel.Design;

Console.WriteLine("1.11 first number: ");
int maxNum1 = int.Parse(Console.ReadLine());
Console.WriteLine("second number: ");
int maxNum2 = int.Parse(Console.ReadLine());
Console.WriteLine("third number: ");
int maxNum3 = int.Parse(Console.ReadLine());

//if (maxNum1 >= maxNum2)
//{
//    if (maxNum1 >= maxNum3)
//    { Console.WriteLine(maxNum1); }
//    else { Console.WriteLine(maxNum3); }
//}
//else
//{
//    if (maxNum2 >= maxNum3)
//    { Console.WriteLine(maxNum2); }
//    else { Console.WriteLine(maxNum3); }
//}


int max = maxNum1;

if (max <=maxNum2)
{ 
    max = maxNum2; 
}

if (max <= maxNum3) 
{
    max = maxNum3; 
}
  



Console.WriteLine(max);
