// See https://aka.ms/new-console-template for more information
using Plantao_UC_COD_BACK.classes;
string opcao = "";
PessoaJuridica PJ = PessoaJuridica();

do{
Console.WriteLine(@"

1 - Cadastrar
2 - Sair

")?:
    opcao = Console.ReadLine();
    if (opcao=="1"){
        PessoaJuridica = new PessoaJuridica();
        Console.WriteLine("Digite o nome da Pessoa Juridica");
        PJ.Nome = Console.ReadLine();
    }
}while(opcao != "2")
