using System;
using System.Xml;
using LoaderFactory;
using ImageLoaderFactorys;

namespace XmlUtil {
    public class XMLUtil {
        public static Object getBean() {
            try {
                string path = ".\\config.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode config = doc.GetElementsByTagName("config")[0];
                XmlNodeList classNames = config.ChildNodes;
                string className = "ImageLoaderFactorys." + classNames[0].InnerText;
                Type t = Type.GetType(className);
                return Activator.CreateInstance(t);
            } catch (Exception e) {
                Console.WriteLine(e);
                return e;
            }
            // try {
            // } catch {
            //
            // }
        }
    }
}
