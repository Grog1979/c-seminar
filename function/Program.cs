// процедуры (для повторного использования кода, процедура ничего не возвращает)
Console.Clear();
void f(ref int x)
{
    x = x + 10;
}

int n = 5;
Console.WriteLine(n);
f(ref n); // ссылка
Console.WriteLine(n);

// функция даем два числа выводим большее

int f1(int x, int y)
{                                 //else сдесь не надо т.к. return останавливает дальнейшее выполнение
    if (x > y)                     //if (x > y)
        return x;                  //   return x;
    else                           //return y;
        return y;
}

int n1 = 5;
int n2 = 10;
int max = f1(n1, n2);
Console.WriteLine(max);

 // через string
string f2(int x, int y)
{                                  
    if (x > y)                     
        return ">";                 
    return "<";
}

int n3 = 5;
int n4 = 10;

Console.WriteLine(f2(n3, n4));    
