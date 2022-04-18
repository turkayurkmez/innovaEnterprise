// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var rect = GetRectangle(5,3);
Console.WriteLine(rect.GetArea());

/*
 * Bir base class'dan miras alan bir derived class, base class yerine de kullanılabilmelidir.
 * 
 * Eğer derived class'ın davranışı base class'ı değiştiriyorsa prensibi ihlal ediyorsunuz demektir.
 */



static IAreaCalcutable GetRectangle(int unit1, int unit2 = 1)
{
    //bir biçimde kare döndürüyor:
    if (unit2 != 1)
    {
        return new Rectangle { Width = unit1, Height = unit2 };
    }
    return new Square() { Edge = unit1 };
}


public interface IAreaCalcutable
{
    public int GetArea();

}
public class Rectangle : IAreaCalcutable
{

    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : IAreaCalcutable
{
    public int Edge { get; set; }

    public int GetArea()
    {
        return Edge * Edge;
    }
}

