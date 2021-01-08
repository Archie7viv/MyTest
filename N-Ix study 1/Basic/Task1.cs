using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Ix_study_1.Basic
{
    public class Task1
    {
        int x = 10;
        long y = 897867586957465;
        float z = 1.5F;
        double d = 0.42e2;
        string a = "Test string";
        decimal res, res1, res2, res3;

        bool areEqual, areEqual1, areEqual2, areEqual3, areEqual4, areEqual5, areEqual6, areEqual7, areEqual8, areEqual9;

        public void AssignDifferentValues()
        {
            areEqual = System.Object.ReferenceEquals(x, y);
            areEqual1 = System.Object.ReferenceEquals(x, z);
            areEqual2 = System.Object.ReferenceEquals(x, d);
            areEqual3 = System.Object.ReferenceEquals(x, a);
            areEqual4 = System.Object.ReferenceEquals(y, z);
            areEqual5 = System.Object.ReferenceEquals(y, d);
            areEqual6 = System.Object.ReferenceEquals(y, a);
            areEqual7 = System.Object.ReferenceEquals(z, d);
            areEqual8 = System.Object.ReferenceEquals(z, a);
            areEqual9 = System.Object.ReferenceEquals(d, a);
        }

        public void DontAssignValues()
        {
            x = default;
            y = default;
            z = default;
            d = default;
            a = default;

            areEqual = System.Object.ReferenceEquals(x, y);
            areEqual1 = System.Object.ReferenceEquals(x, z);
            areEqual2 = System.Object.ReferenceEquals(x, d);
            areEqual3 = System.Object.ReferenceEquals(x, a);
            areEqual4 = System.Object.ReferenceEquals(y, z);
            areEqual5 = System.Object.ReferenceEquals(y, d);
            areEqual6 = System.Object.ReferenceEquals(y, a);
            areEqual7 = System.Object.ReferenceEquals(z, d);
            areEqual8 = System.Object.ReferenceEquals(z, a);
            areEqual9 = System.Object.ReferenceEquals(d, a);
        }

        public void AssignSameValues()
        {
            x = 1;
            y = 1;
            z = 1;
            d = 1;
            a = "1";

            areEqual = System.Object.ReferenceEquals(x, y);
            areEqual1 = System.Object.ReferenceEquals(x, z);
            areEqual2 = System.Object.ReferenceEquals(x, d);
            areEqual3 = System.Object.ReferenceEquals(x, a);
            areEqual4 = System.Object.ReferenceEquals(y, z);
            areEqual5 = System.Object.ReferenceEquals(y, d);
            areEqual6 = System.Object.ReferenceEquals(y, a);
            areEqual7 = System.Object.ReferenceEquals(z, d);
            areEqual8 = System.Object.ReferenceEquals(z, a);
            areEqual9 = System.Object.ReferenceEquals(d, a);
        }

        public void SameValuesFloadDouble()
        {
            z = 0.5F;
            d = 0.5D;
            areEqual = System.Object.ReferenceEquals(z, d);

            z = 0.7F;
            d = 0.7D;
            areEqual = System.Object.ReferenceEquals(z, d);

            z = 1.0F;
            d = 1.0D;
            areEqual = System.Object.ReferenceEquals(z, d);

            z = 0.1F;
            d = 0.1D;
            areEqual = System.Object.ReferenceEquals(z, d);
        }

        public void DivideByZero()
        {
            try
            {
                x = x / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                y = y / 0;
            }
            catch (DivideByZeroException) { }

            try
            {
                z = z / 0;
            }
            catch (DivideByZeroException) { }

            try
            {
                d = d / 0;
            }
            catch (DivideByZeroException) { }
        }

        public void DivideByThree()
        {
            res = x / 3;
            res1 = y / 3;
            try
            {
                res2 = (decimal)z / 3; //?
            }
            catch (System.OverflowException) { }

            try
            {
                res3 = (decimal)d / 3; //?
            }
            catch (System.OverflowException) { }         
        }

        public void DivideByThreeAndRound()
        {
            res = Math.Round(x / 3.0M, 2);
            res1 = Math.Round(y / 3.0M, 3);

            try
            {
                res2 = Math.Round((decimal)z / 3.0M, 4); //?
            }
            catch (System.OverflowException) { }

            try
            {
                res3 = Math.Round((decimal)d / 3.0M, 5); //?
            }
            catch (System.OverflowException) { }          
        }
    }
}
