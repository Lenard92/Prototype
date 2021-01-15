using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using Prototype.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Environment = System.Environment;

[assembly :Dependency(typeof(LocalFileHelper))]
namespace Prototype.Droid
{
    class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
                    return Path.Combine(libFolder, fileName);
            
        }
    }
}
