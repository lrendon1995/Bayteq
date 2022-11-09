using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Helpers
{
    public static class UrlHelperExtentions
    {
        public static string ScriptsVersioned(this UrlHelper self, string contentPath)
        {
            if (self is null)
            {
                throw new Exception("Ocurrió un error.");
            }
            var versionedContentPath = contentPath + "?version=" + Assembly.GetAssembly(typeof(UrlHelperExtentions)).GetName().Version;
            return self.Content(versionedContentPath);
        }
    }
}