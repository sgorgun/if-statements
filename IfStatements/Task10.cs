namespace IfStatements
{
    public static class Task10
    {
        public static int DoSomething(bool b1, bool b2, int i)
        {
            if (b1 && b2 && i == 0)
            {
                return -1;
            }

            if (b1 && b2 && i >= 2 && i <= 9)
            {
                return 10 - i;
            }

            if (b1 && b2 && i >= -9 && i <= -2)
            {
                return 5 + i;
            }

            if (b1 && b2 && i < -9)
            {
                return i;
            }

            if (b1 && b2 && i > -2)
            {
                return i;
            }

            if (b1 && b2 && i < 0)
            {
                return i;
            }

            if (b1 && !b2 && i == 0)
            {
                return -1;
            }

            if (b1 && !b2 && i >= 2 && i <= 9)
            {
                return 10 + i;
            }

            if (b1 && !b2 && i >= -9 && i <= -2)
            {
                return 5 - i;
            }

            if (b1 && !b2 && i < -9)
            {
                return i;
            }

            if (b1 && !b2 && i > -2 && i < 0)
            {
                return i;
            }

            if (b1 && !b2 && i > 0 && i < 2)
            {
                return i;
            }

            if (!b1 && b2 && i == 0)
            {
                return 1;
            }

            if (!b1 && b2 && i > -10 && i <= -5)
            {
                return i;
            }

            if (!b1 && b2 && i >= 5 && i < 10)
            {
                return i;
            }

            if (!b1 && b2 && i <= -10)
            {
                return i + 1;
            }

            if (!b1 && b2 && i >= 10)
            {
                return i + 1;
            }

            if (!b1 && b2 && i >= -5 && i < 0)
            {
                return i + 10;
            }

            if (!b1 && b2 && i > 0 && i < 5)
            {
                return i + 10;
            }

            if (!b1 && !b2 && i == 0)
            {
                return -1;
            }

            if (!b1 && !b2 && i > -10 && i <= -5)
            {
                return i;
            }

            if (!b1 && !b2 && i >= 5 && i < 10)
            {
                return i;
            }

            if (!b1 && !b2 && i <= -10)
            {
                return i - 1;
            }

            if (!b1 && !b2 && i >= 10)
            {
                return i - 1;
            }

            if (!b1 && !b2 && i > -5 && i < 0)
            {
                return i - 10;
            }

            if (!b1 && !b2 && i > 0 && i < 5)
            {
                return i - 10;
            }

            return i;
        }
    }
}
