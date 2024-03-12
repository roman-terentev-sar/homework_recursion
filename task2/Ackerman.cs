int firstNum = new Random().Next(1, 4);
Console.WriteLine("m = " + firstNum);

int secondNum = new Random().Next(1, 6);
Console.WriteLine("n = " + secondNum);

int Ackerman(int m, int n)
{
    if(m == 0) return n+1;
    else if(n == 0) return Ackerman(m - 1, 1);
    else return Ackerman(m-1, Ackerman(m, n-1));

}

Console.WriteLine(Ackerman(firstNum, secondNum));
