Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;
int sum = 0;
while (i <= a) {
    sum = sum + i;
    i++;
}
Console.WriteLine(sum);
