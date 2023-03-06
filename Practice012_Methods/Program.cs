//Метод 1 (метод ничего не принимает и не отдает)
void Method1()
{
    Console.WriteLine("Some text...");
}

//Method1();

//Метод 2 (метод что-то принимает, но ничего не отдает)
void Method2(string msg)
{
    Console.WriteLine(msg);
}

//Method2("Hello");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

//Method21("Text", 5);
//Method21(count: 7, msg: "Some text");

//Метод 3 (метод, который ничего не принимает, но что-то возвращает)
int Method3()
{
    return DateTime.Now.Year;
}

//Console.WriteLine(Method3());

//Метод 4 (метод, который что-то принимает и что-то возвращает)
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}
string res = Method4(5,"funny");
Console.WriteLine(res);
