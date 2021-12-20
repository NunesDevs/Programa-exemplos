using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
            var returnCaminho = Directory.GetDirectories(caminho);

            foreach (var retorno in returnCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void ListarArquivos(string caminho)
        {
            var returnArquivos = Directory.GetFiles(caminho);
            foreach (var retorno in returnArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }
        public void CriarDiretorio(string caminho1)
        {
            var retorno = Directory.CreateDirectory(caminho1);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho2)
        {
            Directory.Delete(caminho2);
        }

        public void CriarArquivoTexto(string caminho3, string conteudo)
        {
            File.WriteAllText(caminho3, conteudo);
        }
    }    
}