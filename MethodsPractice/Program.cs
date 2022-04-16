

Console.WriteLine(SumLimit(2, 3));
Console.WriteLine(SumLimit(8, 3));
Console.WriteLine(SumLimit(8, 1));






static int SumLimit(int a, int b)
{
    int sum = a + b;
    string aString = a.ToString();
    string sumString = sum.ToString();

    if (aString.Length == sumString.Length)
    {
        return sum;
    }
    else
    {
        return a;
    }

}


static bool SquirrelPlay(int temperature, bool isSummer)
{
    // Not implemented. Just return
    // something to avoid a build error.
    return false;
}