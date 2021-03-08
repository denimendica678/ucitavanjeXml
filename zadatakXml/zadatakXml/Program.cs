using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace zadatakXml
{
    class Program
    {
        static void Main(string[] args)
        {


          

            XmlDocument doc = new XmlDocument();
            //Load the the document with the last book node.  
            XmlTextReader reader = new XmlTextReader(@"C:\Users\Učenik 3\Desktop\vjezba.xml");
            reader.Read();
            // load reader   
            doc.Load(reader);
            // Display contents on the console  
            doc.Save(Console.Out);


            Console.ReadKey();
        }
        
    }
}
