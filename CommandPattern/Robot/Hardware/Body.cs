using System;

namespace Robot
{
    public class Body
    {
        string currentAction = null;

        public void SetCurrentBodyType(string action)
        {
            currentAction = action;
        }

        public void On()
        {
            Console.Write("*Robot is dancing*\n");
        }

        public void Off()
        {
            Console.Write("Robot stopped dancing.\n\n");
        }
    }
}