using System.Xml;

namespace ProjectDesktop.Models
{
    public class Desencryptacion
    {
        static private Encryptacion aes = new Encryptacion();
        static public string CnString;
        static string dbcnString;
        static public string appPwdUnique = "wmssistema.olamundo";
        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }
        internal class label { }
        public static object UsuariosEncryp()
        {
            XmlDocument doc = new XmlDocument();
            label root = new label();
            dbcnString = root.ToString();
            CnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return CnString;

        }
    }
}
