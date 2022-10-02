﻿using VAICOM.Client;
using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Products
    {

        public class DCSmodule
        {
            public string Id;
            public string Name;
            public string Alias;
            public string SpeechAlias;
            public int radiodelay;
            public int chnoffset;
            public bool ProOnly;
            public bool IsFC;
            public bool ApxWpn;
            public bool ApxDir;
            public bool IsHelo;
            public bool Singlehotkey;
            public bool Havedial;
            public string Theme;
            public List<int> Flightmenu;

            public DCSmodule()
            {
                chnoffset = 1;
                radiodelay = 0;
            }
        }

        public static class DCSmodules
        {
            public static DCSmodule findmodulebyid(string id)
            {
                DCSmodule result = null;

                foreach (KeyValuePair<string,DCSmodule> entry in LookupTable)
                {
                    if (id.ToLower().Contains(entry.Value.Id.ToLower()))
                    {
                        result = entry.Value;
                        break;
                    }
                }

                return result;
            }


            public static Dictionary<string, DCSmodule> LookupTable = new Dictionary<string, DCSmodule>(StringComparer.OrdinalIgnoreCase)
            {

                {"----",    new DCSmodule() { Id ="----", Name = "----",    Alias = "----",         ProOnly = true,  IsFC = false, ApxWpn = false,ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Default",   SpeechAlias = "" } }, 
            
                // FREE
                {"A-10A" ,  new DCSmodule() { Id ="A-10A",Name = "A-10A",   Alias = "Warthog",       ProOnly = false, IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "RedFlag",   SpeechAlias = "A..Ten A"  } },
                {"F-15C" ,  new DCSmodule() { Id ="F-15C",Name = "F-15C",   Alias = "Eagle",         ProOnly = false, IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "RedFlag",   SpeechAlias = "F..Fifteen C"  } },
                {"SU-25",   new DCSmodule() { Id ="Su-25",Name = "SU-25",   Alias = "Frogfoot",      ProOnly = false, IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Russia",    SpeechAlias = "Sue..Twenty Five"} },
                {"SU-25T",  new DCSmodule() { Id ="Su-25T",Name = "SU-25T",  Alias = "Frogfoot",     ProOnly = false, IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Russia",    SpeechAlias = "Sue..Twenty Five Tee"} },
                {"F-86F",   new DCSmodule() { Id ="F-86F Sabre",Name = "F-86F",   Alias = "Sabre",   ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true , Havedial = false, Theme = "RedFlag",   SpeechAlias = "F..Eighty Six"} },
                {"KA-50",   new DCSmodule() { Id ="Ka-50",Name = "KA-50",   Alias = "BlackShark",    ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true,  Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true , Havedial = true,  Theme = "Russia",    SpeechAlias = "Black Shark" } },
                {"Mi-8MT",  new DCSmodule() { Id ="Mi-8MT",Name = "Mi-8MT",  Alias = "Magificent8",  ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true,  Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true , Havedial = true,  Theme = "Russia",    SpeechAlias = "M..Eye Eight" } },
                {"UH-1H",   new DCSmodule() { Id ="UH-1H",Name = "UH-1H",   Alias = "Huey",          ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true,  Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true , Havedial = true,  Theme = "RedFlag",   SpeechAlias = "Huey"} },
                {"A-10C" ,  new DCSmodule() { Id ="A-10C",Name = "A-10C",   Alias = "Warthog",       ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = true,   IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = false, Havedial = false, Theme = "RedFlag",   SpeechAlias = "A..Ten Cee" } },
                {"TF-51D",  new DCSmodule() { Id ="TF-51D",Name = "TF-51D",  Alias = "Mustang",      ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true , Havedial = false, Theme = "WWII",      SpeechAlias = "Tee..F Fifty One"} },
                {"MiG-15Bis",new DCSmodule(){ Id ="MiG-15Bis",Name ="MiG-15Bis",Alias = "Fagot",     ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = false, Theme = "Russia",    SpeechAlias = "Mig..Fifteen" } },
                {"Su-27",   new DCSmodule() { Id ="Su-27",Name = "Su-27",   Alias = "Flanker",       ProOnly = false, IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Russia",    SpeechAlias = "Sue..Twenty Seven" } },
                {"Hawk",    new DCSmodule() { Id ="Hawk",Name = "T.1A",    Alias = "Hawk",           ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "NATO",      SpeechAlias = "Hawk"  } },
                {"M-2000C", new DCSmodule() { Id ="M-2000C",Name = "M-2000C", Alias = "Mirage",      ProOnly = false, IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "RedFlag",   SpeechAlias = "Mirage Two Thousand C"} },          
            
                // PRO
                {"CA",      new DCSmodule() { Id ="artillery_commander",Name = "CA",      Alias = "Combined Arms",ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = false, Theme = "RedFlag",   SpeechAlias = "CA"  } },
                {"FA-18C" , new DCSmodule() { Id ="FA-18C_hornet",Name = "FA-18C",  Alias = "Hornet",       ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Navy",      SpeechAlias = "F A Eighteen C", radiodelay =0  } },
                {"F-14AB" , new DCSmodule() { Id ="F-14", Name = "F-14AB",  Alias = "Tomcat",       ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Navy",      SpeechAlias = "F Fourteen", radiodelay =500, chnoffset = 0  } },
                {"AJS-37",  new DCSmodule() { Id ="AJS37",Name = "AJS-37",  Alias = "Viggen",       ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = false, Havedial = false, Theme = "NATO",      SpeechAlias = "A S J Thirty Seven"  } },
                {"F-5E",    new DCSmodule() { Id ="F-5E-3",Name = "F-5E",    Alias = "Tiger II",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = false, Theme = "RedFlag",   SpeechAlias = "F Five E"  } },
                {"P-51D",   new DCSmodule() { Id ="P-51D",Name = "P-51D",   Alias = "Mustang",      ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true , Havedial = false, Theme = "WWII",      SpeechAlias = "Pee Fifty One" } },
                {"Spitfire",new DCSmodule() { Id ="SpitfireLFMkIX",Name = "Spitfire",Alias = "LFMkIX",       ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true , Havedial = false, Theme = "WWII",      SpeechAlias = "Spitfire" } },
                {"C-101",   new DCSmodule() { Id ="C-101",Name = "C-101",   Alias = "Aviojet",      ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true , Havedial = false, Theme = "NATO",      SpeechAlias = "C One Oh One" } },
                {"Bf-109",  new DCSmodule() { Id ="Bf-109K-4",Name ="Bf-109K-4",Alias = "Kurfurst",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "WWII",      SpeechAlias = "B F One Oh Nine" } },
                {"Fw-190",  new DCSmodule() { Id ="FW-190D9",Name = "FW-190D9",Alias = "Dora",         ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "WWII",      SpeechAlias = "Focke Wulf One Ninety" } },
                {"Su-33",   new DCSmodule() { Id ="Su-33",Name = "Su-33",   Alias = "Flanker-D",    ProOnly = true,  IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Russia",    SpeechAlias = "Sue Thirty Three"  } },
                {"MiG-21Bis",new DCSmodule(){ Id ="MiG-21Bis",Name ="MiG-21Bis",Alias = "Fishbed",      ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = false, Theme = "Russia",    SpeechAlias = "Mig Twenty One" } },
                {"L-39ZA",  new DCSmodule() { Id ="L-39ZA",Name = "L-39ZA",  Alias = "Albatros",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = false, Theme = "NATO",      SpeechAlias = "Albatros"   } },
                {"L-39C",   new DCSmodule() { Id ="L-39C",Name = "L-39C",   Alias = "Albatros",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = false, Theme = "NATO",      SpeechAlias = "Albatros"   } },
                {"SA342M",  new DCSmodule() { Id ="SA342M",Name = "SA342M",  Alias = "Gazelle",      ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true,  Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = true,  Theme = "RedFlag",   SpeechAlias = "Gazelle"  } },
                {"SA342L",  new DCSmodule() { Id ="SA342L",Name = "SA342L",  Alias = "Gazelle",      ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true,  Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = true,  Havedial = true,  Theme = "RedFlag",   SpeechAlias = "Gazelle"   } },
                {"MiG-29" , new DCSmodule() { Id ="MiG-29",Name = "MiG-29",  Alias = "Fulcrum",      ProOnly = true,  IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Russia",    SpeechAlias = "Mig Twenty Nine"} },
                {"J-11A" ,  new DCSmodule() { Id ="J-11A",Name = "J-11A",   Alias = "Shenyang",      ProOnly = true,  IsFC = true,  ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Russia",    SpeechAlias = "Jay Eleven"} },
                {"AV-8B",   new DCSmodule() { Id ="AV8BNA",Name = "AV-8BNA", Alias = "Harrier",      ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false, Havedial = false, Theme = "Navy",      SpeechAlias = "Harrier"  } },
                {"F-16C_50",new DCSmodule() { Id ="F-16C_50",Name = "F-16C",  Alias = "Viper",       ProOnly = true,  IsFC = false, ApxWpn = false, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight1 ,Singlehotkey = false,  Havedial = false, Theme = "NATO",    SpeechAlias = "Viper"  } },
                {"Yak-52",  new DCSmodule() { Id ="Yak-52",Name = "Yak-52",  Alias = "",             ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "Russia",    SpeechAlias = "Yak Fifty Two"  } },
                {"Mi-24P",  new DCSmodule() { Id ="Mi-24P",Name = "Mi-24P",  Alias = "Hind",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = true, Theme = "Russia",    SpeechAlias = "Hind"  } },
                {"AH-64D",  new DCSmodule() { Id ="AH-64D",Name = "AH-64D",  Alias = "Apache",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = true, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = true, Theme = "NATO",    SpeechAlias = "Apache"  } },
                {"Mosquito",  new DCSmodule() { Id ="MosquitoFBMkVI",Name = "Mosquito",  Alias = "",     ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "WWII",    SpeechAlias = "Mosquito"  } },
                {"MiG-19P",  new DCSmodule() { Id ="MiG-19P", Name = "MiG-19P",  Alias = "Farmer", ProOnly = true,  IsFC = false, ApxWpn = false, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "Russia",    SpeechAlias = "Mig..Nineteen"  } },
                {"JF-17",  new DCSmodule() { Id ="JF-17", Name = "JF-17",  Alias = "Thunder", ProOnly = true,  IsFC = false, ApxWpn = false, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "Russia",    SpeechAlias = "J F Seventeen"  } },
                {"I-16",  new DCSmodule() { Id ="I-16", Name = "I-16",  Alias = "",  ProOnly = true, IsFC = false, ApxWpn = false, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "Russia",    SpeechAlias = "Eye Sixteen"  } },
                {"Fw-190A8", new DCSmodule() { Id ="FW-190A8",Name = "FW-190A8", Alias = "Anton", ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "WWII",      SpeechAlias = "Focke Wulf One Ninety Anton" } },
                {"P-47D",  new DCSmodule() { Id ="P-47D",Name = "P-47D", Alias = "Thunderbolt", ProOnly = true,  IsFC = false, ApxWpn = true, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "WWII",      SpeechAlias = "Pee Forty Seven" } },
                {"CE-2",  new DCSmodule() { Id ="CE-2", Name = "Christen",  Alias = "Eagle II", ProOnly = true,  IsFC = false, ApxWpn = false, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "RedFlag",    SpeechAlias = "Christen Eagle"  } },

                // community
                {"A-4E-C",  new DCSmodule() { Id ="A-4E-C",Name = "A-4", Alias = "Skyhawk", ProOnly = true,  IsFC = true, ApxWpn = false, ApxDir = false,  IsHelo = false, Flightmenu = DcsClient.iCommandsequences.showflight2 ,Singlehotkey = true,  Havedial = false, Theme = "RedFlag",      SpeechAlias = "Sky Hawk" } },


            };
        }
    }
}
