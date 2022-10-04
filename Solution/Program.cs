// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо ввести на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Clear();

Console.Write("Введите размер массива n: ");
int size =int.Parse(Console.ReadLine());

string[] array = new string[size]; 
Console.WriteLine("Введите элементы массива: " );// Ввод элементов через Enter
for (int i = 0; i < size; i++)
    array[i] = Console.ReadLine(); 
Console.Write($"[{String.Join(" , ",array)}]"); //Вывод заданного масива

Console.WriteLine();

string[] GetFinalArray(string[] array){
    
    string[]finalArray = new string[array.Length];
    int count = 0;
    int n = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n )
        {
            finalArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref finalArray, count);// Изменение размерности финального массива
    return finalArray;
}

Console.Write($"[{String.Join(" , ",GetFinalArray(array))}]");//Вывод финального массива
Console.WriteLine();
