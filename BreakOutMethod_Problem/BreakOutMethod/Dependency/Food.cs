using System.Threading;

namespace BreakOutMethod.Dependency
{
    public class Food
    {
        public new string ToString()
        {
            Thread.Sleep(30000);
            return "Food";
        }
    }
}
