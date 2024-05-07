// See https://aka.ms/new-console-template for more information
using _5by5_ManipularArquivos;
using Microsoft.VisualBasic.FileIO;
string path = @"C:\DadosEstoque\";
string file = "products.txt";

Console.WriteLine(">>> CADASTRO DE PRODUTOS <<<");
Product CreateProduct()
{
    Console.WriteLine("Informe um id:");
    var id = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a descrição do produto");
    var d = Console.ReadLine();
    Console.WriteLine("Informe o preço do produto");
    var p = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a quantidade do produto");
    var q = int.Parse(Console.ReadLine());

    return new Product(id, d, p, q);
}

List<Product> products = new();

products.Add(CreateProduct());
bool CheckIfExists(string p, string f)
{
    if(!Directory.Exists(p))
    {
        Directory.CreateDirectory(p);
    }
    if (!File.Exists(p + f))
    {
        File.Create(p + f);
    }

    return true;
}
void ShowAll(List<Product> l)
{
    foreach (var item in l)
    {
        Console.WriteLine(item.ToString());
    }
}
ShowAll(products);

void SaveFile(List<Product> l, string p,string f)
{
    if(CheckIfExists(p, f))
    {
        StreamWriter sw = new(p + f);
        foreach(var item in l)
        {
            sw.WriteLine(item.ToString());
        }
        sw.Close();

    }
}
List<Product> LoadFile(string p, string f)
{
    List<Product> l = new List<Product>();
    if (CheckIfExists(p, f))
    {


        string[] data = new string[4];
        StreamReader sr = new(p + f);

        foreach (var linha in File.ReadAllLines(p + f))
        {
            data = linha.Split(";");
            l.Add(new(int.Parse(data[0]), data[1], double.Parse(data[2]), int.Parse(data[3])));
        }
    } return l;
}
SaveFile(products, path, file);
List<Product> p2 = new(LoadFile(path, file));

ShowAll(p2);









//Console.WriteLine("Hello, World!");
////string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Dados\\";
//string path = @"C:\Dados\";
//string file = "arquivo.txt";
//if (!Directory.Exists(path))
//{
//    Directory.CreateDirectory(path);
//}

//if (!File.Exists(path + file))
//{
//    File.Create(path + file);
//}

//if(File.Exists(path +file))
//{
//    StreamReader sr = new StreamReader(path + file);
//    string s = sr.ReadToEnd();
//    Console.Clear();
//    Console.WriteLine(s);
//    sr.Close();
//    s += Console.ReadLine();
//    StreamWriter sw = new (path + file);
//    sw.WriteLine(s);
//    sw.Close();
//    Console.Clear();
//    Console.WriteLine("Type the line number you want: ");
//    StreamReader sr2 = new(path + file);
//    int i = int.Parse(Console.ReadLine());
//     var retorno =File.ReadLines(path + file).Skip(2).Take(1).First();
//    int item = 0;
//    foreach(string line in File.ReadLines(path + file))
//    {
//        item++;
//        if(item == 3)
//        {
//            Console.WriteLine(line);
//        }

//    }
//    for (int walk = 1; walk < i; walk++)
//    {
//        sr2.ReadLine();
//    }
//    Console.WriteLine(sr2.ReadLine());
    
//    sr.Close();
//}
////StreamWriter sw = new(path + file);
////Console.WriteLine("Type your name: ");
////string s = Console.ReadLine();

////sw.WriteLine(s);

////Console.WriteLine("Type your email: ");
////s = Console.ReadLine();
////sw.WriteLine(s);
////sw.Close(); //Sempre fechar depois de manipular pois se não o SO entende que alguem esta utilizando e não deixa continuar

////StreamReader sr = new(path + file);

////Console.Clear();
////Console.WriteLine(sr.ReadToEnd());
////sr.Close();

