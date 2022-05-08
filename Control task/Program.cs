// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arrayfirst = new string[10] {"546", "3", "hello", "Russia", "abc", "world", "Kazan", "2+", ":-)", "125"};
string[] arraysecond = new string[arrayfirst.Length];
void SecondArrayWithIF(string[] arrayfirst, string[] arraysecond)
{
    int count = 0;
    for (int i = 0; i < arrayfirst.Length; i++)
    {
   if(arrayfirst[i].Length <= 3)
        {
        arraysecond[count] = arrayfirst[i];
        count++;
       }
   }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayfirst, arraysecond);
Console.WriteLine("Массив строк, длина которых составляет 3 символа: ");
PrintArray(arraysecond);
