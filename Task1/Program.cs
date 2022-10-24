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
return else;
}
string[] Mas2(int el)
{
string[] array2 = new string [el];
return array2;
}

string[] mas1 = {"fdf", "wert", "1", "4567"};
System.Console.WriteLine(KolEllements(mas1)); 