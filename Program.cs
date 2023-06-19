class Program
{
    static void Main(string[] args)
    {
        Funcionario funcionario1 = new Funcionario();

        funcionario1.nome = "Yan";
        funcionario1.sobrenome = "Andrade";
        funcionario1.cargo = "Programador";
        funcionario1.cpf = 404;
        funcionario1.salario = 2000f;
        funcionario1.cargaHoraria= 45;

        funcionario1.descontoSalarialPorFaltaEmValor(2);

        funcionario1.aumentarCargaHorariaDeTrabalho(5);

        funcionario1.promocao("Programador Junior", 4000f);

        funcionario1.imprimir();

        funcionario1.divisao();

        Carro carro1 = new Carro();

        carro1.nomeModelo = "Palio";
        carro1.fabricanteMontadora = "Fiat";
        carro1.dataFabricacao = "01/01/1997";
        carro1.preco = 5000f;

                ListaCarros listaCarros = new ListaCarros();

        listaCarros.inserir(carro1);

        Carro carro2 = new Carro();
        carro2.nomeModelo = "HB20";
        carro2.fabricanteMontadora = "Hyundai";
        carro2.dataFabricacao = "01/01/2019";
        carro2.preco = 50000f;

        listaCarros.inserir(carro2);

        listaCarros.percorrer();

        bool encontrouCarro = listaCarros.consultar("Palio");
        if (encontrouCarro)
        {
            Console.WriteLine("O carro Palio está na lista!");
        }
        else
        {
            Console.WriteLine("O carro  Palio não está na lista!");
        }

        listaCarros.remover();

        listaCarros.percorrer();

        
    

    }

    
}