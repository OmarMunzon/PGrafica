using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Silla
{ 
    class Silla
    {
        //
        float x, y, z; 
        Vector3 colour,centro;

        public Silla(Vector3 Centro, float ancho, float alto, float profundidad)
        {
            this.centro = new Vector3(Centro.X / 100, Centro.Y / 100, Centro.Z);
            this.x = ancho / 100;
            this.y = alto / 100;
            this.z = (profundidad / 100);
            colour = new Vector3(1.0f, 0.5f, 0.5f);//cafe
        }
        public void Dibujar()
        {            
            GL.PushMatrix();
            asiento();
            pata();
            apoyo();
            //espaldar();
            //Tabla();
            //Patas();         
            GL.PopMatrix();
        }
        
        //3D
        public void espaldar()
        {
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x / 2, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.Vertex3(centro.X + x / 2, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);            
            GL.Vertex3(centro.X + x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X + x / 2, centro.Y + (2 * y), centro.Z - z);
            GL.End();

            //der
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x / 2, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x / 2, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X + x / 2, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //izquierdo
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + (2 * y), centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z);
            GL.End();

            //der
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //horizontal
            //frente
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y) + (y / 2), centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y) + (y / 2), centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.End();

            //atras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y) + (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y) + (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z);
            GL.End();

            //der
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y) + (y / 2), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y) + (y / 2), centro.Z - z / 2);
            GL.End();
            //izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y) + (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y) + (y / 2), centro.Z - z / 2);
            GL.End();
            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y) + (y / 2), centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + (2 * y) + (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y) + (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + (2 * y) + (y / 2), centro.Z - z / 2);
            GL.End();

        }

        public void Tabla()
        {
            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z);
            GL.End();

            ////Frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y + y / 2, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y / 2, centro.Z + z);
            GL.End();

            //Atras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y / 2, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y / 2, centro.Z - z);
            GL.End();

            //Derecha
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y / 2, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y / 2, centro.Z - z);
            GL.End();

            //Izquierda
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y + y / 2, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y + y / 2, centro.Z - z);
            GL.End();
        }

        public void Patas()
        {
            //p1
            //frontal           
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z + z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z + z);
            GL.End();

            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z + z / 2);
            GL.End();

            //derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.End();

            //izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z + z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z + z);
            GL.End();
            //abajo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z + z);
            GL.End();

            //p2 
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z / 2);
            GL.End();


            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.End();

            //derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z / 2);
            GL.End();

            //izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z + z);
            GL.End();

            //abajo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z + z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z + z / 2);
            GL.End();

            //p3
            //Lado detras
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z - z / 2);
            GL.End();
            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z - z);
            GL.End();
            //der
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z / 2);
            GL.End();
            //izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z - z);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3((centro.X) + x / 2, centro.Y + y, centro.Z - z / 2);
            GL.End();

            //abajo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3(centro.X + x, centro.Y - y, centro.Z - z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z - z);
            GL.Vertex3((centro.X) + x / 2, centro.Y - y, centro.Z - z / 2);
            GL.End();


            //p4
            //Lado detras
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z / 2);
            GL.End();
            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.End();
            //derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z / 2);
            GL.End();

            //izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z - z / 2);
            GL.End();

            //abajo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z / 2);
            GL.End();
        }

        //2D
        public void asiento()
        {
            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + (2 * x), centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z );
            GL.Vertex3(centro.X - (2 * x) - x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X , centro.Y - y, centro.Z - z );
            GL.End();            
        }

        void pata()
        {
            //1
            //frontal            
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.2f, 0.2f);//cafe
            GL.Vertex3(centro.X + (2 * x), centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + (2 * x) - 0.2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + (2 * x) - 0.2, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X + (2 * x), centro.Y - y, centro.Z - z);
            GL.End();            
            //2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.2f, 0.2f);
            GL.Vertex3(centro.X - x + 0.2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x, centro.Y + y, centro.Z - z);            
            GL.Vertex3(centro.X - x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - x + 0.2, centro.Y - y, centro.Z - z);
            GL.End();
                       
            //3            
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.2f, 0.2f);
            GL.Vertex3(centro.X - (2 * x) - x + 0.2, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - (2 * x) - x, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - (2 * x) - x, centro.Y - (3 * y), centro.Z - z);
            GL.Vertex3(centro.X - (2 * x) - x + 0.2, centro.Y - (3 * y), centro.Z - z);
            GL.End();

            //4            
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.2f, 0.2f);
            GL.Vertex3(centro.X, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - 0.2, centro.Y - y, centro.Z - z);
            GL.Vertex3(centro.X - 0.2, centro.Y - 3 * y, centro.Z - z);
            GL.Vertex3(centro.X, centro.Y - 3 * y, centro.Z - z);
            GL.End();            
        }
        
        void apoyo()
        {
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.1f, 0.1f);
            GL.Vertex3(centro.X + (2 * x), centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + (2 * x), centro.Y + (3.5 * y), centro.Z - z);
            GL.Vertex3(centro.X - (x), centro.Y + 3.5 * y, centro.Z - z);
            GL.Vertex3(centro.X - (x), centro.Y + y, centro.Z - z);
            GL.End();            
        }

    }    
}







