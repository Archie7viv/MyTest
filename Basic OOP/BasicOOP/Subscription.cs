namespace N_Ix_study_1.BasicOOP
{
    public static class Subscription
    {
        public static int fullPrice = 1000;
        public static int discountPrice = 800;
        public static bool isDiscount;

        public static int GetPrice(bool isDiscount = false)
        {
            if(isDiscount)
            {
                return fullPrice;
            }
            else
            {
                return discountPrice;
            }
        }
    }
}
