using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Serializacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro umlivro = new Livro();

            TextReader arquivo = new StreamReader("teste.xml");
            XmlSerializer obj = new XmlSerializer(umlivro.GetType());
            umlivro = (Livro)obj.Deserialize(arquivo);

            Console.WriteLine(umlivro.getCodigo());
            Console.WriteLine(umlivro.getTitulo());
            Console.WriteLine(umlivro.getAutor());
            Console.WriteLine(umlivro.getEditora());
            Console.WriteLine(umlivro.getAno());
            Console.ReadKey();
        }
    }
}
