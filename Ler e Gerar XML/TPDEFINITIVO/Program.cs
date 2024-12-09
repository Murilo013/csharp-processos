using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TPDEFINITIVO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<OcorrenciaPonto> ocorrencias = new List<OcorrenciaPonto>();
            string aux = "";
            StreamReader file = new System.IO.StreamReader("abril2017.txt");

            while ((aux = file.ReadLine()) != null)
            {
                OcorrenciaPonto ocorrencia = new OcorrenciaPonto();
                ocorrencia.Prontuario = aux.Substring(0, 15).Trim();
                ocorrencia.Data = aux.Substring(15, 6).Trim();
                ocorrencia.Filler = aux.Substring(21, 4).Trim();

                // Adicionar a ocorrência à lista
                ocorrencias.Add(ocorrencia);

                // Exibir no console para verificar a leitura
                Console.WriteLine("Prontuário: " + ocorrencia.Prontuario + " - Data: " + ocorrencia.Data + " - Filler: " + ocorrencia.Filler);
            }

            // Fechar o arquivo após a leitura
            file.Close();

            try
            {
                // Serializar a lista de ocorrências em XML
                TextWriter arquivo = new StreamWriter("testando.xml");
                XmlSerializer obj = new XmlSerializer(typeof(List<OcorrenciaPonto>));
                obj.Serialize(arquivo, ocorrencias);
                arquivo.Close();
                Console.WriteLine("Arquivo XML gerado com sucesso.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro durante a serialização: " + e.Message);
            }
        }
    }
}
