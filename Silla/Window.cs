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
        Silla obj, obj2, obj3, obj4, obj5;
        Vector3 Centro1, Centro2, Centro3, Centro4, Centro5;
        public Window(int alto,int ancho, string titulo):base(alto,ancho,GraphicsMode.Default,titulo)
        {
            Centro1 = new Vector3(0, 0, -3);
            Centro2 = new Vector3(-150, 50, -3);
            Centro3 = new Vector3(200, 70, -2);
            Centro4 = new Vector3(-20, 49, -4);
            Centro5 = new Vector3(-100, 100, -3);
            //
            obj = new Silla(Centro1, 30, 30, 30);
            //obj2 = new Silla(Centro2, 20, 20, 20);
            //obj3 = new Silla(Centro3, 20, 20, 20);
            //obj4 = new Silla(Centro4, 20, 20, 20);
            //obj5 = new Silla(Centro5, 20, 20, 20);            

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
            obj.Dibujar();
            //obj2.Dibujar();
            //obj3.Dibujar();
            //obj4.Dibujar();
            //obj5.Dibujar();
            Context.SwapBuffers();           
            base.OnRenderFrame(e);
        }


        protected override void OnResize(EventArgs e)
        {
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Matrix4 matrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(45.0f), Width * 1f / Height, 1.0f, 100.0f);
            GL.LoadTransposeMatrix(ref matrix);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Viewport(0, 0, Width, Height);

            base.OnResize(e);
        }
    }
}
