namespace Lab1.Services.lab3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width * Height;
        }
        public int GetShorterSide()
        {
            /*if (Width > Height)
            {
                return Width;
            }
            return Height;*/
            return new List<int> { Width, Height }.Min();
        }
        public int GetArea(int x)
        {
            return Width * Height * x;
        }
        public int GetArea(double x)
        {
            return Width * Height * (int)x;
        }
    }
}
