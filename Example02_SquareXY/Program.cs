Console.WriteLine("Введите число x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y");
int y = Convert.ToInt32(Console.ReadLine());
if (x == y * y) {
    Console.WriteLine("Число x является квадратом числа y");
}
else if (y == x * x) {
    Console.WriteLine("Число y является квадратом числа x");
}
else {
    Console.WriteLine("Ни число x не является квадратом числа y, ни число y не является квадратом числа x");
}
