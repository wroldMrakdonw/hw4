// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int pow(int a, int b){
    int result = 1;
    for (int i = 0; i < b; i++){
        result *= a;
    }
    return result;
} 
System.Console.Write("Введи число a: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введи число b: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{x} в степени {y} = {pow(x, y)}");