using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    interface IDrivable
    {
        string Brakes { get; set; }

        string Gas { get; set; }


        string BreaksPushed();

        string GasPushed();



    }
}
