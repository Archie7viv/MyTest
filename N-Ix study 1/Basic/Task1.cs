using System;

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
            areEqual = x==y;
            areEqual1 = x==z;
            areEqual2 = x==d;
            areEqual3 = Equals(x, a);
            areEqual4 = y==z;
            areEqual5 = y==d;
            areEqual6 = Equals(y, a);
            areEqual7 = z==d;
            areEqual8 = Equals(z, a);
            areEqual9 = Equals(d, a);
        }

        public void DontAssignValues()
        {
            x = default;
            y = default;
            z = default;
            d = default;
            a = default;

            areEqual = x==y;
            areEqual1 = x==z;
            areEqual2 = x==d;
            areEqual3 = Equals(x, a);
            areEqual4 = y==z;
            areEqual5 = y==d;
            areEqual6 = Equals(y, a);
            areEqual7 = z==d;
            areEqual8 = Equals(z, a);
            areEqual9 = Equals(d, a);
        }

        public void AssignSameValues()
        {
            x = 1;
            y = 1;
            z = 1;
            d = 1;
            a = "1";

            areEqual = x==y;
            areEqual1 = x==z;
            areEqual2 = x==d;
            areEqual3 = Equals(x, a);
            areEqual4 = y==z;
            areEqual5 = y==d;
            areEqual6 = Equals(y, a);
            areEqual7 = z==d;
            areEqual8 = Equals(z, a);
            areEqual9 = Equals(d, a);
        }

        public void SameValuesFloadDouble()
        {
            z = 0.5F;
            d = 0.5D;
            areEqual = z==d;

            z = 0.7F;
            d = 0.7D;
            areEqual = z == d;

            z = 1.0F;
            d = 1.0D;
            areEqual = z == d;

            z = 0.1F;
            d = 0.1D;
            areEqual = z == d;
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

            z = z / 0;

            d = d / 0;
        }

        public void DivideByThree()
        {
            res = x / 3;
            res1 = y / 3;
            z = 0.1F;
            d = 0.42e2;

            res2 = (decimal)z / 3; //?

            res3 = (decimal)d / 3; //?      
        }

        public void DivideByThreeAndRound()
        {
            res = Math.Round(x / 3.0M, 2);
            res1 = Math.Round(y / 3.0M, 3);

            res2 = Math.Round((decimal)z / 3.0M, 4); //?

            res3 = Math.Round((decimal)d / 3.0M, 5); //?
        }
    }
}
