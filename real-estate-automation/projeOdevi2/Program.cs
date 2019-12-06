/****************************************************************************
**                      SAKARYA ÜNİVERSİTESİ            
**              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**                  NESNEYE DAYALI PROGRAMLAMA DERSİ
**                      2016-2017 BAHAR DÖNEMİ
**                           YAZ DÖNEMİ
**                     ÖDEV NUMARASI..........: 1
**                     ÖĞRENCİ ADI............: Ahmet Emirhan ÖZGELİŞ
**                     ÖĞRENCİ NUMARASI.......:G1612.10079
**                     DERSİN ALINDIĞI GRUP...: A
****************************************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace projeOdevi2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
