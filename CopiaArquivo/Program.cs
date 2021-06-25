using System;
using System.IO;
using System.Threading;

namespace CopiaArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string origem = @"";
            string destino = @"";
            CopiarPasta(origem, destino);
        }

        private static void CopiarPasta(string dirOrigem,string dirDestino)
        {
            try
            {
                var arquivos = Directory.GetFiles(dirOrigem);
                var arqDestino = "";
                foreach (string arqOrigem in arquivos)
                {
                    arqDestino = Path.GetFileName(arqOrigem);
                    File.Copy(arqOrigem,dirDestino+"\\"+arqDestino,true);
                    Thread.Sleep(7000);
                }
                
                Console.WriteLine("Cópia encerrada!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("falha: " + ex.Message);
            }
        }
    }
}
