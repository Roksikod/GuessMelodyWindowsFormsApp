using System.Collections.Generic;

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

    }
}
