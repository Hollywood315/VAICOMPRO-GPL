﻿using VAICOM.Static;
using VAICOM.Database;
using System.IO;

namespace VAICOM
{
    namespace FileManager
    {

        public partial class FileHandler
        {
            public static partial class Root
            {

                // check if .vap profile file exist and if not creates it:
                public static void CheckProfile(bool overwrite)
                {
                    Log.Write("Checking VA profile.", Colors.Text);

                    try
                    {
                        string rootpath = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername;
                        string path;
                        string filename = "VAICOM PRO for DCS World.vap";
                        string sourcefile = Properties.Resources.VAICOM_PRO_for_DCS_World;

                        path = rootpath + "\\" + AppData.SubFolders["profiles"] + "\\" + filename;

                        if (!File.Exists(path) || (File.Exists(path) & overwrite))
                        {
                            File.WriteAllText(path, sourcefile);
                        }

                    }
                    catch
                    {
                    }
                }

                public static string CheckProfileContent(bool silent)
                {
                    string profileid = State.Proxy.GetProfileName();
                    string result = "";

                    if (!State.activeconfig.UseNewRecognitionModel) 
                    {
                        if (!State.Proxy.Command.Exists("Colt"))
                        {
                            result = "Profile not configured for standard processing: apply FINISH steps.";
                            State.activeconfig.Editorunsavedchanges = true;
                        }
                        else
                        {
                            try
                            {
                                int counter = Aliases.ValidateProfileString(State.Proxy, silent);
                                if (counter.Equals(0))
                                {
                                    result = string.Format("Profile {0} matches database: no steps needed.", profileid);
                                    if (!silent)
                                    {
                                        Log.Write(result, Colors.Message);
                                        UI.Playsound.Commandcomplete();
                                    }
                                    State.activeconfig.Editorunsavedchanges = false;
                                }
                                else
                                {
                                    result = string.Format("{0} missing aliases in VA profile {1}.", counter, profileid);
                                    if (!silent)
                                    {
                                        Log.Write(result, Colors.Warning);
                                        UI.Playsound.Sorry();
                                    }
                                    State.activeconfig.Editorunsavedchanges = true;
                                }
                                Settings.ConfigFile.WriteConfigToFile(true);
                            }
                            catch
                            {
                            }
                        }
                    }
                    else // VSPX
                    {

                        if (State.activeconfig.Editorunsavedchanges)
                        {
                            result = "Apply FINISH steps to update VA profile.";
                            if (!silent)
                            {
                                UI.Playsound.Sorry();
                            }
                        }
                        else
                        {
                            result = "VSPX processing mode is active.";
                            if (!silent)
                            {
                                UI.Playsound.Commandcomplete();
                            }
                        }

                    }

                    return result;

                }
            }
        }
    }
}
