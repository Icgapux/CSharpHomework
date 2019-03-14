using System;
using ImageLoader;

namespace LoaderFactory {
    public interface ImageLoaderFactory {
        Loader createLoader();
    }
}
