using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMoscow.Logic
{
    class MagazineDictionary
    {
        public static Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add(".01_2012-v", "_01");
            dictionary.Add(".01_2013-v", "_03");
            dictionary.Add(".01_2014-v", "_07");
            dictionary.Add(".01_2015-v", "_10");
            dictionary.Add(".01_2016-v", "_14");
            dictionary.Add(".02_2012-v", "_02");
            dictionary.Add(".02_2013-v", "_04");
            dictionary.Add(".02_2014-v", "_08");
            dictionary.Add(".02_2015-v", "_11");
            dictionary.Add(".02_2016-v", "_15");
            dictionary.Add(".03_2013-v", "_05");
            dictionary.Add(".03_2014-v", "_09");
            dictionary.Add(".03_2015-v", "_12");
            dictionary.Add(".03_2016-v", "_16");
            dictionary.Add(".04_2013-v", "_06");
            dictionary.Add(".04_2015-v", "_13");
            dictionary.Add(".04_2016-v", "_17");

            return dictionary;
        }

        public static Lazy<Dictionary<string, string[]>> GetContent =
            new Lazy<Dictionary<string, string[]>>(() =>
            {

                Dictionary<string, string[]> dictionary =
                    new Dictionary<string, string[]>();
                dictionary.Add("_01", new string[]
                {
                    Properties.Resources.m1_1 + ";" + "3",
                    Properties.Resources.m1_2 + ";" + "10",
                    Properties.Resources.m1_3 + ";" + "19",
                    Properties.Resources.m1_4 + ";" + "31",
                    Properties.Resources.m1_5 + ";" + "63",
                    Properties.Resources.m1_6 + ";" + "72",
                    Properties.Resources.m1_7 + ";" + "81",

                });
                return dictionary;
            });
    }
}