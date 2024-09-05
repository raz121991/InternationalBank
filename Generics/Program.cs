// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 static void Swap<T>(ref T a, ref T b)
{
    T temp = a;  
    a = b;      
    b = temp;    
}



int x = 5;
int y = 10;
Console.WriteLine($"Before swap: x = {x}, y = {y}");
Swap(ref x, ref y);  
Console.WriteLine($"After swap: x = {x}, y = {y}");
