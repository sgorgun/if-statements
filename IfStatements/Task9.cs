namespace IfStatements
{
    public static class Task9
    {
        public static bool DoSomething(bool b, int i)
        {
            bool result = false;

            if (b && ((i < 0 && (i >= -4 || i < -8)) || (i > 0 && (i <= 4 || i > 8))))
            {
                return true;
            }

            if (!b && i != 0 && !((i < -4 && i >= -8) || (i >= 4 && i < 8)))
            {
                return true;
            }

            return result;
        }
    }
}
