using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;

namespace GuessMelodyWindowsFormsApp
{
    public static class Game
    {
        public static List<string> gameList = new List<string>();
        public static int gameDuration = 60; //wie lange Spiel dauert
        public static int musicDuration = 10; //wie lange ein Musiktrack dauert
        public static bool randomStart = false; //track - start with begin or random place
        public static bool allDirectories = false; //step into folders down or over
        public static string lastFolder = ""; // folder with music

        public static void ReadMusic()
        {
            //exception first using
            try
            {
                string[] musicFiles = Directory.GetFiles(lastFolder, "* .mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                gameList.Clear();
                gameList.AddRange(musicFiles);
            }
            catch { }
        }
        public static string regKeyName = "SoftWare\\MyCompanyName\\GuessMelody";

        public static void WriteParametrs()
        {
            RegistryKey registryKey = null;
            try
            {
                registryKey = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (registryKey == null)
                {
                    return;
                }
                registryKey.SetValue("LastFolder", lastFolder);
                registryKey.SetValue("RandomStart", randomStart);
                registryKey.SetValue("GameDuration", gameDuration);
                registryKey.SetValue("MusicDuration", musicDuration);
                registryKey.SetValue("AllDirectories", allDirectories);

            }
            finally
            {
                if (registryKey != null)
                {
                    registryKey.Close();
                }
            }
        }

        public static void ReadParametrs()
        {
            RegistryKey registryKey = null;
            try
            {
                registryKey = Registry.CurrentUser.OpenSubKey(regKeyName);
                if (registryKey != null)
                {
                    lastFolder = (string)registryKey.GetValue("LastFolder");
                    gameDuration = (int)registryKey.GetValue("GameDuration");
                    musicDuration = (int)registryKey.GetValue("MusicDuration");
                    randomStart = Convert.ToBoolean(registryKey.GetValue("randomStart", false));
                    allDirectories = Convert.ToBoolean(registryKey.GetValue("AllDirectories", false));
                }

            }
            finally
            {
                if (registryKey == null)
                {
                    registryKey.Close();
                }
            }
        }
    }
}
