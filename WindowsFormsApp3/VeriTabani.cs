﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class VeriTabani
    {
        //Belirlenen yoldaki .txt belgesinden veritabanı konumunu okur.
        public string BaglantiAdresi = System.IO.File.ReadAllText(@"C:\Test2.txt");
    }
}
