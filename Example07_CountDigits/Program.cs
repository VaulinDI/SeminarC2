Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
double x = 2;
int d = 10;
int count = 0;
while (x > 1) {
    x = num / d;
    d = d * 10;
    count++;
}
Console.WriteLine("Количество цифр в числе: " + count);
