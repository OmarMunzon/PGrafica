using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Silla
{
    class chair:IGraficarObjeto
    {

        float x, y, z; 
        Vector3 colour,centro;

        public chair(Vector3 Centro, float ancho, float alto, float profundidad)
        {
            this.centro = new Vector3(Centro.X , Centro.Y , Centro.Z);
            this.x = ancho * 0.01f;
            this.y = alto * 0.01f;
            this.z = profundidad * 0.01f;            
        }
        public void Dibujar()
        {        
            GL.PushMatrix();                       
            apoyo();
            Tabla();
            Patas();         
            GL.PopMatrix();
        }

        void apoyo()
        {
            //izq-1
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z / 2);
            GL.End();

            //der-1
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z - z / 2);
            GL.End();

            //detras-1
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.End();

            //frente-1
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo           
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z - z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z / 2);
            GL.End();

            ////top-1
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            //GL.End();

            ////buttom-1
            //GL.Begin(PrimitiveType.Quads);
            //GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            //GL.End();

            //izquierda-2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z);
            GL.End();

            //derecha-2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z);
            GL.End();

            //detras-2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z / 2);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z / 2);
            GL.End();

            //frente-2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.End();

            //top-2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.End();

            //buttom-2
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(0.5f, 0.5f, 0.5f);//plomo
            GL.End();


            //izq-3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.5f, 0.5f);//cafe
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.39, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.60, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.60, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z);
            GL.End();

            //der-3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.5f, 0.5f);//cafe
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.60, centro.Z - z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.60, centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z);
            GL.End();

            //atras-3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.5f, 0.5f);//cafe
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.60, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.60, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z - z);
            GL.End();

            //frente-3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.5f, 0.5f);//cafe            
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.60, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.60, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z);
            GL.End();

            //buttom-3
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(1.0f, 0.5f, 0.5f);//cafe                                   
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y + 0.30, centro.Z + z);
            GL.End();
        }
        void Tabla()
        {            
            this.colour.X = 1.0f;
            this.colour.Y = 0.5f;
            this.colour.Z = 0.5f;             
            //top
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);  
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.End();

            //Buttom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);            
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z);
            GL.End();

            //Frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);  
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z + z);
            GL.End();

            //Atras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);  
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z);
            GL.End();

            //Derecha
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);  
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z);
            GL.End();

            //Izquierda
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);  
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z);
            GL.End();
        }                
        void Patas()
        {
            this.colour.X = 0.5f;
            this.colour.Y=0.5f;
            this.colour.Z=0.5f;
            //p1
            //frontal           
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y + y, centro.Z + z);
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y - y / 2, centro.Z + z);
            GL.End();

            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x , centro.Y - y / 2, centro.Z + z - 0.10);
            GL.Vertex3(centro.X + x , centro.Y + y, centro.Z + z - 0.10);
            GL.Vertex3((centro.X) + (x - 0.10) , centro.Y + y, centro.Z + z - 0.10);
            GL.Vertex3((centro.X) + (x - 0.10) , centro.Y - y / 2, centro.Z + z - 0.10);
            GL.End();

            //derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y + y, centro.Z + z - 0.10);
            GL.Vertex3(centro.X + x, centro.Y - y / 2, centro.Z + z - 0.10);            
            GL.End();

            //izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);            
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y - y / 2, centro.Z + z);
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y + y, centro.Z + z);
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y + y, centro.Z + z - 0.10);
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y - y / 2, centro.Z + z - 0.10);
            GL.End();
            
            
            //buttom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y - y / 2, centro.Z + z);
            GL.Vertex3(centro.X + x, centro.Y - y / 2, centro.Z + z - 0.10);            
            GL.Vertex3((centro.X) + (x - 0.10), centro.Y - y / 2, centro.Z + z - 0.10);
            GL.End();

            //p2 
            //frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y - (y / 2), centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + (y - 0.10), centro.Z + z);
            GL.End();

            //detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z - 0.10);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z + z - 0.10);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y - (y / 2), centro.Z + z - 0.10);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + (y - 0.10), centro.Z + z - 0.10);
            GL.End();

            //derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y - (y / 2), centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y - (y / 2), centro.Z + z - 0.10);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y + (y - 0.10), centro.Z + z - 0.10);
            GL.End();

            //izq
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z + z - 0.10);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z + z - 0.10);
            GL.End();

            //buttom
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y - (y / 2), centro.Z + z);
            GL.Vertex3(centro.X - x / 2 + 0.10, centro.Y - (y / 2), centro.Z + z - 0.10);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z + z - 0.10);            
            GL.End();

            //p3
            //detras                        
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - (y / 2), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y - (y / 2), centro.Z - z);            
            GL.End();

            //frente
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y - (y / 2), centro.Z - z + 0.10);            
            GL.End();
            
            //izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y - (y / 2), centro.Z - z + 0.10);            
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y - (y / 2), centro.Z - z);   
            GL.End();
            //der
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x, centro.Y - (y / 2), centro.Z - z);
            GL.Vertex3(centro.X + x, centro.Y + (y - 0.10), centro.Z - z);
            GL.End();
            //abajo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x, centro.Y - (y / 2), centro.Z - z);            
            GL.Vertex3(centro.X + x / 2 + 0.12, centro.Y - (y / 2), centro.Z - z);            
            GL.End();


            ////p4
            ////Lado detras
            ////frontal
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x - 0.62, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x - 0.62, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.End();

            ////detras
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X + x - 0.62, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X + x - 0.62, centro.Y - (y / 2), centro.Z - z);
            GL.End();


            //derecho
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X + x - 0.62, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x - 0.62, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x - 0.62, centro.Y - (y / 2), centro.Z - z);
            GL.Vertex3(centro.X + x - 0.62, centro.Y + (y - 0.10), centro.Z - z);            
            GL.End();

            //izquierdo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z + 0.10);
            GL.Vertex3(centro.X - x / 2, centro.Y + (y - 0.10), centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z - z);            
            GL.End();

            //abajo
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(colour.X, colour.Y, colour.Z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z - z + 0.10);            
            GL.Vertex3(centro.X + x - 0.62, centro.Y - (y / 2), centro.Z - z + 0.10);
            GL.Vertex3(centro.X + x - 0.62, centro.Y - (y / 2), centro.Z - z);
            GL.Vertex3(centro.X - x / 2, centro.Y - (y / 2), centro.Z - z);                        
            GL.End();
        }

        

        double ang = 0;
        void Rotar(float x, float y, float z)
        {
            GL.Rotate(ang, x + this.centro.X, y + this.centro.Y, z + this.centro.Z);
            ang++;
            if (ang > 360)
            {
                ang = 0;
            }
        }

        


    }
}
