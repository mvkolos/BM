﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMoscow.Logic
{
    class MagazineDictionary
    {
        public static Dictionary<string, string> magazinesDictionary;
        public static Dictionary<string, string[]> contentDictionary;

        static MagazineDictionary()
        {
            AddMagazines();
            AddContent();
            
        }

       
        public static void AddMagazines()
        {
            magazinesDictionary = new Dictionary<string, string>();
            magazinesDictionary.Add(".01_2012-v", "_01");
            magazinesDictionary.Add(".01_2013-v", "_03");
            magazinesDictionary.Add(".01_2014-v", "_07");
            magazinesDictionary.Add(".01_2015-v", "_10");
            magazinesDictionary.Add(".01_2016-v", "_14");
            magazinesDictionary.Add(".02_2012-v", "_02");
            magazinesDictionary.Add(".02_2013-v", "_04");
            magazinesDictionary.Add(".02_2014-v", "_08");
            magazinesDictionary.Add(".02_2015-v", "_11");
            magazinesDictionary.Add(".02_2016-v", "_15");
            magazinesDictionary.Add(".03_2013-v", "_05");
            magazinesDictionary.Add(".03_2014-v", "_09");
            magazinesDictionary.Add(".03_2015-v", "_12");
            magazinesDictionary.Add(".03_2016-v", "_16");
            magazinesDictionary.Add(".04_2013-v", "_06");
            magazinesDictionary.Add(".04_2015-v", "_13");
            magazinesDictionary.Add(".04_2016-v", "_17");
            magazinesDictionary.Add(".00_2017-v", "_18");
            magazinesDictionary.Add(".01_2017-v", "_19");
        }
        public static void AddContent()
        {
            contentDictionary=new Dictionary<string, string[]>();
            contentDictionary.Add("_01", new string[]
            {
                    Properties.Resources.m1_1 + ";" + "3" + ";" + "3",
                    Properties.Resources.m1_2 + ";" + "10"+ ";" + "10",
                    Properties.Resources.m1_3 + ";" + "19"+ ";" + "19",
                    Properties.Resources.m1_4 + ";" + "48"+ ";" + "48",
                    Properties.Resources.m1_5 + ";" + "57"+ ";" + "57",
                    Properties.Resources.m1_6 + ";" + "64"+ ";"+"63",
                    Properties.Resources.m1_7 + ";" + "72"+ ";" + "72",

            });
            contentDictionary.Add("_02", new string[] {
                Properties.Resources.m2_1+";"+"3"+";"+"3",
                Properties.Resources.m2_2+";"+"12"+";"+"12",
                Properties.Resources.m2_3+";"+"39"+";"+"39",
                Properties.Resources.m2_4+";"+"49"+";"+"49",
                Properties.Resources.m2_5+";"+"58"+";"+"58",
                Properties.Resources.m2_6+";"+"64"+";"+"64",
                Properties.Resources.m8_8+";"+"71"+";"+"71",
                Properties.Resources.m2_8+";"+"76"+";"+"76"

            });
            contentDictionary.Add("_03", new string[] {
                Properties.Resources.m3_1+";"+"3"+";"+"3",
                Properties.Resources.m3_2+";"+"14"+";"+"14",
                Properties.Resources.m3_3+";"+"43"+";"+"43",
                Properties.Resources.m3_4+";"+"51"+";"+"51",
                Properties.Resources.m3_5+";"+"60"+";"+"60",
                Properties.Resources.m3_6+";"+"68"+";"+"68",
                Properties.Resources.m3_7+";"+"74"+";"+"74",
                Properties.Resources.m3_8+";"+"84"+";"+"84",
                Properties.Resources.m3_9+";"+"89"+";"+"89",
                Properties.Resources.m3_10+";"+"97"+";"+"97",

            });
            contentDictionary.Add("_04", new string[] {
                Properties.Resources.m4_1+";"+"3"+";"+"3",
                Properties.Resources.m4_2+";"+"14"+";"+"14",
                Properties.Resources.m4_3+";"+"48"+";"+"48",
                Properties.Resources.m4_4+";"+"58"+";"+"58",
                Properties.Resources.m4_5+";"+"67"+";"+"66",
                Properties.Resources.m4_6+";"+"80"+";"+"79",
                Properties.Resources.m4_7+";"+"86"+";"+"85",
                Properties.Resources.m4_8+";"+"91"+";"+"90",
                Properties.Resources.m4_9+";"+"96"+";"+"95",
                Properties.Resources.m5_10+";"+"101"+";"+"100",
                Properties.Resources.m4_11+";"+"108"+";"+"107",

            });
            contentDictionary.Add("_05", new string[] {
                Properties.Resources.m5_1+";"+"3"+";"+"3",
                Properties.Resources.m5_2+";"+"13"+";"+"13",
                Properties.Resources.m5_3+";"+"45"+";"+"44",
                Properties.Resources.m5_4+";"+"54"+";"+"53",
                Properties.Resources.m5_5+";"+"63"+";"+"62",
                Properties.Resources.m5_6+";"+"72"+";"+"71",
                Properties.Resources.m5_7+";"+"77"+";"+"76",
                Properties.Resources.m5_8+";"+"82"+";"+"81",
                Properties.Resources.m5_9+";"+"87"+";"+"86",
                Properties.Resources.m5_10+";"+"92"+";"+"91",
                Properties.Resources.m5_11+";"+"98"+";"+"97",
            });
            contentDictionary.Add("_06", new string[] {
                Properties.Resources.m6_1+";"+"3"+";"+"3",
                Properties.Resources.m6_2+";"+"15"+";"+"15",
                Properties.Resources.m6_3+";"+"47"+";"+"47",
                Properties.Resources.m6_4+";"+"55"+";"+"55",
                Properties.Resources.m6_5+";"+"63"+";"+"63",
                Properties.Resources.m6_6+";"+"72"+";"+"72",
                Properties.Resources.m6_7+";"+"77"+";"+"77",
                Properties.Resources.m6_8+";"+"82"+";"+"82",
                Properties.Resources.m6_9+";"+"87"+";"+"87",
                Properties.Resources.m6_10+";"+"95"+";"+"95",
                Properties.Resources.m6_11+";"+"100"+";"+"100",
                Properties.Resources.m6_12+";"+"106"+";"+"106"

            });
            contentDictionary.Add("_07", new string[] {
                Properties.Resources.m7_1+";"+"3"+";"+"3",
                Properties.Resources.m7_2+";"+"17"+";"+"17",
                Properties.Resources.m7_3+";"+"47"+";"+"47",
                Properties.Resources.m7_4+";"+"56"+";"+"56",
                Properties.Resources.m7_5+";"+"65"+";"+"65",
                Properties.Resources.m3_6+";"+"71"+";"+"71",
                 Properties.Resources.m7_7+";"+"76"+";"+"76",
                Properties.Resources.m7_8+";"+"81"+";"+"81",
                Properties.Resources.m7_9+";"+"95"+";"+"95",
                Properties.Resources.m7_10+";"+"86"+";"+"86",
                Properties.Resources.m7_11+";"+"100"+";"+"100"


            });
            contentDictionary.Add("_08", new string[] {
                Properties.Resources.m8_1+";"+"3"+";"+"3",
                Properties.Resources.m8_2+";"+"19"+";"+"19",
                Properties.Resources.m8_3+";"+"51"+";"+"51",
                Properties.Resources.m8_4+";"+"60"+";"+"60",
                Properties.Resources.m8_5+";"+"68"+";"+"68",
                Properties.Resources.m8_6+";"+"76"+";"+"76",
                Properties.Resources.m8_7+";"+"86"+";"+"85",
                Properties.Resources.m8_8+";"+"92"+";"+"91",
                Properties.Resources.m8_9+";"+"95"+";"+"94",
                Properties.Resources.m8_10+";"+"100"+";"+"99",
                Properties.Resources.m8_11+";"+"105"+";"+"104"


            });
            contentDictionary.Add("_09", new string[] {
                Properties.Resources.m9_1+";"+"3"+";"+"3",
                Properties.Resources.m9_2+";"+"19"+";"+"19",
                Properties.Resources.m9_3+";"+"49"+";"+"50",
                Properties.Resources.m9_4+";"+"59"+";"+"60",
                Properties.Resources.m9_5+";"+"68"+";"+"68",
                Properties.Resources.m9_6+";"+"76"+";"+"76",
                Properties.Resources.m9_7+";"+"80"+";"+"80",
                Properties.Resources.m9_8+";"+"85"+";"+"85",
                Properties.Resources.m9_9+";"+"89"+";"+"89",
                Properties.Resources.m9_10+";"+"94"+";"+"94",
                Properties.Resources.m9_11+";"+"99"+";"+"99"


            });
            contentDictionary.Add("_10", new string[] {
                Properties.Resources.m10_1+";"+"4"+";"+"4",
                Properties.Resources.m10_2+";"+"19"+";"+"19",
                Properties.Resources.m10_3+";"+"53"+";"+"53",
                Properties.Resources.m10_4+";"+"62"+";"+"62",
                Properties.Resources.m10_5+";"+"71"+";"+"71",
                Properties.Resources.m3_6+";"+"81"+";"+"81",
                Properties.Resources.m10_7+";"+"85"+";"+"85",
                Properties.Resources.m10_8+";"+"91"+";"+"91",
                Properties.Resources.m10_9+";"+"95"+";"+"95",
                Properties.Resources.m10_10+";"+"100"+";"+"100",
                Properties.Resources.m10_11+";"+"106"+";"+"106"


            });
            contentDictionary.Add("_11", new string[] {
                Properties.Resources.m11_1+";"+"4"+";"+"4",
                Properties.Resources.m11_2+";"+"23"+";"+"23",
                Properties.Resources.m11_3+";"+"63"+";"+"63",
                Properties.Resources.m11_4+";"+"72"+";"+"72",
                Properties.Resources.m11_5+";"+"84"+";"+"84",
                Properties.Resources.m11_6+";"+"96"+";"+"96",
                Properties.Resources.m11_7+";"+"108"+";"+"108",
                Properties.Resources.m11_8+";"+"112"+";"+"112",
                Properties.Resources.m11_9+";"+"118"+";"+"118",
                Properties.Resources.m11_10+";"+"122"+";"+"122",
                Properties.Resources.m11_11+";"+"127"+";"+"127",
                Properties.Resources.m11_12+";"+"133"+";"+"133"


            });
            contentDictionary.Add("_12", new string[] {
                Properties.Resources.m12_1+";"+"4"+";"+"4",
                Properties.Resources.m12_2+";"+"21"+";"+"20",
                Properties.Resources.m12_3+";"+"59"+";"+"56",
                Properties.Resources.m12_4+";"+"70"+";"+"67",
                Properties.Resources.m12_5+";"+"80"+";"+"77",
                Properties.Resources.m12_6+";"+"89"+";"+"86",
                Properties.Resources.m12_7+";"+"95"+";"+"92",
                Properties.Resources.m12_8+";"+"101"+";"+"98",
                Properties.Resources.m12_9+";"+"105"+";"+"102",
                Properties.Resources.m12_10+";"+"110"+";"+"107",
                Properties.Resources.m12_11+";"+"116"+";"+"113"



            });
            contentDictionary.Add("_13", new string[] {
                Properties.Resources.m13_1+";"+"4"+";"+"4",
                Properties.Resources.m13_2+";"+"20"+";"+"20",
                Properties.Resources.m13_3+";"+"59"+";"+"59",
                Properties.Resources.m13_4+";"+"70"+";"+"70",
                Properties.Resources.m13_5+";"+"81"+";"+"81",
                Properties.Resources.m13_6+";"+"90"+";"+"90",
                Properties.Resources.m13_7+";"+"97"+";"+"97",
                Properties.Resources.m13_8+";"+"107"+";"+"107",
                Properties.Resources.m13_9+";"+"111"+";"+"111",
                Properties.Resources.m13_10+";"+"115"+";"+"115",
                Properties.Resources.m13_11+";"+"121"+";"+"121"



            });
            contentDictionary.Add("_14", new string[] {
                Properties.Resources.m14_1+";"+"4"+";"+"4",
                Properties.Resources.m14_2+";"+"20"+";"+"20",
                Properties.Resources.m14_3+";"+"60"+";"+"59",
                Properties.Resources.m14_4+";"+"72"+";"+"71",
                Properties.Resources.m14_5+";"+"83"+";"+"82",
                Properties.Resources.m14_6+";"+"92"+";"+"91",
                Properties.Resources.m14_7+";"+"99"+";"+"98",
                Properties.Resources.m14_8+";"+"105"+";"+"104",
                Properties.Resources.m14_9+";"+"110"+";"+"109",
                Properties.Resources.m14_10+";"+"115"+";"+"114",
                Properties.Resources.m14_11+";"+"121"+";"+"120"



            });
            contentDictionary.Add("_15", new string[] {
                Properties.Resources.m15_1+";"+"4"+";"+"4",
                Properties.Resources.m15_2+";"+"22"+";"+"22",
                Properties.Resources.m15_3+";"+"63"+";"+"63",
                Properties.Resources.m15_4+";"+"75"+";"+"75",
                Properties.Resources.m15_5+";"+"88"+";"+"88",
                Properties.Resources.m15_6+";"+"97"+";"+"97",
                Properties.Resources.m15_7+";"+"105"+";"+"105",
                Properties.Resources.m15_8+";"+"112"+";"+"112",
                Properties.Resources.m15_9+";"+"117"+";"+"117",
                Properties.Resources.m15_11+";"+"123"+";"+"123",
                Properties.Resources.m15_10+";"+"134"+";"+"134"



            });
            contentDictionary.Add("_16", new string[] {
                Properties.Resources.m15_1+";"+"4"+";"+"4",
                Properties.Resources.m15_2+";"+"22"+";"+"22",
                Properties.Resources.m15_3+";"+"62"+";"+"62",
                Properties.Resources.m15_4+";"+"74"+";"+"74",
                Properties.Resources.m15_5+";"+"86"+";"+"85",
                Properties.Resources.m15_6+";"+"96"+";"+"95",
                Properties.Resources.m15_7+";"+"105"+";"+"103",
                Properties.Resources.m15_8+";"+"110"+";"+"109",
                Properties.Resources.m15_9+";"+"115"+";"+"114",
                Properties.Resources.m15_10+";"+"136"+";"+"120",
                Properties.Resources.m15_11+";"+"121"+";"+"135"



            });
            contentDictionary.Add("_17", new string[] {
                Properties.Resources.m15_1+";"+"4"+";"+"4",
                Properties.Resources.m15_2+";"+"21"+";"+"21",
                Properties.Resources.m15_3+";"+"62"+";"+"61",
                Properties.Resources.m15_4+";"+"74"+";"+"73",
                Properties.Resources.m15_5+";"+"87"+";"+"86",
                Properties.Resources.m15_6+";"+"98"+";"+"97",
                Properties.Resources.m15_7+";"+"104"+";"+"103",
                Properties.Resources.m15_8+";"+"110"+";"+"109",
                Properties.Resources.m15_9+";"+"115"+";"+"114",
                Properties.Resources.m15_10+";"+"130"+";"+"120",
                Properties.Resources.m15_11+";"+"121"+";"+"129"



            });
            contentDictionary.Add("_18", new string[] {
                Properties.Resources.m12_1+";"+"4"+";"+"4",
                Properties.Resources.m12_2+";"+"21"+";"+"21",
                Properties.Resources.m12_3+";"+"60"+";"+"61",
                Properties.Resources.m12_4+";"+"74"+";"+"73",
                Properties.Resources.m12_5+";"+"85"+";"+"83",
                Properties.Resources.m12_7+";"+"97"+";"+"102",
                Properties.Resources.m3_6+";"+"104"+";"+"95",
                Properties.Resources.m14_8+";"+"111"+";"+"109",
                Properties.Resources.m15_9+";"+"116"+";"+"114",
                Properties.Resources.m15_11+";"+"123"+";"+"132",
                Properties.Resources.m15_10+";"+"134"+";"+"121"



            });
            contentDictionary.Add("_19", new string[] {
                Properties.Resources.m19_1+";"+"6"+";"+"3",
                Properties.Resources.m19_2+";"+"7"+";"+"6",
                Properties.Resources.m19_3+";"+"11"+";"+"10",
                Properties.Resources.m19_4+";"+"44"+";"+"41",
                Properties.Resources.m19_5+";"+"62"+";"+"57",
                Properties.Resources.m19_6+";"+"65"+";"+"60",
                Properties.Resources.m19_7+";"+"90"+";"+"81",
                Properties.Resources.m19_8+";"+"93"+";"+"84",



            });
        }
        //public static Lazy<Dictionary<string, string[]>> GetContent =
        //    new Lazy<Dictionary<string, string[]>>(() =>
        //    {

        //        Dictionary<string, string[]> dictionary =
        //            new Dictionary<string, string[]>();
        //        dictionary.Add("_01", new string[]
        //        {
        //            Properties.Resources.m1_1 + ";" + "3",
        //            Properties.Resources.m1_2 + ";" + "10",
        //            Properties.Resources.m1_3 + ";" + "19",
        //            Properties.Resources.m1_4 + ";" + "31",
        //            Properties.Resources.m1_5 + ";" + "63",
        //            Properties.Resources.m1_6 + ";" + "72",
        //            Properties.Resources.m1_7 + ";" + "81",

        //        });
        //        dictionary.Add("_02", new string[] {
        //        Properties.Resources.m2_1+";"+"3",
        //        Properties.Resources.m2_2+";"+"12",
        //        Properties.Resources.m2_3+";"+"39",
        //        Properties.Resources.m2_4+";"+"49",
        //        Properties.Resources.m2_5+";"+"58",
        //        Properties.Resources.m2_6+";"+"64"
        //    });
        //        dictionary.Add("_03", new string[] {
        //        Properties.Resources.m3_1+";"+"3",
        //        Properties.Resources.m3_2+";"+"14",
        //        Properties.Resources.m3_3+";"+"43",
        //        Properties.Resources.m3_4+";"+"51",
        //        Properties.Resources.m3_5+";"+"60",
        //        Properties.Resources.m3_6+";"+"68",
        //        Properties.Resources.m3_7+";"+"74",
        //        Properties.Resources.m3_8+";"+"84",
        //        Properties.Resources.m3_9+";"+"89",
        //        Properties.Resources.m3_10+";"+"97",

        //    });
        //        dictionary.Add("_04", new string[] {
        //        Properties.Resources.m4_1+";"+"3",
        //        Properties.Resources.m4_2+";"+"14",
        //        Properties.Resources.m4_3+";"+"48",
        //        Properties.Resources.m4_4+";"+"58",
        //        Properties.Resources.m4_5+";"+"66",
        //        Properties.Resources.m4_6+";"+"80",
        //        Properties.Resources.m4_7+";"+"86",
        //        Properties.Resources.m4_8+";"+"91",
        //        Properties.Resources.m4_9+";"+"101",
        //        Properties.Resources.m4_10+";"+"108",

        //    });
        //        dictionary.Add("_05", new string[] {
        //        Properties.Resources.m5_1+";"+"3",
        //        Properties.Resources.m5_2+";"+"13",
        //        Properties.Resources.m5_3+";"+"44",
        //        Properties.Resources.m5_4+";"+"53",
        //        Properties.Resources.m5_5+";"+"62",
        //        Properties.Resources.m5_6+";"+"71",
        //        Properties.Resources.m5_7+";"+"76",
        //        Properties.Resources.m5_8+";"+"81",
        //        Properties.Resources.m5_9+";"+"86",
        //        Properties.Resources.m5_10+";"+"91",
        //        Properties.Resources.m5_11+";"+"97",
        //    });
        //        dictionary.Add("_06", new string[] {
        //        Properties.Resources.m6_1+";"+"3",
        //        Properties.Resources.m6_2+";"+"15",
        //        Properties.Resources.m6_3+";"+"47",
        //        Properties.Resources.m6_4+";"+"55",
        //        Properties.Resources.m6_5+";"+"63",
        //        Properties.Resources.m6_6+";"+"72",
        //        Properties.Resources.m6_7+";"+"77",
        //        Properties.Resources.m6_8+";"+"82",
        //        Properties.Resources.m6_9+";"+"87",
        //        Properties.Resources.m6_10+";"+"97",
        //        Properties.Resources.m6_11+";"+"100",
        //        Properties.Resources.m6_12+";"+"106"

        //    });
        //        dictionary.Add("_07", new string[] {
        //        Properties.Resources.m7_1+";"+"3",
        //        Properties.Resources.m7_2+";"+"17",
        //        Properties.Resources.m7_3+";"+"47",
        //        Properties.Resources.m7_4+";"+"56",
        //        Properties.Resources.m7_5+";"+"65",
        //        Properties.Resources.m7_6+";"+"71",
        //         Properties.Resources.m7_7+";"+"76",
        //        Properties.Resources.m7_8+";"+"81",
        //        Properties.Resources.m7_9+";"+"86",
        //        Properties.Resources.m7_10+";"+"91",
        //        Properties.Resources.m7_11+";"+"100"


        //    });
        //        dictionary.Add("_08", new string[] {
        //        Properties.Resources.m8_1+";"+"3",
        //        Properties.Resources.m8_2+";"+"19",
        //        Properties.Resources.m8_3+";"+"51",
        //        Properties.Resources.m8_4+";"+"60",
        //        Properties.Resources.m8_5+";"+"68",
        //        Properties.Resources.m8_6+";"+"76",
        //        Properties.Resources.m8_7+";"+"85",
        //        Properties.Resources.m8_8+";"+"91",
        //        Properties.Resources.m8_9+";"+"94",
        //        Properties.Resources.m8_10+";"+"99",
        //        Properties.Resources.m8_11+";"+"104"


        //    });
        //        dictionary.Add("_09", new string[] {
        //        Properties.Resources.m9_1+";"+"3",
        //        Properties.Resources.m9_2+";"+"19",
        //        Properties.Resources.m9_3+";"+"50",
        //        Properties.Resources.m9_4+";"+"60",
        //        Properties.Resources.m9_5+";"+"68",
        //        Properties.Resources.m9_6+";"+"76",
        //        Properties.Resources.m9_7+";"+"80",
        //        Properties.Resources.m9_8+";"+"85",
        //        Properties.Resources.m9_9+";"+"89",
        //        Properties.Resources.m9_10+";"+"94",
        //        Properties.Resources.m9_11+";"+"99"


        //    });
        //        dictionary.Add("_10", new string[] {
        //        Properties.Resources.m10_1+";"+"4",
        //        Properties.Resources.m10_2+";"+"19",
        //        Properties.Resources.m10_3+";"+"53",
        //        Properties.Resources.m10_4+";"+"62",
        //        Properties.Resources.m10_5+";"+"71",
        //        Properties.Resources.m10_6+";"+"81",
        //        Properties.Resources.m10_7+";"+"85",
        //        Properties.Resources.m10_8+";"+"91",
        //        Properties.Resources.m10_9+";"+"95",
        //        Properties.Resources.m10_10+";"+"100",
        //        Properties.Resources.m10_11+";"+"106"


        //    });
        //        dictionary.Add("_11", new string[] {
        //        Properties.Resources.m11_1+";"+"4",
        //        Properties.Resources.m11_2+";"+"23",
        //        Properties.Resources.m11_3+";"+"63",
        //        Properties.Resources.m11_4+";"+"72",
        //        Properties.Resources.m11_5+";"+"84",
        //        Properties.Resources.m11_6+";"+"96",
        //        Properties.Resources.m11_7+";"+"108",
        //        Properties.Resources.m11_8+";"+"112",
        //        Properties.Resources.m11_9+";"+"118",
        //        Properties.Resources.m11_10+";"+"122",
        //        Properties.Resources.m11_11+";"+"127",
        //        Properties.Resources.m11_12+";"+"133"


        //    });
        //        dictionary.Add("_12", new string[] {
        //        Properties.Resources.m12_1+";"+"4",
        //        Properties.Resources.m12_2+";"+"20",
        //        Properties.Resources.m12_3+";"+"56",
        //        Properties.Resources.m12_4+";"+"67",
        //        Properties.Resources.m12_5+";"+"77",
        //        Properties.Resources.m12_6+";"+"86",
        //        Properties.Resources.m12_7+";"+"92",
        //        Properties.Resources.m12_8+";"+"98",
        //        Properties.Resources.m12_9+";"+"102",
        //        Properties.Resources.m12_10+";"+"107",
        //        Properties.Resources.m12_11+";"+"113"



        //    });
        //        dictionary.Add("_13", new string[] {
        //        Properties.Resources.m13_1+";"+"4",
        //        Properties.Resources.m13_2+";"+"20",
        //        Properties.Resources.m13_3+";"+"59",
        //        Properties.Resources.m13_4+";"+"70",
        //        Properties.Resources.m13_5+";"+"81",
        //        Properties.Resources.m13_6+";"+"90",
        //        Properties.Resources.m13_7+";"+"97",
        //        Properties.Resources.m13_8+";"+"107",
        //        Properties.Resources.m13_9+";"+"111",
        //        Properties.Resources.m13_10+";"+"115",
        //        Properties.Resources.m13_11+";"+"121"



        //    });
        //        dictionary.Add("_14", new string[] {
        //        Properties.Resources.m14_1+";"+"4",
        //        Properties.Resources.m14_2+";"+"20",
        //        Properties.Resources.m14_3+";"+"59",
        //        Properties.Resources.m14_4+";"+"71",
        //        Properties.Resources.m14_5+";"+"82",
        //        Properties.Resources.m14_6+";"+"91",
        //        Properties.Resources.m14_7+";"+"98",
        //        Properties.Resources.m14_8+";"+"104",
        //        Properties.Resources.m14_9+";"+"109",
        //        Properties.Resources.m14_10+";"+"114",
        //        Properties.Resources.m14_11+";"+"120"



        //    });
        //        dictionary.Add("_15", new string[] {
        //        Properties.Resources.m15_1+";"+"4",
        //        Properties.Resources.m15_2+";"+"22",
        //        Properties.Resources.m15_3+";"+"63",
        //        Properties.Resources.m15_4+";"+"75",
        //        Properties.Resources.m15_5+";"+"88",
        //        Properties.Resources.m15_6+";"+"97",
        //        Properties.Resources.m15_7+";"+"105",
        //        Properties.Resources.m15_8+";"+"112",
        //        Properties.Resources.m15_9+";"+"117",
        //        Properties.Resources.m15_10+";"+"123",
        //        Properties.Resources.m15_11+";"+"134"



        //    });
        //        dictionary.Add("_16", new string[] {
        //        Properties.Resources.m15_1+";"+"4",
        //        Properties.Resources.m15_2+";"+"22",
        //        Properties.Resources.m15_3+";"+"62",
        //        Properties.Resources.m15_4+";"+"74",
        //        Properties.Resources.m15_5+";"+"85",
        //        Properties.Resources.m15_6+";"+"95",
        //        Properties.Resources.m15_7+";"+"103",
        //        Properties.Resources.m15_8+";"+"109",
        //        Properties.Resources.m15_9+";"+"114",
        //        Properties.Resources.m15_10+";"+"120",
        //        Properties.Resources.m15_11+";"+"135"



        //    });
        //        dictionary.Add("_17", new string[] {
        //        Properties.Resources.m15_1+";"+"4",
        //        Properties.Resources.m15_2+";"+"21",
        //        Properties.Resources.m15_3+";"+"61",
        //        Properties.Resources.m15_4+";"+"73",
        //        Properties.Resources.m15_5+";"+"86",
        //        Properties.Resources.m15_6+";"+"97",
        //        Properties.Resources.m15_7+";"+"103",
        //        Properties.Resources.m15_8+";"+"109",
        //        Properties.Resources.m15_9+";"+"114",
        //        Properties.Resources.m15_10+";"+"120",
        //        Properties.Resources.m15_11+";"+"129"



        //    });
        //        dictionary.Add("_18", new string[] {
        //        Properties.Resources.m15_1+";"+"4",
        //        Properties.Resources.m15_2+";"+"21",
        //        Properties.Resources.m15_3+";"+"61",
        //        Properties.Resources.m15_4+";"+"73",
        //        Properties.Resources.m15_5+";"+"83",
        //        Properties.Resources.m15_6+";"+"95",
        //        Properties.Resources.m15_7+";"+"102",
        //        Properties.Resources.m15_8+";"+"109",
        //        Properties.Resources.m15_9+";"+"114",
        //        Properties.Resources.m15_10+";"+"121",
        //        Properties.Resources.m15_11+";"+"132"



        //    });

                
        //        return dictionary;
        //    });
    }
}