using System;
using System.Xml;

namespace XmlUtil {
    public class XMLUtil {
        public static Object getBean() {
            try {
                string path = ".\\config.xml";
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode config = doc.GetElementsByTagName("config")[0];
                XmlNodeList classNames = config.ChildNodes;
                string systemName = classNames[0].InnerText;
                string className = systemName + "." + systemName + "Factory";
                Type t = Type.GetType(className);
                return Activator.CreateInstance(t);
            } catch (Exception e) {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
