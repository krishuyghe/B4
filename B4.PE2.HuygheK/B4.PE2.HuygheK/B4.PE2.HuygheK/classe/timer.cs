using System;
using System.Collections.Generic;
using System.Text;

namespace B4.PE2.HuygheK.classe
{
    class timer
    {
        private static System.Timers.Timer aTimer;

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(2000);
            // Hook up the Elapsed event for the timer. 
           // aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
        

    }
}
