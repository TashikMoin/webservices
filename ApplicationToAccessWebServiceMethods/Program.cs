using ApplicationToAccessWebServiceMethods.ServiceReference;
using System;

namespace ApplicationToAccessWebServiceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            TestWebServiceSoapClient ProxyObj = new TestWebServiceSoapClient();
            Console.WriteLine("Result from WebService ---> " + ProxyObj.Greet("Tashik"));
            /* 
             * The conversion of C# objects --> XML+SOAP format requesting message is called serialization.
             * 
             * The conversion of XML+SOAP format response messages back to --> C# objects is called 
             * to get results from the functions of the webservices is called deserialization.
             * 
             * Serialization and Deseralization happens when we call Greet method of the web service.
            */
        }
    }
}
