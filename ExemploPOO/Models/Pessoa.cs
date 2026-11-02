namespace ExemploPOO.Models
{
    public class Pessoa
    {
        private string nome = string.Empty;
        private int idade;
        public string Nome {
            get => nome;
            set {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length > 100) throw new ArgumentException("Nome obrigatório, com até 100 caracteres.");
                nome = value.Trim();
            }
        }
        public int Idade {
            get => idade;
            set { if (value < 0 || value > 130) throw new ArgumentOutOfRangeException(nameof(value)); idade = value; }
        }
        public virtual void Apresentar() => Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}
