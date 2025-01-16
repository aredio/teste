/*using System;
using System.IO;
using System.Linq;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        var xmlFilePath = "dados.xml";
        if (!File.Exists(xmlFilePath))
        {
            Console.WriteLine("Arquivo dados.xml não encontrado.");
            return;
        }

        var xmlDocument = new XmlDocument();
        xmlDocument.Load(xmlFilePath);

        var nodeList = xmlDocument.SelectNodes("//row/valor");
        var valores = new List<double>();

        foreach (XmlNode node in nodeList)
        {
            var valor = double.Parse(node.InnerText);
            if (valor > 0)
                valores.Add(valor);
        }

        var valoresArray = valores.ToArray();



        var menorValor = valores.Min();
        var maiorValor = valores.Max();
        var media = valores.Average();
        var diasAcimaDaMedia = valores.Count(valor => valor > media);

        Console.WriteLine($"Menor valor de faturamento: {menorValor:F2}");
        Console.WriteLine($"Maior valor de faturamento: {maiorValor:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }
}
*/