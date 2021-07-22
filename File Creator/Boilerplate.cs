using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator.boilerplate
{
    static class Boilerplate
    {
        private static List<string> BoilerplateList = new List<string>()
        {
            "html",
            "cs",
            "java",
            "xml"
        };

        public static bool HasBoilerplate(string opt)
        {
            return BoilerplateList.Contains(opt.ToLower().Trim());
        }

        public static string CreateBoilerplate(string opt, string fname, bool fileGroup)
        {
            switch(opt.ToLower())
            {
                case "html":
                    return HtmlBoilerPlate(fileGroup, fname);
                case "xml":
                    return XmlBoilerplate();
                default:
                    return ClassBoilerplate(opt, fname);
            }
        }

        //adds reference to CSS file if part of a file group
        private static string HtmlBoilerPlate(bool fileGroup, string fname)
        {
            return 
                "<!DOCTYPE html>\n" +
                "<html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\">\n" +
                "<head>\n"  +
                    (fileGroup ? $"<link rel=\"stylesheet\" href=\"{fname}.css\">\n" : "") +
                    "\t<meta charset=\"utf-8\" />\n" +
                    "\t<title></title>\n" +
                "</head>\n" +
                "<body>\n\t\n"  +
                "</body>\n" +
                "</html>";
        }

        //creates a class + constructor that matches filename. used for .cs, .java, etc.
        private static string ClassBoilerplate(string opt, string fname)
        {
            return String.Format("public class {0} \n{{\n\tpublic {0}() {{}}\n}}", fname);
        }

        private static string XmlBoilerplate()
        {
            return "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n";
        }
    }
}
