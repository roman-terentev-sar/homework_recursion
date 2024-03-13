

int m = new Random().Next(1,10);
int n = new Random().Next(20, 100);

void PrintNum(int newn)
{
    Console.WriteLine(newn);
    if(newn ==m) return;
    PrintNum(newn-1);
}

PrintNum(n);