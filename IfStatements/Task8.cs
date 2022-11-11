namespace IfStatements
{
    public static class Task8
    {
        public static bool DoSomething(bool b, int i)
        {
            bool result = false;
            if (b)
            {
                if ((i < -6) || (i >= -3 && i < 0) || (i > 0 && i <= 3) || (i > 6))
                {
                    return true;
                }

                if ((i >= -6 && i < -3) || (i == 0) || (i > 3 && i <= 6))
                {
                    return false;
                }
            }

            if (!b)
            {
                if ((i < -6) || (i > -3 && i < 0) || (i > 0 && i < 3) || (i > 6))
                {
                    return true;
                }

                if ((i >= -6 && i <= -3) || (i == 0) || (i >= 3 && i <= 6))
                {
                    return false;
                }
            }

            return result;
        }
    }
}
