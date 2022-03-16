using System;

namespace Robot
{
    class Program
    {
        public static void Main(string[] args)
        {
            Voice v = new Voice();
            v.SetCurrentVocalType(ActionConstants.VocalType.Fortunes);
            v.On();
        }
    }
}
