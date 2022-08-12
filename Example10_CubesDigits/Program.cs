Console.WriteLine("Введите количество чисел n, для которых будут считаться кубы от 1 до n : ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
int cube = 1;
while (i <= n) {
    cube = i * i * i;
    if (cube % 2 == 0) {
        Console.WriteLine("Тот самый куб: " + cube);
    }
    i++;
}