// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic.FileIO;

Console.WriteLine("Hello, World!");
//string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Dados\\";
string path = @"C:\Dados\";
string file = "arquivo.txt";
if (!Directory.Exists(path))
{
    Directory.CreateDirectory(path);
}

if (!File.Exists(path + file))
{
    File.Create(path + file);
}

if(File.Exists(path +file))
{
    StreamReader sr = new StreamReader(path + file);
    string s = sr.ReadToEnd();
    Console.Clear();
    Console.WriteLine(s);
    sr.Close();
    s += Console.ReadLine();
    StreamWriter sw = new (path + file);
    sw.WriteLine(s);
    sw.Close();
    Console.Clear();
    Console.WriteLine("Type the line number you want: ");
    StreamReader sr2 = new(path + file);
    int i = int.Parse(Console.ReadLine());
     var retorno =File.ReadLines(path + file).Skip(2).Take(1).First();
    int item = 0;
    foreach(string line in File.ReadLines(path + file))
    {
        item++;
        if(item == 3)
        {
            Console.WriteLine(line);
        }

    }
    for (int walk = 1; walk < i; walk++)
    {
        sr2.ReadLine();
    }
    Console.WriteLine(sr2.ReadLine());
    
    sr.Close();
}
//StreamWriter sw = new(path + file);
//Console.WriteLine("Type your name: ");
//string s = Console.ReadLine();

//sw.WriteLine(s);

//Console.WriteLine("Type your email: ");
//s = Console.ReadLine();
//sw.WriteLine(s);
//sw.Close(); //Sempre fechar depois de manipular pois se não o SO entende que alguem esta utilizando e não deixa continuar

//StreamReader sr = new(path + file);

//Console.Clear();
//Console.WriteLine(sr.ReadToEnd());
//sr.Close();

