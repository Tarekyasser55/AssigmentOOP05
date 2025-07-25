using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05
{
    internal class Point3D: IComparable<Point3D > ,ICloneable
    {
        public int n1;
        public int n2;
        public int n3;
        public Point3D(int n1,int n2,int n3)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.n3 = n3;
        }
        public Point3D(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            
        }
        public override string ToString()
        {
            return $"Point Coordinates:({this.n1},{this.n2},{this.n3})";
        }
        public override bool Equals(object obj)
        {
            if (obj is Point3D p)
                return (n1 == p.n1 && n2 == p.n2 && n3 == p.n3);
            return false;
        }


        public static bool operator ==(Point3D p1, Point3D p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (p1 is null || p2 is null) return false;
            return p1.Equals(p2);
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return !(p1 == p2);
        }


        public int CompareTo(Point3D p)
        {
            int compareX = this.n1.CompareTo(p.n1);
            if (compareX != 0) return compareX;
            return this.n2.CompareTo(p.n2);
        }

        public object Clone()
        {
            return new Point3D(this.n1, this.n2, this.n3);
        }
    }
}
