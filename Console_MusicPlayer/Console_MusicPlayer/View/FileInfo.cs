﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_MusicPlayer.View
{
    class FileInfo
    {
        public static String Path = Directory.GetCurrentDirectory();
        public static String Filename = "Untitled.txt";

        public static Boolean HasChanged;
    }
}
