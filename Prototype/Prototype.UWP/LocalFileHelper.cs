using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using Prototype.UWP;

using Environment = System.Environment;

// Deze dependency moet bekend zijn om het compilen van de UWPapplicatie mogelijk te maken
[assembly :Dependency(typeof(LocalFileHelper))]
namespace Prototype.UWP

{
    class LocalFileHelper : ILocalFileHelper
    {
        // Deze filehelper vraagt de locatie van de database op via de interface of genereert zelf een lokaal path
        public string GetLocalFilePath(string fileName)
        {

            var path = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            string fullPath = Path.Combine(path, fileName);

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return fullPath;
            
        }
    }
}
