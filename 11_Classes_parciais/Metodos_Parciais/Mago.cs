using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Parciais;

public class Mago
{
    private RitualMagico ritual;

    public Mago()
    {
        ritual = new RitualMagico("Lumus");
    }

    public void RealizarRitual()
    {
        ritual.ExecutarRitual();
    }
}