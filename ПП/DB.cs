﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace ПП
{
    public class DB
    {
        private static string ProjectLocation = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
        public static string ConnStr = ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + ProjectLocation + "\\" + "Programm.mdb");
    }
}
