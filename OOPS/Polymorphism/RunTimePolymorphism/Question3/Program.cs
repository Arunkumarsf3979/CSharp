using System;
namespace Question3;
class Program{
    public static void Main(string[] args)
    {
        Draw draw=new Draw();
        draw.DrawLine();
        DrawPyramid drawPyramid=new DrawPyramid();
        drawPyramid.DrawLine();
        DrawStar drawStar=new DrawStar();
        drawStar.DrawLine();
    }
}