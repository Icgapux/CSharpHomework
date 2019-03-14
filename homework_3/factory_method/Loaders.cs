using System;
using ImageLoader;

namespace Loaders {
    public class JPGLoader: Loader {
        public void load() {
            Console.WriteLine("Loaded a JPG.");
        }
    }

    public class GIFLoader: Loader {
        public void load() {
            Console.WriteLine("Loaded a GIF.");
        }
    }
}
