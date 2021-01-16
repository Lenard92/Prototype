using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    //Deze filehelper is een interface die aangeroepen wordt door de individuele LocalFileHelper classes in de .Droid/ .iOS en UWP applicaties. Op deze manier weten de applicaties waar de database is, of moet komen.  
    public interface ILocalFileHelper
    {
        string GetLocalFilePath(string fileName);
    }
}
