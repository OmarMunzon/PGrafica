using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
namespace Silla
{
    class Escenario
    {        
        Vector3 centroMasa = new Vector3(0, 0, -4);
        chair silla;        
        

        public Escenario()
        {            
            this.silla = new chair(centroMasa,ancho: 50,alto: 50,profundidad: 50);
        }

        public void DibujarEscenario()
        {
            this.silla.Dibujar();
        }
    }
}
