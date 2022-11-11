namespace IfStatements
{
    public static class Task3
    {
        public static bool DoSomething1(bool b)
        {
            bool result = true;

            if (b is true)
            {
                return false;
            }

            return result;
        }

        public static bool DoSomething2(bool b)
        {
            bool result = true;

            if (b)
            {
                return false;
            }

            return result;
        }
    }
}
