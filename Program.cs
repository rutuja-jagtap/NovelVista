﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {


            FileHandling fileHandling = new FileHandling();
            //fileHandling.WriteFile();
            fileHandling.ReadFile();
            Console.Read();
        }
    }
}