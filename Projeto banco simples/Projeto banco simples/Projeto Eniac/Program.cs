using Projeto_Eniac.Classes;
using Projeto_Eniac.Domain;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Projeto Sistema de Banco ");
        
        Conta conta = new Conta();
        Validador Validador = new Validador();
        Calculo calcula = new Calculo();
        decimal ValorTotal = 0;
        decimal subtracao = 0;
        bool resultado;
        decimal total = 0;
        


        Console.WriteLine("Digite a Agência do seu Banco!");
        conta.Agencia = Convert.ToInt32(Console.ReadLine());

        resultado = Validador.ValidadorAgencia(conta.Agencia.ToString());
        if (resultado == false)
        {
            Console.WriteLine("Agência do seu Banco invalida, digite ela novamente, ela deve ter 4 números!");
            conta.Agencia = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Digite o número da sua conta!");
        conta.numero = Convert.ToInt32(Console.ReadLine());

        resultado = Validador.ValidadorNumero(conta.numero.ToString());
        if (resultado == false)
        {
            Console.WriteLine("Número do seu Banco invalida, digite ele novamente, ela deve ter 8 números!");
            conta.numero = Convert.ToInt32(Console.ReadLine());
        }      


        Console.WriteLine("Digite o Nome do titular da conta!");
        conta.nomeCliente = Console.ReadLine();


        Console.WriteLine("Digite o valor disponível na conta!");
        conta.valorDisponivel = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Dejesa tira dinheiro da conta? S/N");
        Console.WriteLine("\ta - S");
        Console.WriteLine("\ts - N");
        Console.Write("Sua opção?");
       if(Console.ReadLine() == "S")
        {
            Console.WriteLine("Quanto deseja retirar da conta?");
            subtracao = Convert.ToDecimal(Console.ReadLine());
            total = calcula.Retirada(conta.valorDisponivel, subtracao);
        }
        else
        {
            total = conta.valorDisponivel;

        }

        Console.WriteLine($"Sua agencia é: {conta.Agencia} " +
            $" O número da sua conta é:{conta.numero} " +
            $" O seu Nome é:{conta.nomeCliente} " +
            $" Você tem disponivel na sua conta:{total} ");


        Console.Write("Aperte enter para fechar o aplicativo");
        Console.ReadKey();
    }
}