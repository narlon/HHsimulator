using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.IO;

namespace HHsimulator
{
    class PicLoader
    {
        static public Image Read(String path) {
            Bitmap bmp;
            try
            {
                Assembly myAssembly = Assembly.LoadFrom("PicResource.dll");
                Stream myStream = myAssembly.GetManifestResourceStream("PicResource.images." + path);
                bmp = new Bitmap(myStream);
            }
            catch {
                bmp = null;
            }
            return bmp;
        }
    }
}
