namespace IfStatements
{
    public static class Task12
    {
        public static int DoSomething(int i)
        {
            int result = i;

            if (i < -8)
            {
                return i * i;
            }

            if (i >= -8 && i < -5)
            {
                return i;
            }

            if (i >= -5 && i < 5)
            {
                return (i * i) - i;
            }

            if (i >= 5 && i < 10)
            {
                return i;
            }

            if (i >= 10)
            {
                return 0 - (i * i);
            }

            return result;
        }
    }
}
