namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public string Escola { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e meu salário é {Salario} e sou diretor da escola {Escola}.");
        }
    }
}