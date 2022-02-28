//Задача 1
// Напишите программу, которая на входе принимает два числа и выдает, какое число больше, а какое меньше.

// ПЕРВЫЙ ВАРИАНТ

//Console.WriteLine("Введите первое число => ");
//String inputA = Console.ReadLine();
//int A = int.Parse(inputA);

//Console.WriteLine("Введите второе число => ");
//String inputB = Console.ReadLine();
//int B = int.Parse(inputB);

  //  if (A > B) Console.Write($"больше {A} меньше {B}");

  //  if (B > A) Console.Write($"больше {B} меньше {A}");



// ВТОРОЙ ВАРИАНТ


Console.WriteLine("Введите первое число => ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число => ");
int B = Convert.ToInt32(Console.ReadLine());


    if (A > B) Console.Write($"больше {A} меньше {B}");

    if (B > A) Console.Write($"больше {B} меньше {A}");




