using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassMan.Core.Utils
{
    public static class PathUtils
    {
        public static string Home { get => Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); }

        public static string ResolveVirtual(string path) => path.Replace("~", Home);
    }
}
