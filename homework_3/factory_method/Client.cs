using System;
using XmlUtil;
using LoaderFactory;
using ImageLoader;
namespace Client {
    public class Client {
        static void Main(string[] args) {
            ImageLoaderFactory factory = (ImageLoaderFactory)XMLUtil.getBean();
            Loader loader = factory.createLoader();
            loader.load();
        }
    }
}
