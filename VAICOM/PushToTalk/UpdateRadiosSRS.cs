﻿using VAICOM.Static;
using VAICOM.Servers;
using VAICOM.Products;
using System.Collections.Generic;
using System;

namespace VAICOM
{

    namespace PushToTalk
    {

        public partial class PTT
        {

            public class radioslotlist
            {
                public List<string> Slot_map = new List<string>();
            }

            public class radioslotdevicelist
            {  
                public List<int> Slot_map_INT = new List<int>();
                public List<int> Slot_map_SRS = new List<int>();
                public List<int> Slot_map_CUS = new List<int>();
            }

            public static class maps
            {
                //not used for now
                public static Dictionary<string, radioslotdevicelist> slot_mapping_table = new Dictionary<string, radioslotdevicelist>()
                {
                    {"----" ,       new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } }, 
                    
                    //FREE
                    {"A-10A" ,      new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-15C" ,      new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Su-25" ,      new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Su-25T" ,     new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-86F Sabre" ,new radioslotdevicelist() { Slot_map_INT = {0,26,0}, Slot_map_SRS = {26,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Ka-50" ,      new radioslotdevicelist() { Slot_map_INT = {48,49,0}, Slot_map_SRS = {48,49,0}, Slot_map_CUS = {0,0,0} } },
                    {"Mi-8MT" ,     new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"UH-1H" ,      new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"A-10C" ,      new radioslotdevicelist() { Slot_map_INT = {55,54,56}, Slot_map_SRS = {55,54,56}, Slot_map_CUS = {0,0,0} } },
                    {"TF-51D" ,     new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"MiG-15Bis" ,  new radioslotdevicelist() { Slot_map_INT = {0,30,0}, Slot_map_SRS = {30,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Su-27" ,      new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Hawk" ,       new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"M-2000C" ,    new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },

                    //PRO
                    {"artillery_commander", new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"FA-18C_hornet",       new radioslotdevicelist() { Slot_map_INT = {38,39,0}, Slot_map_SRS = {38,39,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-14" ,               new radioslotdevicelist() { Slot_map_INT = {3,4,0}, Slot_map_SRS = {3,4,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-14A" ,              new radioslotdevicelist() { Slot_map_INT = {4,4,0}, Slot_map_SRS = {3,4,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-14B" ,              new radioslotdevicelist() { Slot_map_INT = {3,4,0}, Slot_map_SRS = {3,4,0}, Slot_map_CUS = {0,0,0} } },
                    {"AJS37" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-5E-3" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"P-51D" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"SpitfireLFMkIX",      new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"C-101" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Bf-109K-4" ,          new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"FW-190D9" ,           new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Su-33" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"MiG-21Bis" ,          new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"L-39ZA" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"L-39C" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"SA342M" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"SA342L" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"MiG-29" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"J-11A" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"AV8BNA" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"F-16C_50" ,           new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Yak-52" ,             new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },

                    {"MiG-19P" ,            new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"JF-17" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"I-16" ,               new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"Fw-190A8" ,           new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"P-47D" ,              new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },
                    {"CE-2" ,               new radioslotdevicelist() { Slot_map_INT = {0,0,0}, Slot_map_SRS = {0,0,0}, Slot_map_CUS = {0,0,0} } },

                };

                public static Dictionary<string, radioslotlist> mapping_Ref = new Dictionary<string, radioslotlist>()
                {
                    {"----" , new radioslotlist() { Slot_map = {"VHF AM","UHF","VHF FM"} } },

                    //FREE
                    {"A-10A" ,      new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"F-15C" ,      new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"Su-25" ,      new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"Su-25T" ,     new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"F-86F Sabre" ,new radioslotlist() { Slot_map = { "AN/ARC-27", "", "" } } },
                    {"Ka-50" ,      new radioslotlist() { Slot_map = { "R-800", "R-828", "" } } },
                    {"Mi-8MT" ,     new radioslotlist() { Slot_map = { "R-863", "JADRO-1A", "R-828" } } },
                    {"UH-1H" ,      new radioslotlist() { Slot_map = { "VHF FM", "CB UHF", "VHF AM"  } } },
                    {"A-10C" ,      new radioslotlist() { Slot_map = { "VHF AM", "CB UHF", "VHF FM" } } },
                    {"TF-51D" ,     new radioslotlist() { Slot_map = { "SCR522A", "", "" } } },
                    {"MiG-15Bis" ,  new radioslotlist() { Slot_map = { "RSI-6K", "", "" } } },
                    {"Su-27" ,      new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"Hawk" ,       new radioslotlist() { Slot_map = { "VHF", "UHF", ""} } },
                    {"M-2000C" ,    new radioslotlist() { Slot_map = { "VHF", "UHF", ""} } },

                    //PRO
                    {"artillery_commander",new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"FA-18C_hornet", new radioslotlist() { Slot_map = { "COMM1: ARC-210", "COMM2: ARC-210", ""} } },
                    {"F-14" ,       new radioslotlist() { Slot_map = { "UHF ARC-159", "VHF/UHF ARC-182", "" } } },
                    {"F-14A" ,       new radioslotlist() { Slot_map = { "UHF ARC-159", "VHF/UHF ARC-182", "" } } },
                    {"F-14B" ,       new radioslotlist() { Slot_map = { "UHF ARC-159", "VHF/UHF ARC-182", "" } } },
                    {"AJS37" ,      new radioslotlist() { Slot_map = { "AM Radio", "AM Radio", "" } } },
                    {"F-5E-3" ,     new radioslotlist() { Slot_map = { "UHF Radio AN/ARC-164", "", "" } } },
                    {"P-51D" ,      new radioslotlist() { Slot_map = { "SCR522A", "", "" } } },
                    {"SpitfireLFMkIX",new radioslotlist() { Slot_map = { "SCR522A", "", "" } } },
                    {"C-101" ,      new radioslotlist() { Slot_map = { "CB UHF", "CB VHF", ""} } },
                    {"Bf-109K-4" ,  new radioslotlist() { Slot_map = { "FuG16ZY", "", "" } } },
                    {"FW-190D9" ,   new radioslotlist() { Slot_map = { "FuG165ZY", "", "" } } },
                    {"Su-33" ,      new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"MiG-21Bis" ,  new radioslotlist() { Slot_map = { "R-828", "", "" } } },
                    {"L-39ZA" ,     new radioslotlist() { Slot_map = { "R-832M", "", "" } } },
                    {"L-39C" ,      new radioslotlist() { Slot_map = { "R-832M", "", "" } } },
                    {"SA342M" ,     new radioslotlist() { Slot_map = { "VHF AM", "UHF AM", "VHF FM" } } },
                    {"SA342L" ,     new radioslotlist() { Slot_map = { "VHF AM", "UHF AM", "VHF FM" } } },
                    {"MiG-29" ,     new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"J-11A" ,      new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"AV8BNA" ,     new radioslotlist() { Slot_map = { "COMM1", "COMM2", ""} } },
                    {"F-16C_50" ,   new radioslotlist() { Slot_map = { "UHF Radio AN/ARC-164", "VHF Radio AN/ARC-222", "" } } },
                    {"Yak-52" ,     new radioslotlist() { Slot_map = { "Baklan-5", "", "" } } },

                    {"Mi-24P" ,     new radioslotlist() { Slot_map = { "R_852", "Jadro-1A", "R-828" } } },
                    {"AH-64D" ,     new radioslotlist() { Slot_map = { "VHF AM", "UHF", "VHF FM" } } },
                    {"MiG-19P" ,    new radioslotlist() { Slot_map = { "RSIU-4V", "", "" } } },
                    {"JF-17" ,      new radioslotlist() { Slot_map = { "COMM1", "COMM2", "" } } },
                    {"I-16" ,       new radioslotlist() { Slot_map = { "Baklan 5", "", "" } } },
                    {"MosquitoFBMkVI" ,   new radioslotlist() { Slot_map = { "T.1154N", "SCR522A", "" } } },
                    {"Fw-190A8" ,   new radioslotlist() { Slot_map = { "FuG165ZY", "", "" } } },
                    {"P-47D" ,      new radioslotlist() { Slot_map = { "SCR522", "", "" } } },
                    {"CE-2" ,       new radioslotlist() { Slot_map = { "KY-197A", "", "" } } },
                    {"A-4E-C" ,     new radioslotlist() { Slot_map = { "AN/ARC-51BX", "", "" } } },

                };

                public static Dictionary<string, radioslotlist> mapping_SRS = new Dictionary<string, radioslotlist>()
                {
                    {"----" , new radioslotlist() { Slot_map = {"SRS 1", "SRS 2", "SRS 3" } } },

                    //FREE
                    {"A-10A" ,      new radioslotlist() { Slot_map = { "AN/ARC-186(V)", "AN/ARC-164 UHF", "AN/ARC-186(V)FM" } } },
                    {"F-15C" ,      new radioslotlist() { Slot_map = { "AN/ARC-164 UHF 1", "AN/ARC-164 UHF 2", "[AN/ARC-186(V)]" } } },
                    {"Su-25" ,      new radioslotlist() { Slot_map = { "R-862", "R-828", "[AN/ARC-164 UHF]" } } },
                    {"Su-25T" ,     new radioslotlist() { Slot_map = { "R-862", "R-828", "[AN/ARC-164 UHF]" } } },
                    {"F-86F Sabre" ,new radioslotlist() { Slot_map = { "AN/ARC-27", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"Ka-50" ,      new radioslotlist() { Slot_map = { "R-800L14 VHF/UHF", "R-828", "[SPU-9 SW]" } } },
                    {"Mi-8MT" ,     new radioslotlist() { Slot_map = { "R-863", "JADRO-1A", "R-828" } } },
                    {"UH-1H" ,      new radioslotlist() { Slot_map = { "AN/ARC-131", "AN/ARC-51BX - UHF", "AN/ARC-134",  } } },
                    {"A-10C" ,      new radioslotlist() { Slot_map = { "AN/ARC-186(V)", "AN/ARC-164 UHF", "AN/ARC-186(V)FM" } } },
                    {"TF-51D" ,     new radioslotlist() { Slot_map = { "SCR522A", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"MiG-15Bis" ,  new radioslotlist() { Slot_map = { "RSI-6K", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"Su-27" ,      new radioslotlist() { Slot_map = { "R-800", "R-864", "[AN/ARC-164 UHF]" } } },
                    {"Hawk" ,       new radioslotlist() { Slot_map = { "AN/ARC-164 UHF", "ARI 23259/1", ""} } },
                    {"M-2000C" ,    new radioslotlist() { Slot_map = { "TRT ERA 7000 (V/UHF)", "TRT ERA 7200 UHF", ""} } },

                    //PRO
                    {"artillery_commander",new radioslotlist() { Slot_map = { "CA UHF/VHF", "CA UHF/VHF", "CA FM" } } },
                    {"FA-18C_hornet", new radioslotlist() { Slot_map = {"AN/ARC-210 - 1", "AN/ARC-210 - 2", ""} } },
                    {"F-14" ,       new radioslotlist() { Slot_map = { "AN/ARC-159(V)", "AN/ARC-182(V)","" } } },
                    {"F-14A" ,       new radioslotlist() { Slot_map = { "AN/ARC-159(V)", "AN/ARC-182(V)","" } } },
                    {"F-14B" ,       new radioslotlist() { Slot_map = { "AN/ARC-159(V)", "AN/ARC-182(V)","" } } },
                    {"AJS37" ,      new radioslotlist() { Slot_map = { "FR 22", "FR 24", "[AN/ARC-164 UHF]" } } },
                    {"F-5E-3" ,     new radioslotlist() { Slot_map = { "AN/ARC-164", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"P-51D" ,      new radioslotlist() { Slot_map = { "SCR522A", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"SpitfireLFMkIX",new radioslotlist() { Slot_map = { "A.R.I. 1063", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"C-101" ,      new radioslotlist() { Slot_map = { "AN/ARC-164 UHF", "AN/ARC-134", ""} } },
                    {"Bf-109K-4" ,  new radioslotlist() { Slot_map = { "FuG 16ZY", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"FW-190D9" ,   new radioslotlist() { Slot_map = { "FuG 16ZY", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"Su-33" ,      new radioslotlist() { Slot_map = { "R-800", "R-864", "[AN/ARC-164 UHF]" } } },
                    {"MiG-21Bis" ,  new radioslotlist() { Slot_map = { "R-832", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"L-39ZA" ,     new radioslotlist() { Slot_map = { "R-832M", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"L-39C" ,      new radioslotlist() { Slot_map = { "R-832M", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"SA342M" ,     new radioslotlist() { Slot_map = { "TRAP 138A", "UHF TRA 6031", "TRC 9600 PR4G" } } },
                    {"SA342L" ,     new radioslotlist() { Slot_map = { "TRAP 138A", "UHF TRA 6031", "TRC 9600 PR4G" } } },
                    {"MiG-29" ,     new radioslotlist() { Slot_map = { "R-862", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"J-11A" ,      new radioslotlist() { Slot_map = { "R-862", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"AV8BNA" ,     new radioslotlist() { Slot_map = {"ARC-210 COM 1", "ARC-210 COM 2", ""} } },
                    {"F-16C_50" ,   new radioslotlist() { Slot_map = { "AN/ARC-164", "AN/ARC-222", "" } } },
                    {"Yak-52" ,     new radioslotlist() { Slot_map = {"Baklan 5", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },

                    {"Mi-24P" ,     new radioslotlist() { Slot_map = { "R_852", "Jadro-1A", "R-828" } } },
                    {"AH-64D" ,     new radioslotlist() { Slot_map = { "SRS Radio 1", "SRS Radio 2", "SRS Radio 3" } } },
                    {"MiG-19P" ,    new radioslotlist() { Slot_map = { "RSIU-4V", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"JF-17" ,      new radioslotlist() { Slot_map = { "COMM1 VHF Radio", "COMM2 UHF Radio", "[VHF/UHF Expansion]" } } },
                    {"I-16" ,       new radioslotlist() { Slot_map = { "SRS Radio 1", "SRS Radio 2", "SRS Radio 3" } } },
                    {"MosquitoFBMkVI" ,   new radioslotlist() { Slot_map = { "SCR522A", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"Fw-190A8" ,   new radioslotlist() { Slot_map = { "FuG 16ZY", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"P-47D" ,      new radioslotlist() { Slot_map = { "SCR522", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"CE-2" ,       new radioslotlist() { Slot_map = { "KY-197A", "[AN/ARC-186(V)]", "[AN/ARC-164 UHF]" } } },
                    {"A-4E-C" ,     new radioslotlist() { Slot_map = { "AN/ARC-51BX", "[AN/ARC-186(V)]", "[AN/ARC-186(V)FM]" } } },
                };
            }


            public static void PTT_SetConfigMulti_SRS()
            {

                try
                {

                    PTT_ResetConfig();

                    if (State.currentstate.radios == null || State.currentstate.radios.Count.Equals(0)) // FC3
                    {

                        PTT_TXAssignmentDefault();

                        DCSmodule module = null;

                        if (!State.currentstate.id.Equals(null))
                        {
                            module = DCSmodules.findmodulebyid(State.currentstate.id);
                        }

                        if (module.Equals(null))
                        {
                            module = DCSmodules.LookupTable["----"];
                        }

                        radioslotlist radiolist_Def = maps.mapping_Ref[module.Id];
                        radioslotlist radiolist_SRS = maps.mapping_SRS[module.Id];

                        //TX1
                        TXNodes.TX1.radios[0].name = radiolist_SRS.Slot_map[0];
                        if (TXNodes.TX1.radios[0].name.Equals(""))
                        {
                            TXNodes.TX1.enabled = false;
                        }
                        if (TXNodes.TX1.radios[0].name.Contains("[") && TXNodes.TX1.radios[0].name.Contains("]"))
                        {
                            TXNodes.TX1.radios[0].name = TXNodes.TX1.radios[0].name.TrimStart('[').TrimEnd(']');
                            TXNodes.TX1.radios[0].isSRSserver = true;
                        }

                        //TX2
                        TXNodes.TX2.radios[0].name = radiolist_SRS.Slot_map[1];
                        if (TXNodes.TX2.radios[0].name.Equals(""))
                        {
                            TXNodes.TX2.enabled = false;
                        }
                        if (TXNodes.TX2.radios[0].name.Contains("[") && TXNodes.TX2.radios[0].name.Contains("]"))
                        {
                            TXNodes.TX2.radios[0].name = TXNodes.TX2.radios[0].name.TrimStart('[').TrimEnd(']');
                            TXNodes.TX2.radios[0].isSRSserver = true;
                        }

                        //TX3
                        TXNodes.TX3.radios[0].name = radiolist_SRS.Slot_map[2];
                        if (TXNodes.TX3.radios[0].name.Equals(""))
                        {
                            TXNodes.TX3.enabled = false;
                        }
                        if (TXNodes.TX3.radios[0].name.Contains("[") && TXNodes.TX3.radios[0].name.Contains("]"))
                        {
                            TXNodes.TX3.radios[0].name = TXNodes.TX3.radios[0].name.TrimStart('[').TrimEnd(']');
                            TXNodes.TX3.radios[0].isSRSserver = true;
                        }

                        State.radiocount = 3;
                        TXNodes.TX4.enabled = State.currentstate.easycomms;

                        return;
                    }
                    else // non-FC3
                    {

                        bool allocatedRadio1    = false;
                        bool allocatedRadio2    = false;
                        bool allocatedRadio3    = false;
                        bool allocatedINT       = false;

                        DCSmodule module = null;

                        if (!State.currentstate.id.Equals(null))
                        {
                            module = DCSmodules.findmodulebyid(State.currentstate.id);
                        }

                        if (module.Equals(null))
                        {
                            module = DCSmodules.LookupTable["----"];
                        }

                        radioslotlist radiolist_Ref = maps.mapping_Ref[module.Id];
                        radioslotlist radiolist_SRS = maps.mapping_SRS[module.Id];

                        State.radiocount = 0;

                        foreach (Server.RadioDevice radiounit in State.currentstate.radios)
                        {

                            bool deviceallocated = false;

                            // Interphone -> TX5
                            if (!deviceallocated & !allocatedINT & radiounit.intercom)
                            {
                                TXNodes.TX5.enabled = true;
                                TXNodes.TX5.number = radiounit.deviceid;
                                TXNodes.TX5.radios = TXConfigs.SNGL_RADIO_INT;

                                RadioDevices.INT.isavailable = radiounit.isavailable;
                                RadioDevices.INT.deviceid = radiounit.deviceid;
                                RadioDevices.INT.name = radiounit.displayName;
                                RadioDevices.INT.intercom = radiounit.intercom;
                                RadioDevices.INT.AM = radiounit.AM;
                                RadioDevices.INT.FM = radiounit.FM;
                                RadioDevices.INT.on = radiounit.on;
                                RadioDevices.INT.frequency = radiounit.frequency.ToString(); 
                                RadioDevices.INT.modulation = radiounit.modulation;

                                deviceallocated = true;
                                allocatedINT = true;
                                // int is not part of radio count
                            }

                            // TX1 
                            if (!deviceallocated && radiounit.displayName.ToLower().Equals(radiolist_Ref.Slot_map[0].ToLower()))
                            {

                                TXNodes.TX1.enabled = true;
                                TXNodes.TX1.number  = radiounit.deviceid;
                                TXNodes.TX1.radios  = TXConfigs.SNGL_RADIO_Radio1;

                                RadioDevices.Radio1.isavailable = radiounit.isavailable;
                                RadioDevices.Radio1.deviceid    = radiounit.deviceid;
                                RadioDevices.Radio1.name        = radiolist_SRS.Slot_map[0];
                                RadioDevices.Radio1.intercom    = radiounit.intercom;
                                RadioDevices.Radio1.AM          = radiounit.AM;
                                RadioDevices.Radio1.FM          = radiounit.FM;
                                RadioDevices.Radio1.on          = radiounit.on;
                                RadioDevices.Radio1.frequency   = radiounit.frequency.ToString(); 
                                RadioDevices.Radio1.modulation  = radiounit.modulation;

                                RadioDevices.Radio1.isSRSserver = false;

                                deviceallocated = true;
                                allocatedRadio1 = true;
                                State.radiocount = State.radiocount + 1;
                            }


                            // TX2
                            if (!deviceallocated && radiounit.displayName.ToLower().Equals(radiolist_Ref.Slot_map[1].ToLower()))
                            {

                                TXNodes.TX2.enabled = true;
                                TXNodes.TX2.number  = radiounit.deviceid;
                                TXNodes.TX2.radios  = TXConfigs.SNGL_RADIO_Radio2;

                                RadioDevices.Radio2.isavailable     = radiounit.isavailable;
                                RadioDevices.Radio2.deviceid        = radiounit.deviceid;
                                RadioDevices.Radio2.name            = radiolist_SRS.Slot_map[1];
                                RadioDevices.Radio2.intercom        = radiounit.intercom;
                                RadioDevices.Radio2.AM              = radiounit.AM;
                                RadioDevices.Radio2.FM              = radiounit.FM;
                                RadioDevices.Radio2.on              = radiounit.on;
                                RadioDevices.Radio2.frequency       = radiounit.frequency.ToString(); 
                                RadioDevices.Radio2.modulation      = radiounit.modulation;

                                RadioDevices.Radio2.isSRSserver = false;

                                deviceallocated = true;
                                allocatedRadio2 = true;
                                State.radiocount = State.radiocount + 1;  
                            }


                            // TX3
                            if (!deviceallocated && radiounit.displayName.ToLower().Equals(radiolist_Ref.Slot_map[2].ToLower()))
                            {
                                TXNodes.TX3.enabled = true;
                                TXNodes.TX3.number  = radiounit.deviceid;
                                TXNodes.TX3.radios  = TXConfigs.SNGL_RADIO_Radio3;

                                RadioDevices.Radio3.isavailable = radiounit.isavailable;
                                RadioDevices.Radio3.deviceid    = radiounit.deviceid;
                                RadioDevices.Radio3.name        = radiolist_SRS.Slot_map[2]; 
                                RadioDevices.Radio3.intercom    = radiounit.intercom;
                                RadioDevices.Radio3.AM          = radiounit.AM;
                                RadioDevices.Radio3.FM          = radiounit.FM;
                                RadioDevices.Radio3.on          = radiounit.on;
                                RadioDevices.Radio3.frequency   = radiounit.frequency.ToString();
                                RadioDevices.Radio3.modulation  = radiounit.modulation;

                                RadioDevices.Radio3.isSRSserver = false;

                                deviceallocated = true;
                                allocatedRadio3 = true;
                                State.radiocount = State.radiocount + 1;
                            }

                        }

                        if (!allocatedRadio1)
                        {
                            TXNodes.TX1.radios = TXConfigs.SNGL_RADIO_Radio1;
                            TXNodes.TX1.radios[0].name = radiolist_SRS.Slot_map[0];          
                            TXNodes.TX1.enabled = true;
                            if (TXNodes.TX1.radios[0].name.Equals(""))
                            {
                                TXNodes.TX1.enabled = false;
                            }
                            if (TXNodes.TX1.radios[0].name.Contains("[") && TXNodes.TX1.radios[0].name.Contains("]"))
                            {
                                TXNodes.TX1.radios[0].name = TXNodes.TX1.radios[0].name.TrimStart('[').TrimEnd(']');
                                TXNodes.TX1.radios[0].isSRSserver = true;
                            }
                            allocatedRadio1 = true;
                        }

                        if (!allocatedRadio2)
                        {
                            TXNodes.TX2.radios = TXConfigs.SNGL_RADIO_Radio2;
                            TXNodes.TX2.radios[0].name = radiolist_SRS.Slot_map[1];            
                            TXNodes.TX2.enabled = true;
                            if (TXNodes.TX2.radios[0].name.Equals(""))
                            {
                                TXNodes.TX2.enabled = false;
                            }
                            if (TXNodes.TX2.radios[0].name.Contains("[") && TXNodes.TX2.radios[0].name.Contains("]"))
                            {
                                TXNodes.TX2.radios[0].name = TXNodes.TX2.radios[0].name.TrimStart('[').TrimEnd(']');
                                TXNodes.TX2.radios[0].isSRSserver = true;
                            }
                            allocatedRadio2 = true;
                        }

                        if (!allocatedRadio3)
                        {
                            TXNodes.TX3.radios = TXConfigs.SNGL_RADIO_Radio3;
                            TXNodes.TX3.radios[0].name = radiolist_SRS.Slot_map[2];         
                            TXNodes.TX3.enabled = true;
                            if (TXNodes.TX3.radios[0].name.Equals(""))
                            {
                                TXNodes.TX3.enabled = false;
                            }
                            if (TXNodes.TX3.radios[0].name.Contains("[") && TXNodes.TX3.radios[0].name.Contains("]"))
                            {
                                TXNodes.TX3.radios[0].name = TXNodes.TX3.radios[0].name.TrimStart('[').TrimEnd(']');
                                TXNodes.TX3.radios[0].isSRSserver = true;
                            }
                            allocatedRadio3 = true;
                        }

                        // TX4
                        TXNodes.TX4.radios = TXConfigs.ALL_RADIOS_AUTO;
                        TXNodes.TX4.enabled = State.currentstate.easycomms;

                        //TX6
                        TXNodes.TX6.radios = TXConfigs.SNGL_RADIO_AUX;
                        TXNodes.TX6.enabled = true;

                    }
                }
                catch (Exception e)
                {
                    Log.Write("SRS mapping: " + e.Message + e.StackTrace, Colors.Inline);
                }
            }

            public static void PTT_SetConfigSingle_SRS()
            {

                PTT_SetConfigMulti_SRS();

                TXNodes.TX1.enabled = false;
                TXNodes.TX2.enabled = false;
                TXNodes.TX3.enabled = false;
                TXNodes.TX4.enabled = false;
                TXNodes.TX5.enabled = false;
                TXNodes.TX6.enabled = false;

                switch (State.activeconfig.SingleHotkey)
                {
                    case "TX1":
                        TXNodes.TX1 = new TXNode() { name = "TX1", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                    case "TX2":
                        TXNodes.TX2 = new TXNode() { name = "TX2", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                    case "TX3":
                        TXNodes.TX3 = new TXNode() { name = "TX3", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                    case "TX4":
                        TXNodes.TX4 = new TXNode() { name = "TX4", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                    case "TX5":
                        TXNodes.TX5 = new TXNode() { name = "TX5", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                    case "TX6":
                        TXNodes.TX6 = new TXNode() { name = "TX6", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                    default:
                        TXNodes.TX1 = new TXNode() { name = "TX1", enabled = true, radios = TXConfigs.ALL_RADIOS_SEL };
                        break;
                }
            }

        }
    }
}
