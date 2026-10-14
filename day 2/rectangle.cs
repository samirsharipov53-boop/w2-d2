class Rectangle
{
    public int Width{get ; set;}
    public int Height{get ; set;}
    public string Color{get ; set;}
    public  Rectangle(int width, int height,string color)
    {
        Width = width ;
        Height = height ;
        Color = color ;
    }
    public int GetArea()
    {
        return Width * Height;
    }
    public int GetPerimetr()
    {
        return 2*(Width + Height);
    }
    
}