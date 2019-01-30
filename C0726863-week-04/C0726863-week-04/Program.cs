using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0726863_week_04
{
    class Program
    {
        class Village

        {
            // Node is an ADT
            // what kind of DATA do we need in a NODE?
            public Village nextVillage;
            public string VillageName;
            public bool isAstrildeHere = false;
        }
        class countryside
        {
            Village Maple = new Village();
            Village Toronto = new Village();
            Village Ajex = new Village();
            Village First;
            Village Last;


            public void Launch()
            {
                Maple.VillageName = "Maple";
                Maple.nextVillage = "Toronto";
                Maple.nextVillage = "Toronto";
            }

        }
    }
}
        
    