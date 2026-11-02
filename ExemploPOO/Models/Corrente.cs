namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            if (!double.IsFinite(valor) || valor <= 0 || !double.IsFinite(saldo + valor)) throw new System.ArgumentOutOfRangeException(nameof(valor));
            saldo += valor;
        }
        public double Saldo => saldo;
    }
}
