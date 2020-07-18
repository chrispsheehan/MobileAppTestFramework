using System;
using System.IO;

namespace MobileAppTests.Framework
{
    public static class PathGenerator
    {
        private const string sourceFolder = "src";

        private const string appsFolder = "apps";

        private static readonly string basePath = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf(sourceFolder));

        public static string GetAppPath(string appFile)
        {
            string appBasePath = Path.Combine(basePath, appsFolder);

            string fullPath = Path.Combine(appBasePath, appFile);

            if(!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"Could not find app file {fullPath}");
            }

            return fullPath;
        }
    }
}