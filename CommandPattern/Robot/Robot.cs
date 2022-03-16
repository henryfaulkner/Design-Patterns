namespace Robot
{
    public class Robot
    {
        ICommand action;

        public Robot() { }

        public void SetCommand(ICommand command)
        {
            action = command;
        }

        public void ActivateCommand()
        {
            action.Execute();
        }
    }
}