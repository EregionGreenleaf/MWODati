using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWODati
{
    public class Config
    {
        public static int MaxRigheTextBox = 200;

        public static string Season1URL = "http://www.loschupacabras.netsons.org/Season123/MWOl_Season_01_GENERAL.txt";
        public static string Season2URL = "http://www.loschupacabras.netsons.org/Season123/MWOl_Season_02_GENERAL.txt";
        public static string Season3URL = "http://www.loschupacabras.netsons.org/Season123/MWOl_Season_03_GENERAL.txt";
        public static string Season4URL = "http://www.loschupacabras.netsons.org/Season123/MWOl_Season_04_GENERAL.txt";

        public static string[] fileSeason1 { get; set; } = null;
        public static string[] fileSeason2 { get; set; } = null;
        public static string[] fileSeason3 { get; set; } = null;
        public static string[] fileSeason4 { get; set; } = null;
    }
}
