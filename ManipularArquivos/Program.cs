
//string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Dados\\";

string path = @"C:\Dados\"; //Caminho do arquivo
string file = "arquivo.txt"; //Arquivo

if (!Directory.Exists(path)) //Se o diretorio/caminho não existe 
{
    Directory.CreateDirectory(path); //Criar diretório/caminho
}

if (File.Exists(path + file))
{
    StreamReader sr = new StreamReader(path + file);
    string s = sr.ReadToEnd(); //Ler arquivo inteiro e guarda na string s
    Console.Clear();
    Console.WriteLine(s); //Escreve o foi guardado na string s
    sr.Close(); //Fecha o arquvio

    s += "\n"; // s = s + "\n"
    s += Console.ReadLine(); // s = s + Console.ReadLine() | S é igual a ele mesmo (o que ele ja tinha) + a novo inserção do usuario 

    StreamWriter sw = new(path + file);
    sw.WriteLine(s); //O objeto sw do tipo StreamWriter - Escreve no arquivo o que foi guardado na string "s"
    sw.Close(); //Fecha o arquivo

    Console.Clear();
    Console.WriteLine("Conteudo do arquivo");
    StreamReader sr2 = new(path + file); //Cria um novo objeto do tipo StreamReader, pois o arquivo ja foi fechado e aberto de novo
    Console.WriteLine(sr2.ReadToEnd()); //Imprime o que foi lido no arquivo, até o final dele.
    sr2.Close();

    //1° forma
    var retorno = File.ReadLines(path+file).ElementAt(2); //(0,1,2) - 3° Linha
    //var instancia como uma variável genérica quando não se sabe o tipo certo de retorno. Ele atribui automaticamente o tipo de retorno esperado.
    Console.WriteLine(retorno);

    //2 ° forma
    int item = 0;
    foreach (string linha in File.ReadLines(path+ file))
    {
        item++;
        if(item == 3)
        {
            Console.WriteLine(linha);
        }
    }

    
}


//Console.Clear();
//StreamReader sr3 = new(path + file);
//Console.Write("Qual linha você deseja ler: ");
//int linha = int.Parse(Console.ReadLine());
//for (int i = 0; i < linha-1; i++)
//{ 
//    sr3.ReadLine();
//}

//Console.Clear();
//Console.Write("\n" + sr3.ReadLine());
//sr3.Close();