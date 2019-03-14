using System;
using LoaderFactory;
using ImageLoader;
using Loaders;

namespace ImageLoaderFactorys {
    public class GIFLoaderFactory: ImageLoaderFactory {
        public Loader createLoader() {
            Console.WriteLine("Created a GIF loader");
            return new GIFLoader();
        }
    }

    public class JPGLoaderFactory: ImageLoaderFactory {
        public Loader createLoader() {
            Console.WriteLine("Created a JPG loader");
            return new JPGLoader();
        }
    }
}
