using ConsoleMatrix;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт друзі");

MyMatrix a = new MyMatrix();
a.InitRandom();

//Console.WriteLine("a[0,0] = " + a[0,0]);
Console.WriteLine("---Наша матриця A---");
Console.WriteLine(a.ToString());

MyMatrix b = new MyMatrix();
b.InitRandom();
Console.WriteLine("---Наша матриця B---");
Console.WriteLine(b.ToString());

//MyMatrix c = a.Add(b);
//Console.WriteLine("---Сума матриць A + B---");
//Console.WriteLine(c.ToString());

//MyMatrix c = a + b;
//b.InitRandom();
//Console.WriteLine("---Наша матриця B---");
//Console.WriteLine(c.ToString());

MyMatrix g = a * b;
b.InitRandom();
Console.WriteLine("---Наша матриця B---");
Console.WriteLine(g.ToString());
//MyMatrix minus = a.Minus(b);
//Console.WriteLine("---Сума матриць A - B---");
//Console.WriteLine(minus.ToString());