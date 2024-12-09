using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Xml;
using System.IO;

namespace Serializacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro umlivro = new Livro();

            umlivro.setCodigo("");
            umlivro.setTitulo("");
            umlivro.setAutor("");
            umlivro.setEditora("");
            umlivro.setAno("");

            FileStream arquivo = new FileStream("Teste.txt",FileMode.Open);
            DataContractSerializer obj = new DataContractSerializer(umlivro.GetType());
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(arquivo, new XmlDictionaryReaderQuotas());
            umlivro = (Livro)obj.ReadObject(reader,true);
            reader.Close();

            Console.WriteLine(umlivro.getCodigo());
            Console.WriteLine(umlivro.getTitulo());
            Console.WriteLine(umlivro.getAutor());
            Console.WriteLine(umlivro.getEditora());
            Console.WriteLine(umlivro.getAno());
            Console.ReadKey();
        }
    }
}
