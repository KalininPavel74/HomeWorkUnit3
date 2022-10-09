// Калинин Павел 09.10.2022 
// Знакомство с языками программирования (семинары)
// Урок 3. Массивы и функции в программировании
// Домашняя работа

int intN = 0, intN1 = 0, intN2 = 0; 
int len = 0;
int intSum = 0; 
double doubleN = 0, doubleN1 = 0, doubleN2 = 0, doubleN3 = 0;
bool isRepeat = true; 
string s = "";
string taskName = "";

//if(false) { // выборочно отключить для отладки

long cube(int aN) { return aN*aN*aN; }

taskName = "Задание  №1. Найти кубы чисел от 1 до N.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите целое число: ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    for(int i=1; i<=intN1; i++)
        Console.WriteLine("Кубом числа "+i+" является "+cube(i));
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №2. Подсчитать сумму цифр в числе.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите действующее число: ");
    s = Console.ReadLine() ?? "0";
    Console.WriteLine("Ответ:");
    len = s.Length;
    intSum = 0;
    for(int i=0; i<len; i++) {
        if(s[i] >= '1' && s[i]<='9')
            intSum += int.Parse(s[i].ToString());
    }
    Console.WriteLine("В числе "+s+" сумма цифр равна "+intSum);
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №3. Написать программу вычисления произведения чисел от 1 до N.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите натуральное число меньшее или равное 20: ");
    //Console.WriteLine(Int64.MaxValue); // //9 223 372 036 854 775 807
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    if(intN1>=1) {
        long longN = 1;
        for(int i=2; i<=intN1; i++)
            longN *= i;
        Console.WriteLine("Факториалом числа "+intN1+" является "+longN);
    } else Console.WriteLine(intN1+" не является натуральным числом.");
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    


taskName = "Задание  №4. Показать кубы чисел, заканчивающихся на четную цифру.";
isRepeat = true;
while(isRepeat) {
    Console.WriteLine("------------------------------------------------\n\r"+taskName);
    Console.Write("Введите натуральное число : ");
    intN1 = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine("Ответ:");
    for(int i=1; i<=intN1; i++) 
        if(i%2==0)
            Console.WriteLine("Кубом числа "+i+" является "+cube(i));
    Console.Write("----\n\rВыполнить задание еще раз? (0-нет, 1-да):");
    s = Console.ReadLine() ?? "0";
    isRepeat = s != "0";
}    




