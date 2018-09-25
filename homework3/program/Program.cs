using System;

namespace program
{
    abstract class Chart
    {
        public abstract void ShowArea();
    }

    class TriangleChart:Chart
    {
        double edge1, edge2, edge3;
        double area;
        public TriangleChart(double edge1, double edge2, double edge3)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
            double p = this.edge1 + this.edge2 + this.edge3;
            area = Math.Sqrt(p * (p - this.edge1) * (p - this.edge2) * (p - this.edge3));
        }
        public override void ShowArea()
        {
            Console.WriteLine("The area of triangle is " + area);
        }
    }

    class CircleChart : Chart
    {
        double radius;
        double area;
        public CircleChart(double radius)
        {
            this.radius = radius;
            area = 3.14 * this.radius * this.radius;
        }
        public override void ShowArea()
        {
            Console.WriteLine("The area of circle is " + area);
        }
    }

    class SquareChart : Chart
    {
        double edge;
        double area;
        public SquareChart(double edge)
        {
            this.edge = edge;
            area = this.edge * this.edge;
        }
        public override void ShowArea()
        {
            Console.WriteLine("The area of square is " + area);
        }
    }

    class RectangleChart : Chart
    {
        double edge1, edge2;
        double area;
        public RectangleChart(double edge1, double edge2)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            area = this.edge1 * this.edge2;
        }
        public override void ShowArea()
        {
            Console.WriteLine("The area of rectangle is " + area);
        }
    }

    class Produce
    {
        public static Chart getChart(String arg, double[] par)
        {
            Chart chart = null;
            switch (arg)
            {
                case "triangle":
                    chart = new TriangleChart(par[0], par[1], par[2]);
                    Console.WriteLine("Construct triangle");
                    break;
                case "circle":
                    chart = new CircleChart(par[0]);
                    Console.WriteLine("Construct circle");
                    break;
                case "square":
                    chart = new SquareChart(par[0]);
                    Console.WriteLine("Construct square");
                    break;
                case "rectangle":
                    chart = new RectangleChart(par[0], par[1]);
                    Console.WriteLine("Construct rectangle");
                    break;
            }
            return chart;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double[] parTri = {1,1,1 };
            double[] parCir = {1.0};
            double[] parSqu = {1};
            double[] parRec = {1, 1};
            Chart triangle = Produce.getChart("triangle", parTri);
            Chart circle = Produce.getChart("circle", parCir);
            Chart square = Produce.getChart("square", parSqu);
            Chart rectangle = Produce.getChart("rectangle", parRec);
            triangle.ShowArea();
            circle.ShowArea();
            square.ShowArea();
            rectangle.ShowArea();
        }
    }
}
