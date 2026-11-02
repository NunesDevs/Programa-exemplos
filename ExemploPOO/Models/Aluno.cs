namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
      private int nota;
      public int Nota { get => nota; set { if (value < 0 || value > 10) throw new ArgumentOutOfRangeException(nameof(value)); nota = value; } }

       public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e minha nota é {Nota}.");
        }
    }
}
