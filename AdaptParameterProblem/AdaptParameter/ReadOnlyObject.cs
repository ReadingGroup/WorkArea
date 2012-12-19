using System.Threading;

namespace AdaptParameter
{
    public sealed class ReadOnlyObject : IReadOnlyInterface
    {
        private void iAmVerySlow()
        {
            Thread.Sleep(30000);
        }

        public int Return1()
        {
            iAmVerySlow();
            return 1;
        }

        public int Return2()
        {
            iAmVerySlow();
            return 2;
        }

        public int Return3()
        {
            iAmVerySlow();
            return 3;
        }

        public int Return4()
        {
            iAmVerySlow();
            return 4;
        }

        public int Return5()
        {
            iAmVerySlow();
            return 5;
        }

        public int Return6()
        {
            iAmVerySlow();
            return 6;
        }

        public int Return7()
        {
            iAmVerySlow();
            return 7;
        }

        public int Return8()
        {
            iAmVerySlow();
            return 8;
        }

        public int Return9()
        {
            iAmVerySlow();
            return 9;
        }

        public int Return10()
        {
            iAmVerySlow();
            return 10;
        }

        public int Return11()
        {
            iAmVerySlow();
            return 11;
        }

        public int Return12()
        {
            iAmVerySlow();
            return 12;
        }

    }
}
