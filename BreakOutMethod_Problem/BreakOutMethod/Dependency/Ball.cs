using System.Threading;

namespace BreakOutMethod.Dependency
{
    public class Ball
    {
        public new string ToString()
        {
            Thread.Sleep(30000);
            return "Ball";
        }
    }
}
