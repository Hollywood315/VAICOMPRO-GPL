﻿using VAICOM.Static;
using VAICOM.Servers;
using System.Collections.Generic;
using System;
using System.IO;


namespace VAICOM
{
    namespace FileManager
    {

        public static partial class FileHandler
        {
            public static partial class Lua
            {

                public static void LuaFiles_Install_Kneeboard(bool restore, bool forcequiet)
                {

                    // install kneeboard for all DCS versions
                    foreach (KeyValuePair<string, string> set in Server.dcsfolders)
                    {

                        // paths for this DCS version
                        string dcsprogramfolder = "";
                        string SavedGamesFolder = "";

                        // ------ device_init ---------------------------------------------------------------------
                        // first, manipulate device_init files for all aircraft modules

                        try
                        {


                            string dcs_path = "NOT INSTALLED";

                            if (set.Key.Equals("2.5"))
                            {
                                dcs_path = State.dcspath_release;
                            }
                            if (set.Key.Equals("2.5 OpenBeta"))
                            {
                                dcs_path = State.dcspath_openbeta;
                            }
                            if (set.Key.Equals("STEAM"))
                            {
                                dcs_path = State.dcspath_steam;
                            }

                            string savedgames_path = Framework.SpecialFoldersRetrieve.GetSavedGames() + "\\" + Server.dcsversion[set.Key];

                            // set out of scope variables
                            dcsprogramfolder = dcs_path;
                            SavedGamesFolder = savedgames_path;

                            // ----------------------

                            string modsubfolder = "Mods\\aircraft";

                            string[] filesinrootdir = new string[0];

                            try
                            {
                                filesinrootdir = Directory.GetDirectories(dcs_path + "\\" + modsubfolder);
                            }
                            catch
                            {
                            }

                            string[] filesinsavedgames = new string[0];
                            try
                            {
                                filesinsavedgames = Directory.GetDirectories(savedgames_path + "\\" + modsubfolder);
                            }
                            catch
                            {
                            }

                            List<string> filepaths = new List<string>();
                            filepaths.AddRange(filesinrootdir);
                            filepaths.AddRange(filesinsavedgames);

                            string lookforfile = "device_init.lua";

                            List<string> initsubfolders = new List<string>();

                            initsubfolders.Add("Cockpit");
                            initsubfolders.Add("Cockpit\\Scripts");
                            initsubfolders.Add("Cockpit\\KneeboardLeft");
                            initsubfolders.Add("Cockpit\\KneeboardRight");
                            initsubfolders.Add("Cockpit\\C-101CC");
                            initsubfolders.Add("Cockpit\\C-101EB");
                            initsubfolders.Add("Cockpit\\A10A");

                            foreach (string subdir in filepaths) // both root and Saved Games
                            {

                                string initfile = "";

                                foreach (string deepsubdir in initsubfolders)
                                {
                                    string initpath = subdir + "\\" + deepsubdir;

                                    if (Directory.Exists(initpath) && File.Exists(initpath + "\\" + lookforfile))
                                    {
                                        initfile = initpath + "\\" + lookforfile;
                                    }

                                    if (!initfile.Equals(""))
                                    {

                                        try
                                        {
                                            // have init file for mod, append if needed.

                                            string matchstring = Properties.Resources.Append_Kneeboard_device_init;
                                            string modinitfilecontent = File.ReadAllText(initfile);

                                            int desiredentryoccurrences = 0;
                                            if (State.kneeboardactivated)
                                            {
                                                desiredentryoccurrences = 1;
                                            }

                                            if (restore)
                                            {
                                                desiredentryoccurrences = 0;
                                            }

                                            int matchoccurences = (modinitfilecontent.Length - modinitfilecontent.Replace(matchstring, "").Length) / matchstring.Length;

                                            if (matchoccurences < desiredentryoccurrences) //not enough, need to add fresh entry
                                            {
                                                string writestring = matchstring; //"\n" + 

                                                using (StreamWriter writer = new StreamWriter(initfile, true))
                                                {
                                                    writer.Write(writestring);
                                                }

                                                if (!forcequiet)
                                                {
                                                    Log.Write("   Reset: " + initfile, Colors.Inline);
                                                }
                                            }
                                            else
                                            {
                                                if (matchoccurences > desiredentryoccurrences) // need to do some repair here
                                                {
                                                    modinitfilecontent = modinitfilecontent.Replace(matchstring, ""); // rebuild

                                                    if (!restore)
                                                    {
                                                        modinitfilecontent = modinitfilecontent + "\n" + matchstring;
                                                    }

                                                    string writestring = modinitfilecontent;

                                                    using (StreamWriter writer = new StreamWriter(initfile, false))
                                                    {
                                                        writer.Write(writestring);
                                                    }

                                                    if (!forcequiet)
                                                    {
                                                        Log.Write("   Repaired: " + initfile, Colors.Inline);
                                                    }
                                                }
                                                else // ok, desired number of entry occurrences
                                                {
                                                    if (!forcequiet)
                                                    {
                                                        Log.Write("   Unchanged: " + initfile, Colors.Inline);
                                                    }
                                                }
                                            }

                                        }
                                        catch (Exception e)
                                        {
                                            Log.Write(e.Message +"\n" +e.StackTrace, Colors.Inline);
                                        }
                                    }

                                }
                            }
                        }
                        catch (Exception e)
                        {
                            if (!forcequiet)
                            {
                                Log.Write(e.Message, Colors.Text);
                            }
                        }

                        // device_init files done.
                        // ------ device_init ---------------------------------------------------------------------

                        // now loop through all other lua files for kneeboard
                        
                        foreach (KeyValuePair<string, Server.LuaFile> serverfile in LuaFiles)
                        {

                            // get lua file object

                            Server.LuaFile thisfile = serverfile.Value;

                            //skip non-kneeboard files
                            if (!thisfile.kneeboard)
                            {
                                continue;
                            }

                            // construct base install path

                            string basepath;
                            string path;

                            // determine root/SavedGames target location

                            if (thisfile.root) // to DCS program folder
                            {
                                basepath = dcsprogramfolder + "\\" + thisfile.installfolder;
                            }
                            else // to Saved Games
                            {
                                basepath = SavedGamesFolder + "\\" + thisfile.installfolder;
                            }

                            // create the folder if doesn't exit yet..

                            if (!Directory.Exists(basepath))
                            {
                                if (!restore)
                                {
                                    Directory.CreateDirectory(basepath);
                                }
                            }

                            // construct file path for this file

                            path = basepath + "\\" + thisfile.filename;

                            // ----- remove the file first ----

                            if (File.Exists(path + ".old"))
                            {
                                File.Delete(path + ".old");
                            }
                            if (File.Exists(path))
                            {
                                // make a backup copy if there's already some other 1.lua there
                                if (thisfile.filename.Equals("1.lua") && !File.ReadAllText(path).Equals(thisfile.source))
                                {
                                    File.Move(path, basepath + "\\" + "1.old.lua");
                                }
                                File.Delete(path);
                            }

                            // -----  write the new file -----------------------------------------

                            if (thisfile.binary)
                            {
                                byte [] writestring = thisfile.binarysource;
                                if (!restore)
                                {
                                    File.WriteAllBytes(path, writestring);
                                }

                            }
                            else // text files 
                            {
                                
                                string writestring = "";

                                if (thisfile.reset || restore)
                                {
                                   writestring = thisfile.orig; 
                                }
                                else // new write
                                {
                                    writestring = thisfile.source;
                                }

                                if (!restore)
                                {
                                    // write the file
                                    using (StreamWriter writer = new StreamWriter(path, false))
                                    {
                                        writer.Write(writestring); // don't restore for kneeboard files                              
                                    }
                                }

                            }

                            if (!forcequiet)
                            {
                                Log.Write("   Reset: " + thisfile.filename, Colors.Inline);
                            }

                        }     
                    }
                }
            }
        }
    }
}

