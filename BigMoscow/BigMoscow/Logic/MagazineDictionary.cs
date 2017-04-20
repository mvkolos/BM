using System;
using System.Collections.Generic;
using System.Configuration;
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
        public static Dictionary<string, string[]> GetDContent()
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
            dictionary.Add("_02", new string[] {
                Properties.Resources.m2_1+";"+"3",
                Properties.Resources.m2_2+";"+"12",
                Properties.Resources.m2_3+";"+"39",
                Properties.Resources.m2_4+";"+"49",
                Properties.Resources.m2_5+";"+"58",
                Properties.Resources.m2_6+";"+"64"
            });
            dictionary.Add("_03", new string[] {
                Properties.Resources.m3_1+";"+"3",
                Properties.Resources.m3_2+";"+"14",
                Properties.Resources.m3_3+";"+"43",
                Properties.Resources.m3_4+";"+"51",
                Properties.Resources.m3_5+";"+"60",
                Properties.Resources.m3_6+";"+"68",
                Properties.Resources.m3_7+";"+"74",
                Properties.Resources.m3_8+";"+"84",
                Properties.Resources.m3_9+";"+"89",
                Properties.Resources.m3_10+";"+"97",

            });
            dictionary.Add("_04", new string[] {
                Properties.Resources.m4_1+";"+"3",
                Properties.Resources.m4_2+";"+"14",
                Properties.Resources.m4_3+";"+"48",
                Properties.Resources.m4_4+";"+"58",
                Properties.Resources.m4_5+";"+"66",
                Properties.Resources.m4_6+";"+"80",
                Properties.Resources.m4_7+";"+"86",
                Properties.Resources.m4_8+";"+"91",
                Properties.Resources.m4_9+";"+"101",
                Properties.Resources.m4_10+";"+"108",

            });
            dictionary.Add("_05", new string[] {
                Properties.Resources.m5_1+";"+"3",
                Properties.Resources.m5_2+";"+"13",
                Properties.Resources.m5_3+";"+"44",
                Properties.Resources.m5_4+";"+"53",
                Properties.Resources.m5_5+";"+"62",
                Properties.Resources.m5_6+";"+"71",
                Properties.Resources.m5_7+";"+"76",
                Properties.Resources.m5_8+";"+"81",
                Properties.Resources.m5_9+";"+"86",
                Properties.Resources.m5_10+";"+"91",
                Properties.Resources.m5_11+";"+"97",
            });
            dictionary.Add("_06", new string[] {
                Properties.Resources.m6_1+";"+"3",
                Properties.Resources.m6_2+";"+"15",
                Properties.Resources.m6_3+";"+"47",
                Properties.Resources.m6_4+";"+"55",
                Properties.Resources.m6_5+";"+"63",
                Properties.Resources.m6_6+";"+"72",
                Properties.Resources.m6_7+";"+"77",
                Properties.Resources.m6_8+";"+"82",
                Properties.Resources.m6_9+";"+"87",
                Properties.Resources.m6_10+";"+"97",
                Properties.Resources.m6_11+";"+"100",
                Properties.Resources.m6_12+";"+"106"

            });
            dictionary.Add("_07", new string[] {
                Properties.Resources.m7_1+";"+"3",
                Properties.Resources.m7_2+";"+"17",
                Properties.Resources.m7_3+";"+"47",
                Properties.Resources.m7_4+";"+"56",
                Properties.Resources.m7_5+";"+"65",
                Properties.Resources.m7_6+";"+"71",
                 Properties.Resources.m7_7+";"+"76",
                Properties.Resources.m7_8+";"+"81",
                Properties.Resources.m7_9+";"+"86",
                Properties.Resources.m7_10+";"+"91",
                Properties.Resources.m7_11+";"+"100"


            });
            dictionary.Add("_08", new string[] {
                Properties.Resources.m8_1+";"+"3",
                Properties.Resources.m8_2+";"+"19",
                Properties.Resources.m8_3+";"+"51",
                Properties.Resources.m8_4+";"+"60",
                Properties.Resources.m8_5+";"+"68",
                Properties.Resources.m8_6+";"+"76",
                Properties.Resources.m8_7+";"+"85",
                Properties.Resources.m8_8+";"+"91",
                Properties.Resources.m8_9+";"+"94",
                Properties.Resources.m8_10+";"+"99",
                Properties.Resources.m8_11+";"+"104"


            });
            dictionary.Add("_09", new string[] {
                Properties.Resources.m9_1+";"+"3",
                Properties.Resources.m9_2+";"+"19",
                Properties.Resources.m9_3+";"+"50",
                Properties.Resources.m9_4+";"+"60",
                Properties.Resources.m9_5+";"+"68",
                Properties.Resources.m9_6+";"+"76",
                Properties.Resources.m9_7+";"+"80",
                Properties.Resources.m9_8+";"+"85",
                Properties.Resources.m9_9+";"+"89",
                Properties.Resources.m9_10+";"+"94",
                Properties.Resources.m9_11+";"+"99"


            });
            dictionary.Add("_10", new string[] {
                Properties.Resources.m10_1+";"+"4",
                Properties.Resources.m10_2+";"+"19",
                Properties.Resources.m10_3+";"+"53",
                Properties.Resources.m10_4+";"+"62",
                Properties.Resources.m10_5+";"+"71",
                Properties.Resources.m10_6+";"+"81",
                Properties.Resources.m10_7+";"+"85",
                Properties.Resources.m10_8+";"+"91",
                Properties.Resources.m10_9+";"+"95",
                Properties.Resources.m10_10+";"+"100",
                Properties.Resources.m10_11+";"+"106"


            });
            dictionary.Add("_11", new string[] {
                Properties.Resources.m11_1+";"+"4",
                Properties.Resources.m11_2+";"+"23",
                Properties.Resources.m11_3+";"+"63",
                Properties.Resources.m11_4+";"+"72",
                Properties.Resources.m11_5+";"+"84",
                Properties.Resources.m11_6+";"+"96",
                Properties.Resources.m11_7+";"+"108",
                Properties.Resources.m11_8+";"+"112",
                Properties.Resources.m11_9+";"+"118",
                Properties.Resources.m11_10+";"+"122",
                Properties.Resources.m11_11+";"+"127",
                Properties.Resources.m11_12+";"+"133"


            });
            dictionary.Add("_12", new string[] {
                Properties.Resources.m12_1+";"+"4",
                Properties.Resources.m12_2+";"+"20",
                Properties.Resources.m12_3+";"+"56",
                Properties.Resources.m12_4+";"+"67",
                Properties.Resources.m12_5+";"+"77",
                Properties.Resources.m12_6+";"+"86",
                Properties.Resources.m12_7+";"+"92",
                Properties.Resources.m12_8+";"+"98",
                Properties.Resources.m12_9+";"+"102",
                Properties.Resources.m12_10+";"+"107",
                Properties.Resources.m12_11+";"+"113"



            });
            dictionary.Add("_13", new string[] {
                Properties.Resources.m13_1+";"+"4",
                Properties.Resources.m13_2+";"+"20",
                Properties.Resources.m13_3+";"+"59",
                Properties.Resources.m13_4+";"+"70",
                Properties.Resources.m13_5+";"+"81",
                Properties.Resources.m13_6+";"+"90",
                Properties.Resources.m13_7+";"+"97",
                Properties.Resources.m13_8+";"+"107",
                Properties.Resources.m13_9+";"+"111",
                Properties.Resources.m13_10+";"+"115",
                Properties.Resources.m13_11+";"+"121"



            });
            dictionary.Add("_14", new string[] {
                Properties.Resources.m14_1+";"+"4",
                Properties.Resources.m14_2+";"+"20",
                Properties.Resources.m14_3+";"+"59",
                Properties.Resources.m14_4+";"+"71",
                Properties.Resources.m14_5+";"+"82",
                Properties.Resources.m14_6+";"+"91",
                Properties.Resources.m14_7+";"+"98",
                Properties.Resources.m14_8+";"+"104",
                Properties.Resources.m14_9+";"+"109",
                Properties.Resources.m14_10+";"+"114",
                Properties.Resources.m14_11+";"+"120"



            });
            dictionary.Add("_15", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"22",
                Properties.Resources.m15_3+";"+"63",
                Properties.Resources.m15_4+";"+"75",
                Properties.Resources.m15_5+";"+"88",
                Properties.Resources.m15_6+";"+"97",
                Properties.Resources.m15_7+";"+"105",
                Properties.Resources.m15_8+";"+"112",
                Properties.Resources.m15_9+";"+"117",
                Properties.Resources.m15_10+";"+"123",
                Properties.Resources.m15_11+";"+"134"



            });
            dictionary.Add("_16", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"22",
                Properties.Resources.m15_3+";"+"62",
                Properties.Resources.m15_4+";"+"74",
                Properties.Resources.m15_5+";"+"85",
                Properties.Resources.m15_6+";"+"95",
                Properties.Resources.m15_7+";"+"103",
                Properties.Resources.m15_8+";"+"109",
                Properties.Resources.m15_9+";"+"114",
                Properties.Resources.m15_10+";"+"120",
                Properties.Resources.m15_11+";"+"135"



            });
            dictionary.Add("_17", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"21",
                Properties.Resources.m15_3+";"+"61",
                Properties.Resources.m15_4+";"+"73",
                Properties.Resources.m15_5+";"+"86",
                Properties.Resources.m15_6+";"+"97",
                Properties.Resources.m15_7+";"+"103",
                Properties.Resources.m15_8+";"+"109",
                Properties.Resources.m15_9+";"+"114",
                Properties.Resources.m15_10+";"+"120",
                Properties.Resources.m15_11+";"+"129"



            });
            dictionary.Add("_18", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"21",
                Properties.Resources.m15_3+";"+"61",
                Properties.Resources.m15_4+";"+"73",
                Properties.Resources.m15_5+";"+"83",
                Properties.Resources.m15_6+";"+"95",
                Properties.Resources.m15_7+";"+"102",
                Properties.Resources.m15_8+";"+"109",
                Properties.Resources.m15_9+";"+"114",
                Properties.Resources.m15_10+";"+"121",
                Properties.Resources.m15_11+";"+"132"



            });
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
                dictionary.Add("_02", new string[] {
                Properties.Resources.m2_1+";"+"3",
                Properties.Resources.m2_2+";"+"12",
                Properties.Resources.m2_3+";"+"39",
                Properties.Resources.m2_4+";"+"49",
                Properties.Resources.m2_5+";"+"58",
                Properties.Resources.m2_6+";"+"64"
            });
                dictionary.Add("_03", new string[] {
                Properties.Resources.m3_1+";"+"3",
                Properties.Resources.m3_2+";"+"14",
                Properties.Resources.m3_3+";"+"43",
                Properties.Resources.m3_4+";"+"51",
                Properties.Resources.m3_5+";"+"60",
                Properties.Resources.m3_6+";"+"68",
                Properties.Resources.m3_7+";"+"74",
                Properties.Resources.m3_8+";"+"84",
                Properties.Resources.m3_9+";"+"89",
                Properties.Resources.m3_10+";"+"97",

            });
                dictionary.Add("_04", new string[] {
                Properties.Resources.m4_1+";"+"3",
                Properties.Resources.m4_2+";"+"14",
                Properties.Resources.m4_3+";"+"48",
                Properties.Resources.m4_4+";"+"58",
                Properties.Resources.m4_5+";"+"66",
                Properties.Resources.m4_6+";"+"80",
                Properties.Resources.m4_7+";"+"86",
                Properties.Resources.m4_8+";"+"91",
                Properties.Resources.m4_9+";"+"101",
                Properties.Resources.m4_10+";"+"108",

            });
                dictionary.Add("_05", new string[] {
                Properties.Resources.m5_1+";"+"3",
                Properties.Resources.m5_2+";"+"13",
                Properties.Resources.m5_3+";"+"44",
                Properties.Resources.m5_4+";"+"53",
                Properties.Resources.m5_5+";"+"62",
                Properties.Resources.m5_6+";"+"71",
                Properties.Resources.m5_7+";"+"76",
                Properties.Resources.m5_8+";"+"81",
                Properties.Resources.m5_9+";"+"86",
                Properties.Resources.m5_10+";"+"91",
                Properties.Resources.m5_11+";"+"97",
            });
                dictionary.Add("_06", new string[] {
                Properties.Resources.m6_1+";"+"3",
                Properties.Resources.m6_2+";"+"15",
                Properties.Resources.m6_3+";"+"47",
                Properties.Resources.m6_4+";"+"55",
                Properties.Resources.m6_5+";"+"63",
                Properties.Resources.m6_6+";"+"72",
                Properties.Resources.m6_7+";"+"77",
                Properties.Resources.m6_8+";"+"82",
                Properties.Resources.m6_9+";"+"87",
                Properties.Resources.m6_10+";"+"97",
                Properties.Resources.m6_11+";"+"100",
                Properties.Resources.m6_12+";"+"106"

            });
                dictionary.Add("_07", new string[] {
                Properties.Resources.m7_1+";"+"3",
                Properties.Resources.m7_2+";"+"17",
                Properties.Resources.m7_3+";"+"47",
                Properties.Resources.m7_4+";"+"56",
                Properties.Resources.m7_5+";"+"65",
                Properties.Resources.m7_6+";"+"71",
                 Properties.Resources.m7_7+";"+"76",
                Properties.Resources.m7_8+";"+"81",
                Properties.Resources.m7_9+";"+"86",
                Properties.Resources.m7_10+";"+"91",
                Properties.Resources.m7_11+";"+"100"


            });
                dictionary.Add("_08", new string[] {
                Properties.Resources.m8_1+";"+"3",
                Properties.Resources.m8_2+";"+"19",
                Properties.Resources.m8_3+";"+"51",
                Properties.Resources.m8_4+";"+"60",
                Properties.Resources.m8_5+";"+"68",
                Properties.Resources.m8_6+";"+"76",
                Properties.Resources.m8_7+";"+"85",
                Properties.Resources.m8_8+";"+"91",
                Properties.Resources.m8_9+";"+"94",
                Properties.Resources.m8_10+";"+"99",
                Properties.Resources.m8_11+";"+"104"


            });
                dictionary.Add("_09", new string[] {
                Properties.Resources.m9_1+";"+"3",
                Properties.Resources.m9_2+";"+"19",
                Properties.Resources.m9_3+";"+"50",
                Properties.Resources.m9_4+";"+"60",
                Properties.Resources.m9_5+";"+"68",
                Properties.Resources.m9_6+";"+"76",
                Properties.Resources.m9_7+";"+"80",
                Properties.Resources.m9_8+";"+"85",
                Properties.Resources.m9_9+";"+"89",
                Properties.Resources.m9_10+";"+"94",
                Properties.Resources.m9_11+";"+"99"


            });
                dictionary.Add("_10", new string[] {
                Properties.Resources.m10_1+";"+"4",
                Properties.Resources.m10_2+";"+"19",
                Properties.Resources.m10_3+";"+"53",
                Properties.Resources.m10_4+";"+"62",
                Properties.Resources.m10_5+";"+"71",
                Properties.Resources.m10_6+";"+"81",
                Properties.Resources.m10_7+";"+"85",
                Properties.Resources.m10_8+";"+"91",
                Properties.Resources.m10_9+";"+"95",
                Properties.Resources.m10_10+";"+"100",
                Properties.Resources.m10_11+";"+"106"


            });
                dictionary.Add("_11", new string[] {
                Properties.Resources.m11_1+";"+"4",
                Properties.Resources.m11_2+";"+"23",
                Properties.Resources.m11_3+";"+"63",
                Properties.Resources.m11_4+";"+"72",
                Properties.Resources.m11_5+";"+"84",
                Properties.Resources.m11_6+";"+"96",
                Properties.Resources.m11_7+";"+"108",
                Properties.Resources.m11_8+";"+"112",
                Properties.Resources.m11_9+";"+"118",
                Properties.Resources.m11_10+";"+"122",
                Properties.Resources.m11_11+";"+"127",
                Properties.Resources.m11_12+";"+"133"


            });
                dictionary.Add("_12", new string[] {
                Properties.Resources.m12_1+";"+"4",
                Properties.Resources.m12_2+";"+"20",
                Properties.Resources.m12_3+";"+"56",
                Properties.Resources.m12_4+";"+"67",
                Properties.Resources.m12_5+";"+"77",
                Properties.Resources.m12_6+";"+"86",
                Properties.Resources.m12_7+";"+"92",
                Properties.Resources.m12_8+";"+"98",
                Properties.Resources.m12_9+";"+"102",
                Properties.Resources.m12_10+";"+"107",
                Properties.Resources.m12_11+";"+"113"



            });
                dictionary.Add("_13", new string[] {
                Properties.Resources.m13_1+";"+"4",
                Properties.Resources.m13_2+";"+"20",
                Properties.Resources.m13_3+";"+"59",
                Properties.Resources.m13_4+";"+"70",
                Properties.Resources.m13_5+";"+"81",
                Properties.Resources.m13_6+";"+"90",
                Properties.Resources.m13_7+";"+"97",
                Properties.Resources.m13_8+";"+"107",
                Properties.Resources.m13_9+";"+"111",
                Properties.Resources.m13_10+";"+"115",
                Properties.Resources.m13_11+";"+"121"



            });
                dictionary.Add("_14", new string[] {
                Properties.Resources.m14_1+";"+"4",
                Properties.Resources.m14_2+";"+"20",
                Properties.Resources.m14_3+";"+"59",
                Properties.Resources.m14_4+";"+"71",
                Properties.Resources.m14_5+";"+"82",
                Properties.Resources.m14_6+";"+"91",
                Properties.Resources.m14_7+";"+"98",
                Properties.Resources.m14_8+";"+"104",
                Properties.Resources.m14_9+";"+"109",
                Properties.Resources.m14_10+";"+"114",
                Properties.Resources.m14_11+";"+"120"



            });
                dictionary.Add("_15", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"22",
                Properties.Resources.m15_3+";"+"63",
                Properties.Resources.m15_4+";"+"75",
                Properties.Resources.m15_5+";"+"88",
                Properties.Resources.m15_6+";"+"97",
                Properties.Resources.m15_7+";"+"105",
                Properties.Resources.m15_8+";"+"112",
                Properties.Resources.m15_9+";"+"117",
                Properties.Resources.m15_10+";"+"123",
                Properties.Resources.m15_11+";"+"134"



            });
                dictionary.Add("_16", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"22",
                Properties.Resources.m15_3+";"+"62",
                Properties.Resources.m15_4+";"+"74",
                Properties.Resources.m15_5+";"+"85",
                Properties.Resources.m15_6+";"+"95",
                Properties.Resources.m15_7+";"+"103",
                Properties.Resources.m15_8+";"+"109",
                Properties.Resources.m15_9+";"+"114",
                Properties.Resources.m15_10+";"+"120",
                Properties.Resources.m15_11+";"+"135"



            });
                dictionary.Add("_17", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"21",
                Properties.Resources.m15_3+";"+"61",
                Properties.Resources.m15_4+";"+"73",
                Properties.Resources.m15_5+";"+"86",
                Properties.Resources.m15_6+";"+"97",
                Properties.Resources.m15_7+";"+"103",
                Properties.Resources.m15_8+";"+"109",
                Properties.Resources.m15_9+";"+"114",
                Properties.Resources.m15_10+";"+"120",
                Properties.Resources.m15_11+";"+"129"



            });
                dictionary.Add("_18", new string[] {
                Properties.Resources.m15_1+";"+"4",
                Properties.Resources.m15_2+";"+"21",
                Properties.Resources.m15_3+";"+"61",
                Properties.Resources.m15_4+";"+"73",
                Properties.Resources.m15_5+";"+"83",
                Properties.Resources.m15_6+";"+"95",
                Properties.Resources.m15_7+";"+"102",
                Properties.Resources.m15_8+";"+"109",
                Properties.Resources.m15_9+";"+"114",
                Properties.Resources.m15_10+";"+"121",
                Properties.Resources.m15_11+";"+"132"



            });
                return dictionary;
            });
    }
}