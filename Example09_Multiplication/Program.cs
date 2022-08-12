Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int mul = 1;
while (i <= n) {
    mul = mul * i;
    i++;
}
Console.WriteLine("Произведение чисел от 1 до n равно: " + mul);
