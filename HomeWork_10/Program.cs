namespace HomeWork_10
{
    internal class Program
    {
        public struct Point
        {
            public int x;
            public int y;

            public Point (int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public override string ToString()
            {
                return $"({x}, {y})";
            }
        }

        public class Triangle
        {
            Point vertex1;
            Point vertex2;
            Point vertex3;

            public Triangle(Point vertex1, Point vertex2, Point vertex3)
            {
                this.vertex1 = vertex1;
                this.vertex2 = vertex2;
                this.vertex3 = vertex3;
            }

            public Point Distance(Point first, Point second)
            {
                return new Point(first.x - second.x, first.y - second.y);
            }

            public void Perimeter()
            {

            }

            public void Square()
            {

            }

            public void Print()
            {

            }
        }

       

        public int[][] KClosest(int[][] points, int k)
        {
            PriorityQueue<int[], double> queue;

            queue = new PriorityQueue<int[], double>();

            foreach (var point in points)
            {
                queue.Enqueue(point, Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2)));
            }

            var kthPoints = new List<int[]>();
            while (k > 0)
            {
                kthPoints.Add(queue.Dequeue());
                k--;
            }

            return kthPoints.ToArray();
        }

        static void Main(string[] args)
        {
            List<Triangle> triangles= new List<Triangle>();
            Point point1 = new Point
            {
                x = 1,
                y = 2
            };
            Point point2 = new Point
            {
                x = 2,
                y = 1
            };
            Point point3 = new Point
            {
                x = 3,
                y = 0
            };
            triangles.Add(new Triangle(point1, point2, point3));
            triangles.Add(new Triangle(point3, point2, point1));
            triangles.Add(new Triangle(point2, point1, point3));

            PriorityQueue<int[], double> queue;
        }
    }
}