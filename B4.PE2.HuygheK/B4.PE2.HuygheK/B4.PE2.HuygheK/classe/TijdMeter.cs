using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace B4.PE2.HuygheK.classe
{
    public class TijdMeter 
    {
        
        public DateTime t = DateTime.Now;
        public string tijd = "";
        public bool wissel = false;
        public int lapTeller = 0;
        public string lapText = "";
        public void Start()
        {
            wissel = false;
        }
        public void Stop()
        {
            t = DateTime.Now;
            wissel = true;
            lapTeller = 0;
            lapText = "";
        }
        public void Lap()
        {
            lapTeller++;
            lapText = lapText + "lap " + lapTeller.ToString() + " Duur:" + tijd + "\n";
            t = DateTime.Now;
        }
    }
}
