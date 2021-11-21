using System.Web.Services;

namespace WebApplicationHavingWebService
{
    /// <summary>
    /// Summary description for TestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    /* 
     * This WebService decorator helps in uniquely identifying your webservice over the web.
     * The namespace name is mostly the domain name, by default .net framework sets it to "http://tempuri.org/"
     * It can be anything (your domain name),
     * for e.g tashik.com/webservice (helps in uniquely identifying your webservice with other 
     * webservices on the internet).
     * 
    */
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    /*
     * A binding, as defined by Web Services Description Language (WSDL), is to a web service as an interface 
     * is to a . NET class. That is, it defines a specific set of operations. A WebService class can have 
     * multiple WebServiceBinding attributes, each specifying a different binding.
    */
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestWebService : System.Web.Services.WebService
    /*
     * Inheriting webservice class from System.Web.Services.WebService parent class to use session data and
     * application state objects.
    */
    {

        [WebMethod]
        /* 
         * Helps in exposing the method of a webservice to the client publicly. Only method having this
         * WebMethod decorator can be used by the client to use this webservice. These methdos must be public.
        */
        public string Greet(string Firstname)
        {
            return "Hello " + Firstname;
        }
    }
}
