int KolEllements(string[] array)
{
int length = array.Length;
int lengthString = 3;
int el = 0;
int i =0;
    while (i<length)
    {
        if (array[i].Length <= lengthString)
        {
            el++; i++;
        } 
        else i++;   
    }
return el;
}

string[] mas1 = {"fdf", "wert", "1", "4567"};
System.Console.WriteLine(KolEllements(mas1)); 
return el;
}
string[] Mas2(int el)
{
string[] array2 = new string [el];
return array2;
}

string[] MasNew(string[] array, string[] array2)
{
int length = array.Length;
int lengthString = 3;
int i =0; int j =0;
    while (i<length)
    {
        if (array[i].Length <= lengthString)
        {
            array2[j] = array[i]; i++; j++;   
        } 
        else i++;   
    }
return array2;
}

void PrintMas(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine(array[i]);
    }
}

string[] mas1 = {"fdf", "wert", "1", "4567"};
Console.WriteLine("ИСХОДНЫЙ МАССИВ");
PrintMas(mas1); 
//Console.WriteLine("Кол-во эл-тов состоящих из менее 3х символов =" + KolEllements(mas1)); 
Console.WriteLine("НОВЫЙ МАССИВ");
PrintMas(MasNew(mas1, Mas2(KolEllements(mas1))));