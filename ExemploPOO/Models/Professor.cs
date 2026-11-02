namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        private double salario;
        public double Salario { get => salario; set { if (!double.IsFinite(value) || value < 0) throw new ArgumentOutOfRangeException(nameof(value)); salario = value; } }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e meu salário é {Salario}.");
        }
    }
}
