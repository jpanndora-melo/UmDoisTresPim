Console.Clear();

int numeroPim = 1;

while(numeroPim <= 40)
{
    bool multiploDoQuatro = numeroPim % 4 == 0;
    if (multiploDoQuatro)
    {
        Console.WriteLine("pim");
        Console.Beep(1650, 66);
    }
    else
    {
        Console.Write($"{numeroPim} ");
    }
    
    numeroPim = numeroPim + 1; 
}
