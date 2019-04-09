namespace Geometrics
{
    public abstract class Figure
    {
        public double Perimeter { get; set; }
        public double Area { get; set; }
        
        public abstract double CalcArea();
        public abstract double CalcPerimeter();
        
        public virtual bool Exists()
        {
            return true;
        }
    }
}
