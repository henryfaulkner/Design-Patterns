namespace OOPShooterVendingMachine
{
    public interface IState
    {
        void InsertDollar();
        void EjectDollar();
        void PressButton();
        void DispenseLiquor();
    }
}