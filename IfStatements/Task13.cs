namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            int result = i;

            if (b)
            {
                if (i == 0)
                {
                    result = 10;
                }

                if ((i < -8) || (i >= -4 && i < 0))
                {
                    result = 5 + i;
                }

                if (i >= -8 && i < -4)
                {
                    result = i;
                }

                if (i > 0 && i <= 3)
                {
                    result = i - 5;
                }

                if (i > 3)
                {
                    result = i * -1;
                }
            }

            if (!b)
            {
                if (i > -5 && i <= 5)
                {
                    result = 10 - i;
                }

                if (i <= -5 || i > 5)
                {
                    result = i * -1;
                }
            }

            return result;
        }
    }
}
