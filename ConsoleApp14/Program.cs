using System;
public class box
{
    static void Main()
    {
        float Ai;
        while (true)
        {
            Ai = InputFloat($"底辺の長さと高さで計算するなら1　三辺の長さで計算するなら2");
            if (Ai == 1)
            {
                Box box = new Box(InputFloat("底辺の長さを入力"), InputFloat("底面の高さを入力"), InputFloat("柱の高さを入力"));
                Console.WriteLine("三角柱の表面積 = " + box.GetSurfaceC() + " 体積 = " + box.GetVolumeC());
                break;
            }
            if (Ai == 2)
            {
                X box = new X(InputFloat("辺の長さを入力"), InputFloat("辺の長さを入力"), InputFloat("辺の長さを入力"),InputFloat("柱の高さ"));
                Console.WriteLine("三角柱の表面積 = " + box.GetSurfaceC() + " 体積 = " + box.GetVolumeC());
                break;
            }
        }

    }

    static float InputFloat(string su)
    {
        float input;
        while (true)
        {
            Console.WriteLine(su);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }
    }
}
class Box
{
    private float length;
    private float height;
    private float pillar;
    public Box(float l, float h, float p)
    {
        this.length = l;
        this.height = h;
        this.pillar = p;

    }
    public Box(float r = 1)
    {
        this.length = r;
        this.height = r;
        this.pillar = r;
    }
    public float GetVolumeC()
    {
        return (length * height) / 2 * pillar;
    }
    public float GetSurfaceC()
    {
        return length *MathF.PI * height * 2;
    }
}
class X
{
    private float side1;
    private float side2;
    private float side3;
    private float height;

    public X(float s1, float h, float s2,float s3)
    {
        this.side1 = s1;
        this.side2 = s2;
        this.side3 = s3;
        this.height = h;
    }
    public X(float r = 1)
    {
        this.side1 = r;
        this.side2 = r;
        this.side3=r;
        this.height = r;
    }
    public float GetVolumeC()
    {
        float s = (side1 + side2 + side3) / 2;
        return (float)(Math.Sqrt(s) * height);
    }
    public float GetSurfaceC()
    {
        float s = (side1 + side2 + side3) / 2;
        return (float)(Math.Sqrt(s) * height)*2+(side1+side2+side3)*height;
    }
}