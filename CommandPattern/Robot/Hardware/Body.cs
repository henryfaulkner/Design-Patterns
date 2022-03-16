namespace Robot
{
    public class Body
    {
        string currentAction = string.Empty;

        public void SetCurrentBodyType(string action)
        {
            currentAction = action;
        }
    }
}