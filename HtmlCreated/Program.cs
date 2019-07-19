using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlCreated
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\comunikime\arquivo.html"))
            {
                sw.WriteLine("<HTML>");
                sw.WriteLine("<head>" +
                    "<script>" +
                    "function pode(){alert('Testando o testador')}" +
                    "</script>" +
                    "</head>");
                sw.WriteLine("<TITLE>Hello World...</TITLE>");
                sw.WriteLine("<BODY>");
                sw.WriteLine("<H1>Hello World !</H1>");
                sw.WriteLine("<button onclick='pode()'>Adicionar</button>");
                sw.WriteLine("</BODY>");
                sw.WriteLine("</HTML>");

                sw.Close();
            }

        }
    }
}
