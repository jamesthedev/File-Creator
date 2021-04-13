using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Creator
{
    static class FileGroup
    {
        private static List<string> EligibleFileGroupList = new List<string>()
        {
            "html",
            "css",
            "js"
        };

        private static List<List<string>> FileGroups = new List<List<string>>()
        {
            new List<string>() { "html", "css", "js" }
        };        

        public static bool HasFileGroup(string opt)
        {
            return GetGroup(opt) != null;
        }

        public static List<string> GetGroup(string opt)
        {
            List<string> result = FileGroups.Where(x => x.Any(y => y == opt.ToLower().Trim())).FirstOrDefault();

            return result;
        }
    }
}
