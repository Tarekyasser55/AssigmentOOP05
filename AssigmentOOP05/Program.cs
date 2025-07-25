namespace AssigmentOOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstProject
            Point3D p = new Point3D(10, 10, 10);
            Console.WriteLine(p.ToString());
            Point3D P1 = ReadPoint("P1");
            Point3D P2 = ReadPoint("P2");

            Console.WriteLine(P1);
            Console.WriteLine(P2);

            Console.WriteLine("P1 == P2 " + (P1 == P2));


            Point3D[] points = new Point3D[]
            {
                new Point3D(1,8,87),
                new Point3D(32,55,99),
                new Point3D(34,62,12),
                new Point3D(80,57,71)
            };

            Array.Sort(points);

            Console.WriteLine("array sorted\n");
            foreach (var p in points)
                Console.WriteLine(p);

            Point3D cloneP1 = (Point3D)P1.Clone();
            Console.WriteLine("Cloned P1: " + cloneP1);
        


        #endregion




        #region  Second project
        //int n1 = 20, n2 = 10;
        //Console.WriteLine($"the {n1} + {n2} = {Maths.Add(n1, n2)}");
        //Console.WriteLine($"the {n1} - {n2} = {Maths.Subtract(n1, n2)}");
        //Console.WriteLine($"the { n1} * {n2} = {Maths.Multiply(n1, n2)}");
        //Console.WriteLine($"the { n1} / {n2} = :{Maths.Divide(n1, n2)}");
        #endregion
    }
    }
}
