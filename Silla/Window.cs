using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK.Graphics.OpenGL;
using OpenTK.Graphics;
using OpenTK;

namespace Silla
{
    class Window:GameWindow
    {
        Escenario esc;
                
        public Window(int alto,int ancho, string titulo):base(alto,ancho,GraphicsMode.Default,titulo)
        {                        
            this.esc=new Escenario();
        }

        
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(1.0f, 1.0f, 1.0f, 0f);
            GL.Enable(EnableCap.DepthTest);            
            base.OnLoad(e);            
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.LoadIdentity();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            
            this.esc.DibujarEscenario();

            Context.SwapBuffers();           
            base.OnRenderFrame(e);
        }


        protected override void OnResize(EventArgs e)
        {
            GL.MatrixMode(MatrixMode.Projection);             
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), Width * 1f / Height, 1.0f, 100.0f);
            GL.LoadMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Modelview);                        
            base.OnResize(e);
        }

        
    }
}
