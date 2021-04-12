using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator.boilerplate
{
    static class Boilerplate
    {
        public static bool HasBoilerplate(string opt)
        {
            string lowerOpt = opt.ToLower().Trim();
            return lowerOpt == "html" || lowerOpt == "cs" || lowerOpt == "java";
        }

        public static string CreateBoilerplate(string opt, string fname)
        {
            if (opt.ToLower() == "html")
            {
                return HtmlBoilerPlate();
            }

            else 
            {
                return ClassBoilerplate(opt, fname);
            }
        }

        private static string HtmlBoilerPlate()
        {
            return 
                "<!DOCTYPE html>\n" +
                "<html lang='en' xmlns='http://www.w3.org/1999/xhtml'>\n" +
                "<head>\n"  +
                    "\t<meta charset='utf-8' />\n" +
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
    }
}
