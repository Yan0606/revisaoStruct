using System;
 
struct Funcionario
{
    public string nome;
    public string sobrenome;
    public string cargo;
    public int cpf;
    public float salario;
    public int cargaHoraria;    


    public void aumentoSalarialPorPromocaoEmValor(float valor)
    {
        salario += valor;
    }

    public void promocao(string novoCargo, float aumentoSalarial)
    {
        cargo = novoCargo;
        aumentoSalarialPorPromocaoEmValor(aumentoSalarial);

    }

    public void descontoSalarialPorFaltaEmValor(float valor)
    {
        salario -= valor;
    }

     public void aumentarCargaHorariaDeTrabalho(int horas)
    {
        cargaHoraria += horas;
        salario *= (cargaHoraria / 20.0f); 
    }

    public void imprimir()
    {
        System.Console.WriteLine("Nome: " + nome);
        System.Console.WriteLine("Sobrenome: " + sobrenome);
        System.Console.WriteLine("Cargo: " + cargo);
        System.Console.WriteLine("CPF: " + cpf);
        System.Console.WriteLine("Salário: R$" + salario);
        System.Console.WriteLine("CargaHorária: " + cargaHoraria + "horas");
    }

    public void divisao()
     {
         System.Console.WriteLine("\n=======CARRO========\n");
     }

}

struct Carro
{
    public string nomeModelo;
    public string fabricanteMontadora;
    public string dataFabricacao;
    public float preco;
}
    
    class No
    {
        public Carro carro;
        public No prox;
    } 

class ListaCarros
{
    private No primeiro;
    private No ultimo;

    public ListaCarros()
    {
        primeiro = null;
        ultimo = null;
    }

    public void inserir(Carro carro)
    {
        No novoNo = new No();
        novoNo.carro = carro;
        novoNo.prox = null;

        if (primeiro == null)
        {
            primeiro = novoNo;
            ultimo = novoNo;
        }

        else 
        {
            ultimo.prox = novoNo;
            ultimo = novoNo;
        }
    }

    public bool consultar (string nomeModelo)
    {
        No atual = primeiro;
        while  (atual != null)
        {
            if (atual.carro.nomeModelo == nomeModelo)
            return true;
            atual = atual.prox;
        }
        return false;
    }


        public void remover()
    {
        if (primeiro == null)
        {
            Console.WriteLine("A lista está vazia!");
            return;
        }

        if (primeiro == ultimo)
        {
            primeiro = null;
            ultimo = null;
        }
        else
        {
            No atual = primeiro;
            while (atual.prox != ultimo)
            {
                atual = atual.prox;
            }
            ultimo = atual;
            ultimo.prox = null;
        }
    }

        public void percorrer()
    {
        No atual = primeiro;
        while (atual != null)
        {
            System.Console.WriteLine("Nome do Modelo: " + atual.carro.nomeModelo);
            System.Console.WriteLine("Fabricante/Montadora: " + atual.carro.fabricanteMontadora);
            System.Console.WriteLine("Data de Fabricação: " + atual.carro.dataFabricacao);
            System.Console.WriteLine("Preço: " + atual.carro.preco);
            System.Console.WriteLine();
            atual = atual.prox;
        }
    }

}