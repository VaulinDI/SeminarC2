Console.WriteLine("Задайте номер четверти: ");
int quarter = Convert.ToInt16(Console.ReadLine());
if (quarter == 1) {
    Console.WriteLine("Диапазон возможных координат:");
    Console.WriteLine("По оси X: (0, +2147483647]");
    Console.WriteLine("По оси Y: (0, +2147483647]");
}
else if (quarter == 2) {
    Console.WriteLine("Диапазон возможных координат:");
    Console.WriteLine("По оси X: [-2147483648, 0)");
    Console.WriteLine("По оси Y: (0, +2147483647]");
}
if (quarter == 3) {
    Console.WriteLine("Диапазон возможных координат:");
    Console.WriteLine("По оси X: [-2147483648, 0)");
    Console.WriteLine("По оси Y: [-2147483648, 0)");
}
if (quarter == 4) {
    Console.WriteLine("Диапазон возможных координат:");
    Console.WriteLine("По оси X: (0, +2147483647]");
    Console.WriteLine("По оси Y: [-2147483648, 0)");
}