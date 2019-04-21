using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnetDeNotes
{
    interface ISauvableCarnet
    {
        Carnet Charger();
        void Sauver(Carnet c);
    }
}
