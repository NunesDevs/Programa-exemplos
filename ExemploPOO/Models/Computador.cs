namespace ExemploPOO.Models
{
    public class Computador
    {
        public string SistemaOperacional => Environment.OSVersion.VersionString;
        public int ProcessadoresLogicos => Environment.ProcessorCount;
        public override string ToString() => $"Sistema: {SistemaOperacional}; processadores lógicos: {ProcessadoresLogicos}";
    }
}
