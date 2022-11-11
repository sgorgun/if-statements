namespace IfStatements
{
    public static class Task14
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2 && i <= -5)
            {
                return 10 - (i * 2);
            }

            if (b1 && b2 && i > -5 && i <= 5)
            {
                return i * -2;
            }

            if (b1 && b2 && i > 5)
            {
                return 10 - (i * 2);
            }

            if (b1 && !b2 && i <= -5)
            {
                return i * i * i;
            }

            if (b1 && !b2 && i > -5 && i <= 5)
            {
                return i * i;
            }

            if (b1 && !b2 && i > 5)
            {
                return i * i * i;
            }

            if (!b1 && b2 && i < -9)
            {
                return i * -1;
            }

            if (!b1 && b2 && i >= -9 && i < -7)
            {
                return i;
            }

            if (!b1 && b2 && i >= -7 && i < -3)
            {
                return i * 10;
            }

            if (!b1 && b2 && i >= -3 && i <= 7)
            {
                return i;
            }

            if (!b1 && b2 && i > 7)
            {
                return i * -1;
            }

            if (!b1 && !b2 && i < -9)
            {
                return i * -1;
            }

            if (!b1 && !b2 && i >= -9 && i < -3)
            {
                return i;
            }

            if (!b1 && !b2 && i >= -3 && i < 0)
            {
                return i * -100;
            }

            if (!b1 && !b2 && i == 0)
            {
                return 0;
            }

            if (!b1 && !b2 && i > 0 && i < 5)
            {
                return i * -100;
            }

            if (!b1 && !b2 && i >= 5 && i <= 7)
            {
                return i;
            }

            if (!b1 && !b2 && i > 7)
            {
                return i * -1;
            }

            return i;
        }
    }
}
